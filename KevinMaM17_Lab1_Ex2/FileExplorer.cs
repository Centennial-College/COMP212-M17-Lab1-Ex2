using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;

namespace KevinMaM17_Lab1_Ex2
{
    public partial class FileExplorer : Form
    {
        String rootPath = @"C:\Users\Kevin\Desktop";
        TreeNode rootNode;
        String tempFileName;

        public FileExplorer()
        {
            InitializeComponent();
            PopulateTreeView();
            this.ribbonTabControl.SelectedTab = homeTabPage;
        }

        private void toolStripTextBoxSearch_Enter(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Text = "";
        }

        private void toolStripTextBoxSearch_Leave(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Text = "Search this directory";
        }

        private void FileExplorer_Resize(object sender, EventArgs e)
        {
            //resize the controls to respond dynamically
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(this.ClientSize.Width, 125);
            this.ribbonTabControl.Size = new System.Drawing.Size(this.ClientSize.Width, 100);
            this.toolStripUrlTxtBox.Size = new Size(Convert.ToInt32(ClientSize.Width * 0.60), 25);
            this.toolStripTextBoxSearch.Size = new Size(Convert.ToInt32(ClientSize.Width * 0.25), 25);
            this.toolStrip.Size = new System.Drawing.Size(this.ClientSize.Width, 25);
            this.splitContainer.Size = new Size(ClientSize.Width, statusStrip.Location.Y - 125);
            this.splitContainer.SplitterDistance = ClientSize.Width / 4;
        }

