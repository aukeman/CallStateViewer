namespace CallStateViewer.View
{
    partial class SummaryFilterDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.callIdFilterComboBox = new System.Windows.Forms.ComboBox();
            this.timeInFilterComboBox = new System.Windows.Forms.ComboBox();
            this.finalStateTimeFilterComboBox = new System.Windows.Forms.ComboBox();
            this.finalStateFilterComboBox = new System.Windows.Forms.ComboBox();
            this.callbackAttemptsFilterComboBox = new System.Windows.Forms.ComboBox();
            this.recordNameFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recordValueFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Call ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final State Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Callback Attempts";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(149, 208);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(311, 208);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(230, 208);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // callIdFilterComboBox
            // 
            this.callIdFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.callIdFilterComboBox.FormattingEnabled = true;
            this.callIdFilterComboBox.Location = new System.Drawing.Point(111, 12);
            this.callIdFilterComboBox.Name = "callIdFilterComboBox";
            this.callIdFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.callIdFilterComboBox.TabIndex = 8;
            this.callIdFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // timeInFilterComboBox
            // 
            this.timeInFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInFilterComboBox.FormattingEnabled = true;
            this.timeInFilterComboBox.Location = new System.Drawing.Point(111, 39);
            this.timeInFilterComboBox.Name = "timeInFilterComboBox";
            this.timeInFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.timeInFilterComboBox.TabIndex = 9;
            this.timeInFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // finalStateTimeFilterComboBox
            // 
            this.finalStateTimeFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateTimeFilterComboBox.FormattingEnabled = true;
            this.finalStateTimeFilterComboBox.Location = new System.Drawing.Point(111, 66);
            this.finalStateTimeFilterComboBox.Name = "finalStateTimeFilterComboBox";
            this.finalStateTimeFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.finalStateTimeFilterComboBox.TabIndex = 10;
            this.finalStateTimeFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // finalStateFilterComboBox
            // 
            this.finalStateFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateFilterComboBox.FormattingEnabled = true;
            this.finalStateFilterComboBox.Location = new System.Drawing.Point(111, 93);
            this.finalStateFilterComboBox.Name = "finalStateFilterComboBox";
            this.finalStateFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.finalStateFilterComboBox.TabIndex = 11;
            this.finalStateFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // callbackAttemptsFilterComboBox
            // 
            this.callbackAttemptsFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.callbackAttemptsFilterComboBox.FormattingEnabled = true;
            this.callbackAttemptsFilterComboBox.Location = new System.Drawing.Point(111, 120);
            this.callbackAttemptsFilterComboBox.Name = "callbackAttemptsFilterComboBox";
            this.callbackAttemptsFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.callbackAttemptsFilterComboBox.TabIndex = 12;
            this.callbackAttemptsFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // recordNameFilterComboBox
            // 
            this.recordNameFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordNameFilterComboBox.FormattingEnabled = true;
            this.recordNameFilterComboBox.Location = new System.Drawing.Point(111, 147);
            this.recordNameFilterComboBox.Name = "recordNameFilterComboBox";
            this.recordNameFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.recordNameFilterComboBox.TabIndex = 14;
            this.recordNameFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Record Name";
            // 
            // recordValueFilterComboBox
            // 
            this.recordValueFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordValueFilterComboBox.FormattingEnabled = true;
            this.recordValueFilterComboBox.Location = new System.Drawing.Point(111, 174);
            this.recordValueFilterComboBox.Name = "recordValueFilterComboBox";
            this.recordValueFilterComboBox.Size = new System.Drawing.Size(275, 21);
            this.recordValueFilterComboBox.TabIndex = 16;
            this.recordValueFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Record Value";
            // 
            // SummaryFilter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 243);
            this.Controls.Add(this.recordValueFilterComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recordNameFilterComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.callbackAttemptsFilterComboBox);
            this.Controls.Add(this.finalStateFilterComboBox);
            this.Controls.Add(this.finalStateTimeFilterComboBox);
            this.Controls.Add(this.timeInFilterComboBox);
            this.Controls.Add(this.callIdFilterComboBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 281);
            this.Name = "SummaryFilter";
            this.ShowInTaskbar = false;
            this.Text = "Call Summary Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummaryFilter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ComboBox callIdFilterComboBox;
        private System.Windows.Forms.ComboBox timeInFilterComboBox;
        private System.Windows.Forms.ComboBox finalStateTimeFilterComboBox;
        private System.Windows.Forms.ComboBox finalStateFilterComboBox;
        private System.Windows.Forms.ComboBox callbackAttemptsFilterComboBox;
        private System.Windows.Forms.ComboBox recordNameFilterComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox recordValueFilterComboBox;
        private System.Windows.Forms.Label label7;
    }
}