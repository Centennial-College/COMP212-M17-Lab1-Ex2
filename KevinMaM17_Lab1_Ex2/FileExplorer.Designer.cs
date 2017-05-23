namespace KevinMaM17_Lab1_Ex2
{
    partial class FileExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastModifiedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpToParent = new System.Windows.Forms.ToolStripButton();
            this.toolStripUrlTxtBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNumItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelItemsSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ribbonTabControl = new System.Windows.Forms.TabControl();
            this.homeTabPage = new System.Windows.Forms.TabPage();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.viewTabPage = new System.Windows.Forms.TabPage();
            this.btnSmallIconsView = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnDetailsView = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewWindowToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewWindowInNewProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandPromptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandPromptAsAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWindowsPowerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWindowsPowerShellAsAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeFoldersAndSearchOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.topFlowLayoutPanel.SuspendLayout();
            this.ribbonTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.viewTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(0, 125);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listView1);
            this.splitContainer.Size = new System.Drawing.Size(1000, 453);
            this.splitContainer.SplitterDistance = 333;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(331, 451);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder");
            this.imageList1.Images.SetKeyName(1, "document");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.typeColumn,
            this.lastModifiedColumn});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 451);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            // 
            // lastModifiedColumn
            // 
            this.lastModifiedColumn.Text = "Last Modified";
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPrevious,
            this.toolStripBtnNext,
            this.toolStripBtnUpToParent,
            this.toolStripUrlTxtBox,
            this.toolStripButtonRefresh,
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearch});
            this.toolStrip.Location = new System.Drawing.Point(0, 100);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStrip.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripBtnPrevious
            // 
            this.toolStripBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrevious.Enabled = false;
            this.toolStripBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrevious.Image")));
            this.toolStripBtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrevious.Name = "toolStripBtnPrevious";
            this.toolStripBtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPrevious.Text = "Previous";
            // 
            // toolStripBtnNext
            // 
            this.toolStripBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNext.Enabled = false;
            this.toolStripBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNext.Image")));
            this.toolStripBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNext.Name = "toolStripBtnNext";
            this.toolStripBtnNext.RightToLeftAutoMirrorImage = true;
            this.toolStripBtnNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnNext.Text = "Forward";
            // 
            // toolStripBtnUpToParent
            // 
            this.toolStripBtnUpToParent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUpToParent.Enabled = false;
            this.toolStripBtnUpToParent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUpToParent.Image")));
            this.toolStripBtnUpToParent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpToParent.Name = "toolStripBtnUpToParent";
            this.toolStripBtnUpToParent.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnUpToParent.Text = "Up to parent directory";
            // 
            // toolStripUrlTxtBox
            // 
            this.toolStripUrlTxtBox.BackColor = System.Drawing.Color.White;
            this.toolStripUrlTxtBox.Name = "toolStripUrlTxtBox";
            this.toolStripUrlTxtBox.ReadOnly = true;
            this.toolStripUrlTxtBox.Size = new System.Drawing.Size(625, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(225, 25);
            this.toolStripTextBoxSearch.Text = "Search this directory";
            this.toolStripTextBoxSearch.Enter += new System.EventHandler(this.toolStripTextBoxSearch_Enter);
            this.toolStripTextBoxSearch.Leave += new System.EventHandler(this.toolStripTextBoxSearch_Leave);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Enabled = false;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearch.Text = "Search";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNumItems,
            this.toolStripStatusLabelItemsSelected});
            this.statusStrip.Location = new System.Drawing.Point(0, 578);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelNumItems
            // 
            this.toolStripStatusLabelNumItems.Name = "toolStripStatusLabelNumItems";
            this.toolStripStatusLabelNumItems.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabelNumItems.Text = "toolStripStatusLabelNumItems";
            // 
            // toolStripStatusLabelItemsSelected
            // 
            this.toolStripStatusLabelItemsSelected.Name = "toolStripStatusLabelItemsSelected";
            this.toolStripStatusLabelItemsSelected.Size = new System.Drawing.Size(185, 17);
            this.toolStripStatusLabelItemsSelected.Text = "toolStripStatusLabelItemsSelected";
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.AutoSize = true;
            this.topFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topFlowLayoutPanel.Controls.Add(this.ribbonTabControl);
            this.topFlowLayoutPanel.Controls.Add(this.toolStrip);
            this.topFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(1000, 600);
            this.topFlowLayoutPanel.TabIndex = 0;
            // 
            // ribbonTabControl
            // 
            this.ribbonTabControl.Controls.Add(this.homeTabPage);
            this.ribbonTabControl.Controls.Add(this.viewTabPage);
            this.ribbonTabControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonTabControl.Name = "ribbonTabControl";
            this.ribbonTabControl.Padding = new System.Drawing.Point(0, 0);
            this.ribbonTabControl.SelectedIndex = 0;
            this.ribbonTabControl.Size = new System.Drawing.Size(1000, 100);
            this.ribbonTabControl.TabIndex = 0;
            this.ribbonTabControl.SelectedIndexChanged += new System.EventHandler(this.ribbonTabControl_SelectedIndexChanged);
            // 
            // homeTabPage
            // 
            this.homeTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.homeTabPage.Controls.Add(this.btnMoveTo);
            this.homeTabPage.Controls.Add(this.btnRename);
            this.homeTabPage.Controls.Add(this.btnDelete);
            this.homeTabPage.Controls.Add(this.btnCopy);
            this.homeTabPage.Location = new System.Drawing.Point(4, 22);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.homeTabPage.Size = new System.Drawing.Size(992, 74);
            this.homeTabPage.TabIndex = 1;
            this.homeTabPage.Text = "Home";
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnMoveTo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMoveTo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMoveTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMoveTo.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveTo.Image")));
            this.btnMoveTo.Location = new System.Drawing.Point(251, 3);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(75, 64);
            this.btnMoveTo.TabIndex = 4;
            this.btnMoveTo.Text = "Move to";
            this.btnMoveTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoveTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // btnRename
            // 
            this.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRename.Image = ((System.Drawing.Image)(resources.GetObject("btnRename.Image")));
            this.btnRename.Location = new System.Drawing.Point(170, 3);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 64);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Rename";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(89, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 64);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(8, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 64);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // viewTabPage
            // 
            this.viewTabPage.BackColor = System.Drawing.Color.Transparent;
            this.viewTabPage.Controls.Add(this.btnSmallIconsView);
            this.viewTabPage.Controls.Add(this.btnListView);
            this.viewTabPage.Controls.Add(this.btnDetailsView);
            this.viewTabPage.Location = new System.Drawing.Point(4, 22);
            this.viewTabPage.Name = "viewTabPage";
            this.viewTabPage.Size = new System.Drawing.Size(992, 74);
            this.viewTabPage.TabIndex = 3;
            this.viewTabPage.Text = "View";
            // 
            // btnSmallIconsView
            // 
            this.btnSmallIconsView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnSmallIconsView.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSmallIconsView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSmallIconsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmallIconsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSmallIconsView.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallIconsView.Image")));
            this.btnSmallIconsView.Location = new System.Drawing.Point(170, 3);
            this.btnSmallIconsView.Name = "btnSmallIconsView";
            this.btnSmallIconsView.Size = new System.Drawing.Size(75, 64);
            this.btnSmallIconsView.TabIndex = 3;
            this.btnSmallIconsView.Text = "Small Icons";
            this.btnSmallIconsView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSmallIconsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSmallIconsView.UseVisualStyleBackColor = true;
            this.btnSmallIconsView.Click += new System.EventHandler(this.btnSmallIconsView_Click);
            // 
            // btnListView
            // 
            this.btnListView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnListView.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnListView.Image = ((System.Drawing.Image)(resources.GetObject("btnListView.Image")));
            this.btnListView.Location = new System.Drawing.Point(89, 3);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(75, 64);
            this.btnListView.TabIndex = 2;
            this.btnListView.Text = "List";
            this.btnListView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnDetailsView
            // 
            this.btnDetailsView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnDetailsView.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetailsView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetailsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDetailsView.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailsView.Image")));
            this.btnDetailsView.Location = new System.Drawing.Point(8, 3);
            this.btnDetailsView.Name = "btnDetailsView";
            this.btnDetailsView.Size = new System.Drawing.Size(75, 64);
            this.btnDetailsView.TabIndex = 1;
            this.btnDetailsView.Text = "Details";
            this.btnDetailsView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetailsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDetailsView.UseVisualStyleBackColor = true;
            this.btnDetailsView.Click += new System.EventHandler(this.btnDetailsView_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "fileMenuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(121)))), ((int)(((byte)(202)))));
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewWindowToolStripMenuItem1,
            this.openCommandPromptToolStripMenuItem,
            this.openWindowsPowerShellToolStripMenuItem,
            this.toolStripSeparator1,
            this.changeFoldersAndSearchOptionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openNewWindowToolStripMenuItem1
            // 
            this.openNewWindowToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewWindowToolStripMenuItem2,
            this.openNewWindowInNewProcessToolStripMenuItem});
            this.openNewWindowToolStripMenuItem1.Name = "openNewWindowToolStripMenuItem1";
            this.openNewWindowToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.openNewWindowToolStripMenuItem1.Text = "Open new window";
            // 
            // openNewWindowToolStripMenuItem2
            // 
            this.openNewWindowToolStripMenuItem2.Name = "openNewWindowToolStripMenuItem2";
            this.openNewWindowToolStripMenuItem2.Size = new System.Drawing.Size(254, 22);
            this.openNewWindowToolStripMenuItem2.Text = "Open new window";
            // 
            // openNewWindowInNewProcessToolStripMenuItem
            // 
            this.openNewWindowInNewProcessToolStripMenuItem.Name = "openNewWindowInNewProcessToolStripMenuItem";
            this.openNewWindowInNewProcessToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.openNewWindowInNewProcessToolStripMenuItem.Text = "Open new window in new process";
            // 
            // openCommandPromptToolStripMenuItem
            // 
            this.openCommandPromptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCommandPromptToolStripMenuItem1,
            this.openCommandPromptAsAdministratorToolStripMenuItem});
            this.openCommandPromptToolStripMenuItem.Name = "openCommandPromptToolStripMenuItem";
            this.openCommandPromptToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openCommandPromptToolStripMenuItem.Text = "Open command prompt";
            // 
            // openCommandPromptToolStripMenuItem1
            // 
            this.openCommandPromptToolStripMenuItem1.Name = "openCommandPromptToolStripMenuItem1";
            this.openCommandPromptToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.openCommandPromptToolStripMenuItem1.Text = "Open command prompt";
            // 
            // openCommandPromptAsAdministratorToolStripMenuItem
            // 
            this.openCommandPromptAsAdministratorToolStripMenuItem.Name = "openCommandPromptAsAdministratorToolStripMenuItem";
            this.openCommandPromptAsAdministratorToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.openCommandPromptAsAdministratorToolStripMenuItem.Text = "Open command prompt as administrator";
            // 
            // openWindowsPowerShellToolStripMenuItem
            // 
            this.openWindowsPowerShellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWindowsPowerShellAsAdministratorToolStripMenuItem});
            this.openWindowsPowerShellToolStripMenuItem.Name = "openWindowsPowerShellToolStripMenuItem";
            this.openWindowsPowerShellToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openWindowsPowerShellToolStripMenuItem.Text = "Open Windows PowerShell";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.openToolStripMenuItem.Text = "Open Windows PowerShell";
            // 
            // openWindowsPowerShellAsAdministratorToolStripMenuItem
            // 
            this.openWindowsPowerShellAsAdministratorToolStripMenuItem.Name = "openWindowsPowerShellAsAdministratorToolStripMenuItem";
            this.openWindowsPowerShellAsAdministratorToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.openWindowsPowerShellAsAdministratorToolStripMenuItem.Text = "Open Windows PowerShell as administrator";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // changeFoldersAndSearchOptionsToolStripMenuItem
            // 
            this.changeFoldersAndSearchOptionsToolStripMenuItem.Name = "changeFoldersAndSearchOptionsToolStripMenuItem";
            this.changeFoldersAndSearchOptionsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.changeFoldersAndSearchOptionsToolStripMenuItem.Text = "Change folders and search options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutWindowsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutWindowsToolStripMenuItem
            // 
            this.aboutWindowsToolStripMenuItem.Name = "aboutWindowsToolStripMenuItem";
            this.aboutWindowsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutWindowsToolStripMenuItem.Text = "About Windows";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // FileExplorer
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.topFlowLayoutPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.Resize += new System.EventHandler(this.FileExplorer_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.topFlowLayoutPanel.ResumeLayout(false);
            this.ribbonTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.viewTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrevious;
        private System.Windows.Forms.ToolStripButton toolStripBtnNext;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpToParent;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
        private System.Windows.Forms.ColumnHeader lastModifiedColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumItems;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelItemsSelected;
        private System.Windows.Forms.ToolStripTextBox toolStripUrlTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewWindowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openCommandPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWindowsPowerShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changeFoldersAndSearchOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewWindowToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openNewWindowInNewProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCommandPromptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openCommandPromptAsAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWindowsPowerShellAsAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutWindowsToolStripMenuItem;
        private System.Windows.Forms.TabControl ribbonTabControl;
        private System.Windows.Forms.TabPage homeTabPage;
        private System.Windows.Forms.Button btnMoveTo;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TabPage viewTabPage;
        private System.Windows.Forms.Button btnSmallIconsView;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button btnDetailsView;
    }
}

