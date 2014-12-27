namespace CallStateViewer
{
    partial class Form1
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
            this.mDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCallIdDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mDataGridView
            // 
            this.mDataGridView.AllowUserToAddRows = false;
            this.mDataGridView.AllowUserToDeleteRows = false;
            this.mDataGridView.AllowUserToOrderColumns = true;
            this.mDataGridView.AllowUserToResizeColumns = false;
            this.mDataGridView.AllowUserToResizeRows = false;
            this.mDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3});
            this.mDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.mDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridView.Location = new System.Drawing.Point(394, 0);
            this.mDataGridView.Name = "mDataGridView";
            this.mDataGridView.ReadOnly = true;
            this.mDataGridView.RowHeadersVisible = false;
            this.mDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGridView.Size = new System.Drawing.Size(888, 528);
            this.mDataGridView.TabIndex = 1;
            this.mDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mDataGridView_CellFormatting);
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
            this.mCallIdDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.mCallIdDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mCallIdDataGridView.Name = "mCallIdDataGridView";
            this.mCallIdDataGridView.ReadOnly = true;
            this.mCallIdDataGridView.RowHeadersVisible = false;
            this.mCallIdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mCallIdDataGridView.Size = new System.Drawing.Size(394, 528);
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 550);
            this.Controls.Add(this.mDataGridView);
            this.Controls.Add(this.mCallIdDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCallIdDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mDataGridView;
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
    }
}

