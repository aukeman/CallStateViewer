namespace CallStateViewer.View
{
    partial class DataRecordFilterDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRecordFilterDialog));
            this.regexCheckBox = new System.Windows.Forms.CheckBox();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.recordValueFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recordNameFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timestampAfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timestampFilterAfterEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.timestampBeforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timestampFilterBeforeEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regexCheckBox
            // 
            this.regexCheckBox.AutoSize = true;
            this.regexCheckBox.Location = new System.Drawing.Point(193, 60);
            this.regexCheckBox.Name = "regexCheckBox";
            this.regexCheckBox.Size = new System.Drawing.Size(57, 17);
            this.regexCheckBox.TabIndex = 40;
            this.regexCheckBox.Text = "Regex";
            this.regexCheckBox.UseVisualStyleBackColor = true;
            this.regexCheckBox.CheckedChanged += new System.EventHandler(this.checkbox_Changed);
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(91, 60);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(96, 17);
            this.caseSensitiveCheckBox.TabIndex = 39;
            this.caseSensitiveCheckBox.Text = "Case Sensitive";
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.checkbox_Changed);
            // 
            // recordValueFilterComboBox
            // 
            this.recordValueFilterComboBox.FormattingEnabled = true;
            this.recordValueFilterComboBox.Location = new System.Drawing.Point(91, 33);
            this.recordValueFilterComboBox.Name = "recordValueFilterComboBox";
            this.recordValueFilterComboBox.Size = new System.Drawing.Size(282, 21);
            this.recordValueFilterComboBox.TabIndex = 38;
            this.recordValueFilterComboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Record Value";
            // 
            // recordNameFilterComboBox
            // 
            this.recordNameFilterComboBox.FormattingEnabled = true;
            this.recordNameFilterComboBox.Location = new System.Drawing.Point(91, 6);
            this.recordNameFilterComboBox.Name = "recordNameFilterComboBox";
            this.recordNameFilterComboBox.Size = new System.Drawing.Size(282, 21);
            this.recordNameFilterComboBox.TabIndex = 36;
            this.recordNameFilterComboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Record Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timestampAfterDateTimePicker);
            this.groupBox1.Controls.Add(this.timestampFilterAfterEnabledCheckBox);
            this.groupBox1.Controls.Add(this.timestampBeforeDateTimePicker);
            this.groupBox1.Controls.Add(this.timestampFilterBeforeEnabledCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 66);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timestamp";
            // 
            // timestampAfterDateTimePicker
            // 
            this.timestampAfterDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timestampAfterDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:sss";
            this.timestampAfterDateTimePicker.Enabled = false;
            this.timestampAfterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timestampAfterDateTimePicker.Location = new System.Drawing.Point(151, 10);
            this.timestampAfterDateTimePicker.Name = "timestampAfterDateTimePicker";
            this.timestampAfterDateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.timestampAfterDateTimePicker.TabIndex = 17;
            this.timestampAfterDateTimePicker.ValueChanged += new System.EventHandler(this.timeValue_Changed);
            // 
            // timestampFilterAfterEnabledCheckBox
            // 
            this.timestampFilterAfterEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timestampFilterAfterEnabledCheckBox.AutoSize = true;
            this.timestampFilterAfterEnabledCheckBox.Location = new System.Drawing.Point(88, 15);
            this.timestampFilterAfterEnabledCheckBox.Name = "timestampFilterAfterEnabledCheckBox";
            this.timestampFilterAfterEnabledCheckBox.Size = new System.Drawing.Size(48, 17);
            this.timestampFilterAfterEnabledCheckBox.TabIndex = 18;
            this.timestampFilterAfterEnabledCheckBox.Text = "After";
            this.timestampFilterAfterEnabledCheckBox.UseVisualStyleBackColor = true;
            this.timestampFilterAfterEnabledCheckBox.CheckedChanged += new System.EventHandler(this.checkbox_Changed);
            // 
            // timestampBeforeDateTimePicker
            // 
            this.timestampBeforeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timestampBeforeDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:sss";
            this.timestampBeforeDateTimePicker.Enabled = false;
            this.timestampBeforeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timestampBeforeDateTimePicker.Location = new System.Drawing.Point(151, 36);
            this.timestampBeforeDateTimePicker.Name = "timestampBeforeDateTimePicker";
            this.timestampBeforeDateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.timestampBeforeDateTimePicker.TabIndex = 19;
            this.timestampBeforeDateTimePicker.ValueChanged += new System.EventHandler(this.timeValue_Changed);
            // 
            // timestampFilterBeforeEnabledCheckBox
            // 
            this.timestampFilterBeforeEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timestampFilterBeforeEnabledCheckBox.AutoSize = true;
            this.timestampFilterBeforeEnabledCheckBox.Location = new System.Drawing.Point(88, 41);
            this.timestampFilterBeforeEnabledCheckBox.Name = "timestampFilterBeforeEnabledCheckBox";
            this.timestampFilterBeforeEnabledCheckBox.Size = new System.Drawing.Size(57, 17);
            this.timestampFilterBeforeEnabledCheckBox.TabIndex = 20;
            this.timestampFilterBeforeEnabledCheckBox.Text = "Before";
            this.timestampFilterBeforeEnabledCheckBox.UseVisualStyleBackColor = true;
            this.timestampFilterBeforeEnabledCheckBox.CheckedChanged += new System.EventHandler(this.checkbox_Changed);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(219, 165);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 44;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.okButton_Clicked);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(300, 165);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Clicked);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(138, 165);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 42;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Clicked);
            // 
            // DataRecordFilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 200);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.regexCheckBox);
            this.Controls.Add(this.caseSensitiveCheckBox);
            this.Controls.Add(this.recordValueFilterComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recordNameFilterComboBox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataRecordFilterDialog";
            this.ShowInTaskbar = false;
            this.Text = "Call Data Record Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataRecordFilterDialog_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox regexCheckBox;
        private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
        private System.Windows.Forms.ComboBox recordValueFilterComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox recordNameFilterComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timestampAfterDateTimePicker;
        private System.Windows.Forms.CheckBox timestampFilterAfterEnabledCheckBox;
        private System.Windows.Forms.DateTimePicker timestampBeforeDateTimePicker;
        private System.Windows.Forms.CheckBox timestampFilterBeforeEnabledCheckBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}