        /**
         * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         * NOTE: Some of the code below is from Ilia Nika and developers from Microsoft
         * More information can be found at: https://msdn.microsoft.com/en-us/library/ms171645(v=vs.110).aspx
         */
        private void PopulateTreeView()
        {
            //TreeNode rootNode;
            //
            treeView1.BeginUpdate();

            DirectoryInfo info = new DirectoryInfo(rootPath + @"\COMP212-Programming3");
            if (info.Exists)
            {
                //set the above directory as root node
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                //get the directories under root node
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
            treeView1.EndUpdate();
            populateListView(rootNode);
            treeView1.SelectedNode = rootNode;
            toolStripStatusLabelItemsSelected.Text = "0 items selected";
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            try
            {
                TreeNode aNode;
                DirectoryInfo[] subSubDirs;
                foreach (DirectoryInfo subDir in subDirs)
                {

                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    aNode.ImageKey = "folder";
                    subSubDirs = subDir.GetDirectories();
                    //call recursively the method to get directories of each node.
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                    nodeToAddTo.Nodes.Add(aNode);

                }
            }
            // access denied
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: Some files may not be " +
                   "visible due to permission settings",
                   "Attention", 0, MessageBoxIcon.Warning);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Warning: Some files may  have " +
                   "a long path",
                   "Attention", 0, MessageBoxIcon.Warning);
            }
        }
        private void populateListView(TreeNode n)
        {
            TreeNode newSelected = n;
            listView1.Items.Clear();

            //updates URL with current working directory path
            toolStripUrlTxtBox.Text = rootPath + "\\" + newSelected.FullPath;

            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
                     new ListViewItem.ListViewSubItem(item,
                        dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);

            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
                     new ListViewItem.ListViewSubItem(item,
                        file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            toolStripStatusLabelNumItems.Text = listView1.Items.Count == 1 ? "1 item" : listView1.Items.Count + " items";
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            populateListView(e.Node);
        }

        private void ribbonTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ribbonTabControl.SelectedTab.BackColor = Color.FromArgb(245, 246, 247);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelItemsSelected.Text = listView1.SelectedItems.Count == 1 ? "1 item selected" : listView1.SelectedItems.Count + " items selected";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string fileName;
            string srcPath;
            string destPath;
            FileInfo srcFi;

            //copying all selected files since the listview allows multiple selections
            foreach (ListViewItem selectedFile in listView1.SelectedItems)
            {
                fileName = selectedFile.Text;
                srcPath = toolStripUrlTxtBox.Text + fileName;
                srcFi = new FileInfo(srcPath);

                //only make a copy if it is not a directory
                if (srcFi.Extension.Length == 0)
                {
                    MessageBox.Show(fileName + " is a directory and can not be copied!", "Directory Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //string manipulation to change name to 'xxx.ext' to 'xxx - Copy.ext'
                    destPath = toolStripUrlTxtBox.Text + @"\" + fileName.Substring(0, fileName.Length - 4) + " - Copy" + fileName.Substring(fileName.Length - 4);

                    try
                    {
                        //only make a copy if it does not already exist
                        if (File.Exists(destPath))
                        {
                            MessageBox.Show(destPath + " already exists and will not be copied.", "Duplicate File!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //Create the source file within a 'using' statmenet as it calls the Dispose method on the
                            //object in the right way when resources are done processing
                            using (FileStream fs = srcFi.Create()) { }

                            //Copy a file to another location
                            srcFi.CopyTo(destPath);
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            //refreshes the listview when the selected file has been copied
            populateListView(treeView1.SelectedNode);

            //// To copy all the files in one directory to another directory.
            //// Get the files in the source folder. (To recursively iterate through
            //// all subfolders under the current directory, see
            //// "How to: Iterate Through a Directory Tree.")
            //// Note: Check for target path was performed previously
            ////       in this code example.
            //if (System.IO.Directory.Exists(sourcePath))
            //{
            //    string[] files = System.IO.Directory.GetFiles(sourcePath);

            //    // Copy the files and overwrite destination files if they already exist.
            //    foreach (string s in files)
            //    {
            //        // Use static Path methods to extract only the file name from the path.
            //        fileName = System.IO.Path.GetFileName(s);
            //        destFile = System.IO.Path.Combine(targetPath, fileName);
            //        System.IO.File.Copy(s, destFile, true);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Source path does not exist!");
            //}
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fileName;
            string srcPath;
            FileInfo srcFi;

            //deleting all selected files since the listview allows multiple selections
            foreach (ListViewItem selectedFile in listView1.SelectedItems)
            {
                fileName = selectedFile.Text;
                srcPath = toolStripUrlTxtBox.Text + @"\" + fileName;
                srcFi = new FileInfo(srcPath);

                //only delete if it is not a directory
                if (srcFi.Extension.Length == 0)
                {
                    MessageBox.Show(fileName + " is a directory and can not be deleted!", "Directory Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (srcFi.Exists)
                    srcFi.Delete();

            }
            //refreshes the listview when the selected file has been deleted
            populateListView(treeView1.SelectedNode);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            //can only rename the first selected item in the listView
            listView1.SelectedItems[0].BeginEdit();

            //NOTE: can also click on item to select, and click again to enter labelEdit mode
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(toolStripUrlTxtBox.Text + @"\" + tempFileName);
                fi.MoveTo(toolStripUrlTxtBox + @"\" + e.Label.ToString());

                if (fi.Extension.Length == 0)
                {
                    //need to update TreeView if renaming directories
                    foreach (TreeNode node in treeView1.Nodes)
                    {
                        treeView1.Nodes.Remove(node);
                    }
                    PopulateTreeView();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            tempFileName = listView1.FocusedItem.Text;
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            string fileName;
            string destinationPath;
            FileInfo srcFi;

            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.SelectedPath = rootPath + @"\COMP212-Programming3";
                fbd.ShowDialog();
                destinationPath = fbd.SelectedPath;

                //deleting all selected files since the listview allows multiple selections
                foreach (ListViewItem selectedFile in listView1.SelectedItems)
                {
                    fileName = selectedFile.Text;
                    srcFi = new FileInfo(toolStripUrlTxtBox.Text + @"\" + fileName);

                    srcFi.MoveTo(destinationPath + @"\" + fileName);

                    if (srcFi.Extension.Length == 0)
                    {

                        //need to update TreeView if moving directories
                        foreach (TreeNode node in treeView1.Nodes)
                        {
                            treeView1.Nodes.Remove(node);
                        }
                        PopulateTreeView();
                    }

                }
                //refreshes the listview when the selected file has been moved
                populateListView(treeView1.SelectedNode);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDetailsView_Click(object sender, EventArgs e)
        {
            this.listView1.View = System.Windows.Forms.View.Details;

        }

        private void btnSmallIconsView_Click(object sender, EventArgs e)
        {
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            this.listView1.View = System.Windows.Forms.View.List;

        }
    }
}
