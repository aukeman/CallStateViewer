namespace CallStateViewer
{
    partial class CallStateViewerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallStateViewerMain));
            this.mLogRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCallIdDataGridView = new System.Windows.Forms.DataGridView();
            this.callIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalFateTimeTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalFateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.callSummaryPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.callSummaryFilterEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.logRecordPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logRecordFilterEnableCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mLogRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCallIdDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.callSummaryPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.logRecordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLogRecordDataGridView
            // 
            this.mLogRecordDataGridView.AllowUserToAddRows = false;
            this.mLogRecordDataGridView.AllowUserToDeleteRows = false;
            this.mLogRecordDataGridView.AllowUserToOrderColumns = true;
            this.mLogRecordDataGridView.AllowUserToResizeColumns = false;
            this.mLogRecordDataGridView.AllowUserToResizeRows = false;
            this.mLogRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mLogRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3});
            this.mLogRecordDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.mLogRecordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLogRecordDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mLogRecordDataGridView.Name = "mLogRecordDataGridView";
            this.mLogRecordDataGridView.ReadOnly = true;
            this.mLogRecordDataGridView.RowHeadersVisible = false;
            this.mLogRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mLogRecordDataGridView.Size = new System.Drawing.Size(882, 508);
            this.mLogRecordDataGridView.TabIndex = 1;
            this.mLogRecordDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mDataGridView_CellFormatting);
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "CallID";
            this.Column4.HeaderText = "Call ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 63;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "CurrentState";
            this.Column5.HeaderText = "Current State";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 94;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Timestamp";
            this.Column1.HeaderText = "Timestamp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 83;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Value";
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // mCallIdDataGridView
            // 
            this.mCallIdDataGridView.AllowUserToAddRows = false;
            this.mCallIdDataGridView.AllowUserToDeleteRows = false;
            this.mCallIdDataGridView.AllowUserToResizeColumns = false;
            this.mCallIdDataGridView.AllowUserToResizeRows = false;
            this.mCallIdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mCallIdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.callIDTextBoxColumn,
            this.timeInTextBoxColumn,
            this.finalFateTimeTextBoxColumn,
            this.finalFateTextBoxColumn,
            this.Column6});
            this.mCallIdDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.mCallIdDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCallIdDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mCallIdDataGridView.Name = "mCallIdDataGridView";
            this.mCallIdDataGridView.ReadOnly = true;
            this.mCallIdDataGridView.RowHeadersVisible = false;
            this.mCallIdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mCallIdDataGridView.Size = new System.Drawing.Size(400, 508);
            this.mCallIdDataGridView.TabIndex = 0;
            this.mCallIdDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mDataGridView_CellFormatting);
            this.mCallIdDataGridView.SelectionChanged += new System.EventHandler(this.mCallIdDataGridView_SelectionChanged);
            // 
            // callIDTextBoxColumn
            // 
            this.callIDTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.callIDTextBoxColumn.DataPropertyName = "CallId";
            this.callIDTextBoxColumn.HeaderText = "Call ID";
            this.callIDTextBoxColumn.Name = "callIDTextBoxColumn";
            this.callIDTextBoxColumn.ReadOnly = true;
            this.callIDTextBoxColumn.Width = 49;
            // 
            // timeInTextBoxColumn
            // 
            this.timeInTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeInTextBoxColumn.DataPropertyName = "TimeIn";
            this.timeInTextBoxColumn.HeaderText = "Time In";
            this.timeInTextBoxColumn.Name = "timeInTextBoxColumn";
            this.timeInTextBoxColumn.ReadOnly = true;
            this.timeInTextBoxColumn.Width = 62;
            // 
            // finalFateTimeTextBoxColumn
            // 
            this.finalFateTimeTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finalFateTimeTextBoxColumn.DataPropertyName = "FinalStateTime";
            this.finalFateTimeTextBoxColumn.HeaderText = "Final State Time";
            this.finalFateTimeTextBoxColumn.Name = "finalFateTimeTextBoxColumn";
            this.finalFateTimeTextBoxColumn.ReadOnly = true;
            this.finalFateTimeTextBoxColumn.Width = 99;
            // 
            // finalFateTextBoxColumn
            // 
            this.finalFateTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finalFateTextBoxColumn.DataPropertyName = "FinalState";
            this.finalFateTextBoxColumn.HeaderText = "Final State";
            this.finalFateTextBoxColumn.Name = "finalFateTextBoxColumn";
            this.finalFateTextBoxColumn.ReadOnly = true;
            this.finalFateTextBoxColumn.Width = 76;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "CallbackAttempts";
            this.Column6.HeaderText = "CBs";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel1,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(232, 17);
            this.statusLabel.Text = "Drag and drop MainReportLog files to load";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1035, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;
            // 
            // callSummaryPanel
            // 
            this.callSummaryPanel.Controls.Add(this.mCallIdDataGridView);
            this.callSummaryPanel.Controls.Add(this.panel2);
            this.callSummaryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.callSummaryPanel.Location = new System.Drawing.Point(0, 0);
            this.callSummaryPanel.Name = "callSummaryPanel";
            this.callSummaryPanel.Size = new System.Drawing.Size(400, 528);
            this.callSummaryPanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.callSummaryFilterEnableCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 20);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Call Summary";
            // 
            // callSummaryFilterEnableCheckBox
            // 
            this.callSummaryFilterEnableCheckBox.AutoSize = true;
            this.callSummaryFilterEnableCheckBox.Enabled = false;
            this.callSummaryFilterEnableCheckBox.Location = new System.Drawing.Point(115, 2);
            this.callSummaryFilterEnableCheckBox.Name = "callSummaryFilterEnableCheckBox";
            this.callSummaryFilterEnableCheckBox.Size = new System.Drawing.Size(84, 17);
            this.callSummaryFilterEnableCheckBox.TabIndex = 2;
            this.callSummaryFilterEnableCheckBox.Text = "Enable Filter";
            this.callSummaryFilterEnableCheckBox.UseVisualStyleBackColor = true;
            this.callSummaryFilterEnableCheckBox.Click += new System.EventHandler(this.filterEnableCheckBox_Click);
            // 
            // logRecordPanel
            // 
            this.logRecordPanel.Controls.Add(this.mLogRecordDataGridView);
            this.logRecordPanel.Controls.Add(this.panel1);
            this.logRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRecordPanel.Location = new System.Drawing.Point(400, 0);
            this.logRecordPanel.Name = "logRecordPanel";
            this.logRecordPanel.Size = new System.Drawing.Size(882, 528);
            this.logRecordPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logRecordFilterEnableCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 20);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log Records";
            // 
            // logRecordFilterEnableCheckBox
            // 
            this.logRecordFilterEnableCheckBox.AutoSize = true;
            this.logRecordFilterEnableCheckBox.Enabled = false;
            this.logRecordFilterEnableCheckBox.Location = new System.Drawing.Point(119, 2);
            this.logRecordFilterEnableCheckBox.Name = "logRecordFilterEnableCheckBox";
            this.logRecordFilterEnableCheckBox.Size = new System.Drawing.Size(84, 17);
            this.logRecordFilterEnableCheckBox.TabIndex = 3;
            this.logRecordFilterEnableCheckBox.Text = "Enable Filter";
            this.logRecordFilterEnableCheckBox.UseVisualStyleBackColor = true;
            this.logRecordFilterEnableCheckBox.Click += new System.EventHandler(this.filterEnableCheckBox_Click);
            // 
            // CallStateViewerMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 550);
            this.Controls.Add(this.logRecordPanel);
            this.Controls.Add(this.callSummaryPanel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CallStateViewerMain";
            this.Text = "VH Call State Viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.mLogRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCallIdDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.callSummaryPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.logRecordPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mLogRecordDataGridView;
        private System.Windows.Forms.DataGridView mCallIdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn callIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalFateTimeTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalFateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel callSummaryPanel;
        private System.Windows.Forms.Panel logRecordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox logRecordFilterEnableCheckBox;
        private System.Windows.Forms.CheckBox callSummaryFilterEnableCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

