namespace eCatDebug
{
    partial class FormObserver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObserver));
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuForListData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWatchListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.btnEndworkflow = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listViewWatch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuForListWatch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromWatchListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.rtMessage = new System.Windows.Forms.RichTextBox();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbCurrentActionName = new System.Windows.Forms.Label();
            this.lbLastNextCondition = new System.Windows.Forms.Label();
            this.lbCurrentUILanguage = new System.Windows.Forms.Label();
            this.lbCurrentScreenName = new System.Windows.Forms.Label();
            this.lbActionID = new System.Windows.Forms.Label();
            this.lbActionTimeout = new System.Windows.Forms.Label();
            this.lbLastActionName = new System.Windows.Forms.Label();
            this.lbLastWorkflowName = new System.Windows.Forms.Label();
            this.lbCurrentWorkflowName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnReDraw = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPostWorkflow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKileCat = new System.Windows.Forms.Button();
            this.btnStarteCat = new System.Windows.Forms.Button();
            this.contextMenuForListData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuForListWatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderType,
            this.columnHeaderKey,
            this.columnHeaderValue});
            this.listViewData.ContextMenuStrip = this.contextMenuForListData;
            this.listViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewData.FullRowSelect = true;
            this.listViewData.GridLines = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(0, 0);
            this.listViewData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewData.MultiSelect = false;
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(498, 227);
            this.listViewData.TabIndex = 0;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            this.listViewData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewData_MouseDoubleClick);
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 90;
            // 
            // columnHeaderKey
            // 
            this.columnHeaderKey.Text = "key";
            this.columnHeaderKey.Width = 200;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 300;
            // 
            // contextMenuForListData
            // 
            this.contextMenuForListData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuForListData.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuForListData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToWatchListToolStripMenuItem});
            this.contextMenuForListData.Name = "contextMenuForListData";
            this.contextMenuForListData.Size = new System.Drawing.Size(327, 40);
            // 
            // addToWatchListToolStripMenuItem
            // 
            this.addToWatchListToolStripMenuItem.Name = "addToWatchListToolStripMenuItem";
            this.addToWatchListToolStripMenuItem.Size = new System.Drawing.Size(326, 36);
            this.addToWatchListToolStripMenuItem.Text = "Add To Watch List";
            this.addToWatchListToolStripMenuItem.Click += new System.EventHandler(this.addToWatchListToolStripMenuItem_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 31;
            this.listBoxLog.Location = new System.Drawing.Point(0, 0);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(444, 234);
            this.listBoxLog.TabIndex = 0;
            this.listBoxLog.SelectedIndexChanged += new System.EventHandler(this.listBoxLog_SelectedIndexChanged);
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.buttonSaveLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveLog.Location = new System.Drawing.Point(6, 384);
            this.buttonSaveLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveLog.TabIndex = 6;
            this.buttonSaveLog.Text = "Save Log";
            this.buttonSaveLog.UseVisualStyleBackColor = false;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(6, 4);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(150, 30);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.buttonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(6, 42);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(150, 30);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // btnEndworkflow
            // 
            this.btnEndworkflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnEndworkflow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEndworkflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndworkflow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndworkflow.Location = new System.Drawing.Point(6, 80);
            this.btnEndworkflow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEndworkflow.Name = "btnEndworkflow";
            this.btnEndworkflow.Size = new System.Drawing.Size(150, 30);
            this.btnEndworkflow.TabIndex = 7;
            this.btnEndworkflow.Text = "End Workflow";
            this.btnEndworkflow.UseVisualStyleBackColor = false;
            this.btnEndworkflow.Click += new System.EventHandler(this.btnEndworkflow_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 86);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(945, 431);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listViewData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listViewWatch);
            this.splitContainer2.Size = new System.Drawing.Size(498, 431);
            this.splitContainer2.SplitterDistance = 227;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 2;
            // 
            // listViewWatch
            // 
            this.listViewWatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewWatch.ContextMenuStrip = this.contextMenuForListWatch;
            this.listViewWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWatch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewWatch.FullRowSelect = true;
            this.listViewWatch.GridLines = true;
            this.listViewWatch.HideSelection = false;
            this.listViewWatch.Location = new System.Drawing.Point(0, 0);
            this.listViewWatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewWatch.MultiSelect = false;
            this.listViewWatch.Name = "listViewWatch";
            this.listViewWatch.Size = new System.Drawing.Size(498, 199);
            this.listViewWatch.TabIndex = 1;
            this.listViewWatch.UseCompatibleStateImageBehavior = false;
            this.listViewWatch.View = System.Windows.Forms.View.Details;
            this.listViewWatch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewWatch_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "key";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 300;
            // 
            // contextMenuForListWatch
            // 
            this.contextMenuForListWatch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuForListWatch.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuForListWatch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromWatchListToolStripMenuItem});
            this.contextMenuForListWatch.Name = "contextMenuForListWatch";
            this.contextMenuForListWatch.Size = new System.Drawing.Size(397, 40);
            // 
            // removeFromWatchListToolStripMenuItem
            // 
            this.removeFromWatchListToolStripMenuItem.Name = "removeFromWatchListToolStripMenuItem";
            this.removeFromWatchListToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.removeFromWatchListToolStripMenuItem.Text = "Remove From Watch List";
            this.removeFromWatchListToolStripMenuItem.Click += new System.EventHandler(this.removeFromWatchListToolStripMenuItem_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBoxLog);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.rtMessage);
            this.splitContainer3.Size = new System.Drawing.Size(444, 431);
            this.splitContainer3.SplitterDistance = 234;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 1;
            // 
            // rtMessage
            // 
            this.rtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtMessage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtMessage.Location = new System.Drawing.Point(0, 0);
            this.rtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtMessage.Name = "rtMessage";
            this.rtMessage.Size = new System.Drawing.Size(444, 192);
            this.rtMessage.TabIndex = 0;
            this.rtMessage.Text = "";
            // 
            // pnStatus
            // 
            this.pnStatus.AutoScroll = true;
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.pnStatus.Controls.Add(this.lbCurrentActionName);
            this.pnStatus.Controls.Add(this.lbLastNextCondition);
            this.pnStatus.Controls.Add(this.lbCurrentUILanguage);
            this.pnStatus.Controls.Add(this.lbCurrentScreenName);
            this.pnStatus.Controls.Add(this.lbActionID);
            this.pnStatus.Controls.Add(this.lbActionTimeout);
            this.pnStatus.Controls.Add(this.lbLastActionName);
            this.pnStatus.Controls.Add(this.lbLastWorkflowName);
            this.pnStatus.Controls.Add(this.lbCurrentWorkflowName);
            this.pnStatus.Controls.Add(this.label9);
            this.pnStatus.Controls.Add(this.label10);
            this.pnStatus.Controls.Add(this.label8);
            this.pnStatus.Controls.Add(this.label7);
            this.pnStatus.Controls.Add(this.label6);
            this.pnStatus.Controls.Add(this.label5);
            this.pnStatus.Controls.Add(this.label4);
            this.pnStatus.Controls.Add(this.label3);
            this.pnStatus.Controls.Add(this.label2);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStatus.ForeColor = System.Drawing.Color.Gold;
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Margin = new System.Windows.Forms.Padding(2);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(1113, 86);
            this.pnStatus.TabIndex = 8;
            // 
            // lbCurrentActionName
            // 
            this.lbCurrentActionName.AutoSize = true;
            this.lbCurrentActionName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentActionName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbCurrentActionName.Location = new System.Drawing.Point(444, 8);
            this.lbCurrentActionName.Name = "lbCurrentActionName";
            this.lbCurrentActionName.Size = new System.Drawing.Size(70, 31);
            this.lbCurrentActionName.TabIndex = 4;
            this.lbCurrentActionName.Text = "Data";
            this.lbCurrentActionName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCurrentActionName_MouseDoubleClick);
            // 
            // lbLastNextCondition
            // 
            this.lbLastNextCondition.AutoSize = true;
            this.lbLastNextCondition.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastNextCondition.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbLastNextCondition.Location = new System.Drawing.Point(709, 58);
            this.lbLastNextCondition.Name = "lbLastNextCondition";
            this.lbLastNextCondition.Size = new System.Drawing.Size(70, 31);
            this.lbLastNextCondition.TabIndex = 3;
            this.lbLastNextCondition.Text = "Data";
            // 
            // lbCurrentUILanguage
            // 
            this.lbCurrentUILanguage.AutoSize = true;
            this.lbCurrentUILanguage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUILanguage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbCurrentUILanguage.Location = new System.Drawing.Point(444, 58);
            this.lbCurrentUILanguage.Name = "lbCurrentUILanguage";
            this.lbCurrentUILanguage.Size = new System.Drawing.Size(70, 31);
            this.lbCurrentUILanguage.TabIndex = 3;
            this.lbCurrentUILanguage.Text = "Data";
            // 
            // lbCurrentScreenName
            // 
            this.lbCurrentScreenName.AutoSize = true;
            this.lbCurrentScreenName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentScreenName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbCurrentScreenName.Location = new System.Drawing.Point(165, 58);
            this.lbCurrentScreenName.Name = "lbCurrentScreenName";
            this.lbCurrentScreenName.Size = new System.Drawing.Size(70, 31);
            this.lbCurrentScreenName.TabIndex = 3;
            this.lbCurrentScreenName.Text = "Data";
            this.lbCurrentScreenName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCurrentScreenName_MouseDoubleClick);
            // 
            // lbActionID
            // 
            this.lbActionID.AutoSize = true;
            this.lbActionID.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActionID.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbActionID.Location = new System.Drawing.Point(709, 32);
            this.lbActionID.Name = "lbActionID";
            this.lbActionID.Size = new System.Drawing.Size(70, 31);
            this.lbActionID.TabIndex = 3;
            this.lbActionID.Text = "Data";
            // 
            // lbActionTimeout
            // 
            this.lbActionTimeout.AutoSize = true;
            this.lbActionTimeout.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActionTimeout.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbActionTimeout.Location = new System.Drawing.Point(709, 8);
            this.lbActionTimeout.Name = "lbActionTimeout";
            this.lbActionTimeout.Size = new System.Drawing.Size(70, 31);
            this.lbActionTimeout.TabIndex = 3;
            this.lbActionTimeout.Text = "Data";
            // 
            // lbLastActionName
            // 
            this.lbLastActionName.AutoSize = true;
            this.lbLastActionName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastActionName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbLastActionName.Location = new System.Drawing.Point(444, 32);
            this.lbLastActionName.Name = "lbLastActionName";
            this.lbLastActionName.Size = new System.Drawing.Size(70, 31);
            this.lbLastActionName.TabIndex = 3;
            this.lbLastActionName.Text = "Data";
            this.lbLastActionName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLastActionName_MouseDoubleClick);
            // 
            // lbLastWorkflowName
            // 
            this.lbLastWorkflowName.AutoSize = true;
            this.lbLastWorkflowName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastWorkflowName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbLastWorkflowName.Location = new System.Drawing.Point(165, 32);
            this.lbLastWorkflowName.Name = "lbLastWorkflowName";
            this.lbLastWorkflowName.Size = new System.Drawing.Size(70, 31);
            this.lbLastWorkflowName.TabIndex = 3;
            this.lbLastWorkflowName.Text = "Data";
            this.lbLastWorkflowName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLastWorkflowName_MouseDoubleClick);
            // 
            // lbCurrentWorkflowName
            // 
            this.lbCurrentWorkflowName.AutoSize = true;
            this.lbCurrentWorkflowName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCurrentWorkflowName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentWorkflowName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbCurrentWorkflowName.Location = new System.Drawing.Point(165, 8);
            this.lbCurrentWorkflowName.Name = "lbCurrentWorkflowName";
            this.lbCurrentWorkflowName.Size = new System.Drawing.Size(70, 31);
            this.lbCurrentWorkflowName.TabIndex = 3;
            this.lbCurrentWorkflowName.Text = "Data";
            this.lbCurrentWorkflowName.Click += new System.EventHandler(this.lbCurrentWorkflowName_Click);
            this.lbCurrentWorkflowName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCurrentWorkflowName_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(326, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "LastActionName:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(570, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "LastNextCondition:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(633, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "ActionID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(598, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "ActionTimeout:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(305, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "CurrentUILanguage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "CurrentScreenName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(305, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "CurrentActionName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastWorkflowName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "CurrentWorkflowName:";
            // 
            // btnReboot
            // 
            this.btnReboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnReboot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReboot.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.Location = new System.Drawing.Point(6, 156);
            this.btnReboot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(150, 30);
            this.btnReboot.TabIndex = 7;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = false;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.Location = new System.Drawing.Point(6, 194);
            this.btnShutDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(150, 30);
            this.btnShutDown.TabIndex = 7;
            this.btnShutDown.Text = "ShutDown";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnReDraw
            // 
            this.btnReDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnReDraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReDraw.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReDraw.Location = new System.Drawing.Point(6, 270);
            this.btnReDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReDraw.Name = "btnReDraw";
            this.btnReDraw.Size = new System.Drawing.Size(150, 30);
            this.btnReDraw.TabIndex = 7;
            this.btnReDraw.Text = "ReDrawCurrentUI";
            this.btnReDraw.UseVisualStyleBackColor = false;
            this.btnReDraw.Click += new System.EventHandler(this.btnReDraw_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(6, 232);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 30);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "ReLoadUI";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnPostWorkflow
            // 
            this.btnPostWorkflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnPostWorkflow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPostWorkflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostWorkflow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostWorkflow.Location = new System.Drawing.Point(6, 118);
            this.btnPostWorkflow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostWorkflow.Name = "btnPostWorkflow";
            this.btnPostWorkflow.Size = new System.Drawing.Size(150, 30);
            this.btnPostWorkflow.TabIndex = 7;
            this.btnPostWorkflow.Text = "PostNewWorkFlow";
            this.btnPostWorkflow.UseVisualStyleBackColor = false;
            this.btnPostWorkflow.Click += new System.EventHandler(this.btnPostWorkflow_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.buttonSaveLog);
            this.panel1.Controls.Add(this.btnKileCat);
            this.panel1.Controls.Add(this.btnStarteCat);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.btnReDraw);
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnPostWorkflow);
            this.panel1.Controls.Add(this.btnEndworkflow);
            this.panel1.Controls.Add(this.btnShutDown);
            this.panel1.Controls.Add(this.btnReboot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(945, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 431);
            this.panel1.TabIndex = 9;
            // 
            // btnKileCat
            // 
            this.btnKileCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnKileCat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKileCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKileCat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKileCat.Location = new System.Drawing.Point(6, 346);
            this.btnKileCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKileCat.Name = "btnKileCat";
            this.btnKileCat.Size = new System.Drawing.Size(150, 30);
            this.btnKileCat.TabIndex = 7;
            this.btnKileCat.Text = "InstallService";
            this.btnKileCat.UseVisualStyleBackColor = false;
            this.btnKileCat.Click += new System.EventHandler(this.btnKileCat_Click);
            // 
            // btnStarteCat
            // 
            this.btnStarteCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnStarteCat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStarteCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarteCat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarteCat.Location = new System.Drawing.Point(6, 308);
            this.btnStarteCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStarteCat.Name = "btnStarteCat";
            this.btnStarteCat.Size = new System.Drawing.Size(150, 30);
            this.btnStarteCat.TabIndex = 7;
            this.btnStarteCat.Text = "DebugReboot";
            this.btnStarteCat.UseVisualStyleBackColor = false;
            this.btnStarteCat.Click += new System.EventHandler(this.btnReStarteCat_Click);
            // 
            // FormObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 517);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnStatus);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormObserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eCAT Observer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.FormObserver_Load);
            this.contextMenuForListData.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuForListWatch.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderKey;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listViewWatch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuForListData;
        private System.Windows.Forms.ToolStripMenuItem addToWatchListToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuForListWatch;
        private System.Windows.Forms.ToolStripMenuItem removeFromWatchListToolStripMenuItem;
        private System.Windows.Forms.Button btnEndworkflow;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox rtMessage;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnReDraw;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPostWorkflow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCurrentActionName;
        private System.Windows.Forms.Label lbLastNextCondition;
        private System.Windows.Forms.Label lbCurrentUILanguage;
        private System.Windows.Forms.Label lbCurrentScreenName;
        private System.Windows.Forms.Label lbActionID;
        private System.Windows.Forms.Label lbActionTimeout;
        private System.Windows.Forms.Label lbLastActionName;
        private System.Windows.Forms.Label lbLastWorkflowName;
        private System.Windows.Forms.Label lbCurrentWorkflowName;
        private System.Windows.Forms.Button btnStarteCat;
        private System.Windows.Forms.Button btnKileCat;
    }
}

