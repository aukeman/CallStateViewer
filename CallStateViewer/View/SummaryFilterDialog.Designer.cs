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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryFilterDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.callIdFilterComboBox = new System.Windows.Forms.ComboBox();
            this.finalStateFilterComboBox = new System.Windows.Forms.ComboBox();
            this.recordNameFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recordValueFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeInAfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeInFilterAfterEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.timeInFilterBeforeEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.timeInBeforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finalStateTimeFilterBeforeEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.finalStateTimeBeforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finalStateTimeFilterAfterEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.finalStateTimeAfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeInEmptyCheckBox = new System.Windows.Forms.CheckBox();
            this.finalStateTimeEmptyCheckBox = new System.Windows.Forms.CheckBox();
            this.callbackAttemptsMinEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.callbackAttemptsMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.callbackAttemptsMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.callbackAttemptsMaxEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.regexCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.callbackAttemptsMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callbackAttemptsMaxNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time In";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final State Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Callback Attempts";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(156, 391);
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
            this.cancelButton.Location = new System.Drawing.Point(318, 391);
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
            this.applyButton.Location = new System.Drawing.Point(237, 391);
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
            this.callIdFilterComboBox.Size = new System.Drawing.Size(282, 21);
            this.callIdFilterComboBox.TabIndex = 8;
            this.callIdFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // finalStateFilterComboBox
            // 
            this.finalStateFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateFilterComboBox.FormattingEnabled = true;
            this.finalStateFilterComboBox.Location = new System.Drawing.Point(111, 39);
            this.finalStateFilterComboBox.Name = "finalStateFilterComboBox";
            this.finalStateFilterComboBox.Size = new System.Drawing.Size(282, 21);
            this.finalStateFilterComboBox.TabIndex = 11;
            this.finalStateFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // recordNameFilterComboBox
            // 
            this.recordNameFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordNameFilterComboBox.FormattingEnabled = true;
            this.recordNameFilterComboBox.Location = new System.Drawing.Point(111, 66);
            this.recordNameFilterComboBox.Name = "recordNameFilterComboBox";
            this.recordNameFilterComboBox.Size = new System.Drawing.Size(282, 21);
            this.recordNameFilterComboBox.TabIndex = 14;
            this.recordNameFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 69);
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
            this.recordValueFilterComboBox.Location = new System.Drawing.Point(111, 93);
            this.recordValueFilterComboBox.Name = "recordValueFilterComboBox";
            this.recordValueFilterComboBox.Size = new System.Drawing.Size(282, 21);
            this.recordValueFilterComboBox.TabIndex = 16;
            this.recordValueFilterComboBox.TextChanged += new System.EventHandler(this.filterComboBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Record Value";
            // 
            // timeInAfterDateTimePicker
            // 
            this.timeInAfterDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInAfterDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:sss";
            this.timeInAfterDateTimePicker.Enabled = false;
            this.timeInAfterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInAfterDateTimePicker.Location = new System.Drawing.Point(180, 10);
            this.timeInAfterDateTimePicker.Name = "timeInAfterDateTimePicker";
            this.timeInAfterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeInAfterDateTimePicker.TabIndex = 17;
            this.timeInAfterDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // timeInFilterAfterEnabledCheckBox
            // 
            this.timeInFilterAfterEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInFilterAfterEnabledCheckBox.AutoSize = true;
            this.timeInFilterAfterEnabledCheckBox.Location = new System.Drawing.Point(117, 15);
            this.timeInFilterAfterEnabledCheckBox.Name = "timeInFilterAfterEnabledCheckBox";
            this.timeInFilterAfterEnabledCheckBox.Size = new System.Drawing.Size(48, 17);
            this.timeInFilterAfterEnabledCheckBox.TabIndex = 18;
            this.timeInFilterAfterEnabledCheckBox.Text = "After";
            this.timeInFilterAfterEnabledCheckBox.UseVisualStyleBackColor = true;
            this.timeInFilterAfterEnabledCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // timeInFilterBeforeEnabledCheckBox
            // 
            this.timeInFilterBeforeEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInFilterBeforeEnabledCheckBox.AutoSize = true;
            this.timeInFilterBeforeEnabledCheckBox.Location = new System.Drawing.Point(117, 41);
            this.timeInFilterBeforeEnabledCheckBox.Name = "timeInFilterBeforeEnabledCheckBox";
            this.timeInFilterBeforeEnabledCheckBox.Size = new System.Drawing.Size(57, 17);
            this.timeInFilterBeforeEnabledCheckBox.TabIndex = 20;
            this.timeInFilterBeforeEnabledCheckBox.Text = "Before";
            this.timeInFilterBeforeEnabledCheckBox.UseVisualStyleBackColor = true;
            this.timeInFilterBeforeEnabledCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // timeInBeforeDateTimePicker
            // 
            this.timeInBeforeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInBeforeDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:sss";
            this.timeInBeforeDateTimePicker.Enabled = false;
            this.timeInBeforeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInBeforeDateTimePicker.Location = new System.Drawing.Point(180, 36);
            this.timeInBeforeDateTimePicker.Name = "timeInBeforeDateTimePicker";
            this.timeInBeforeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeInBeforeDateTimePicker.TabIndex = 19;
            this.timeInBeforeDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // finalStateTimeFilterBeforeEnabledCheckBox
            // 
            this.finalStateTimeFilterBeforeEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateTimeFilterBeforeEnabledCheckBox.AutoSize = true;
            this.finalStateTimeFilterBeforeEnabledCheckBox.Location = new System.Drawing.Point(118, 40);
            this.finalStateTimeFilterBeforeEnabledCheckBox.Name = "finalStateTimeFilterBeforeEnabledCheckBox";
            this.finalStateTimeFilterBeforeEnabledCheckBox.Size = new System.Drawing.Size(57, 17);
            this.finalStateTimeFilterBeforeEnabledCheckBox.TabIndex = 24;
            this.finalStateTimeFilterBeforeEnabledCheckBox.Text = "Before";
            this.finalStateTimeFilterBeforeEnabledCheckBox.UseVisualStyleBackColor = true;
            this.finalStateTimeFilterBeforeEnabledCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // finalStateTimeBeforeDateTimePicker
            // 
            this.finalStateTimeBeforeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateTimeBeforeDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:sss";
            this.finalStateTimeBeforeDateTimePicker.Enabled = false;
            this.finalStateTimeBeforeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finalStateTimeBeforeDateTimePicker.Location = new System.Drawing.Point(181, 35);
            this.finalStateTimeBeforeDateTimePicker.Name = "finalStateTimeBeforeDateTimePicker";
            this.finalStateTimeBeforeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.finalStateTimeBeforeDateTimePicker.TabIndex = 23;
            this.finalStateTimeBeforeDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // finalStateTimeFilterAfterEnabledCheckBox
            // 
            this.finalStateTimeFilterAfterEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateTimeFilterAfterEnabledCheckBox.AutoSize = true;
            this.finalStateTimeFilterAfterEnabledCheckBox.Location = new System.Drawing.Point(118, 14);
            this.finalStateTimeFilterAfterEnabledCheckBox.Name = "finalStateTimeFilterAfterEnabledCheckBox";
            this.finalStateTimeFilterAfterEnabledCheckBox.Size = new System.Drawing.Size(48, 17);
            this.finalStateTimeFilterAfterEnabledCheckBox.TabIndex = 22;
            this.finalStateTimeFilterAfterEnabledCheckBox.Text = "After";
            this.finalStateTimeFilterAfterEnabledCheckBox.UseVisualStyleBackColor = true;
            this.finalStateTimeFilterAfterEnabledCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // finalStateTimeAfterDateTimePicker
            // 
            this.finalStateTimeAfterDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateTimeAfterDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:sss";
            this.finalStateTimeAfterDateTimePicker.Enabled = false;
            this.finalStateTimeAfterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finalStateTimeAfterDateTimePicker.Location = new System.Drawing.Point(181, 9);
            this.finalStateTimeAfterDateTimePicker.Name = "finalStateTimeAfterDateTimePicker";
            this.finalStateTimeAfterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.finalStateTimeAfterDateTimePicker.TabIndex = 21;
            this.finalStateTimeAfterDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // timeInEmptyCheckBox
            // 
            this.timeInEmptyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeInEmptyCheckBox.AutoSize = true;
            this.timeInEmptyCheckBox.Location = new System.Drawing.Point(117, 64);
            this.timeInEmptyCheckBox.Name = "timeInEmptyCheckBox";
            this.timeInEmptyCheckBox.Size = new System.Drawing.Size(55, 17);
            this.timeInEmptyCheckBox.TabIndex = 25;
            this.timeInEmptyCheckBox.Text = "Empty";
            this.timeInEmptyCheckBox.UseVisualStyleBackColor = true;
            this.timeInEmptyCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // finalStateTimeEmptyCheckBox
            // 
            this.finalStateTimeEmptyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalStateTimeEmptyCheckBox.AutoSize = true;
            this.finalStateTimeEmptyCheckBox.Location = new System.Drawing.Point(118, 63);
            this.finalStateTimeEmptyCheckBox.Name = "finalStateTimeEmptyCheckBox";
            this.finalStateTimeEmptyCheckBox.Size = new System.Drawing.Size(55, 17);
            this.finalStateTimeEmptyCheckBox.TabIndex = 26;
            this.finalStateTimeEmptyCheckBox.Text = "Empty";
            this.finalStateTimeEmptyCheckBox.UseVisualStyleBackColor = true;
            this.finalStateTimeEmptyCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // callbackAttemptsMinEnabledCheckBox
            // 
            this.callbackAttemptsMinEnabledCheckBox.AutoSize = true;
            this.callbackAttemptsMinEnabledCheckBox.Location = new System.Drawing.Point(118, 15);
            this.callbackAttemptsMinEnabledCheckBox.Name = "callbackAttemptsMinEnabledCheckBox";
            this.callbackAttemptsMinEnabledCheckBox.Size = new System.Drawing.Size(43, 17);
            this.callbackAttemptsMinEnabledCheckBox.TabIndex = 27;
            this.callbackAttemptsMinEnabledCheckBox.Text = "Min";
            this.callbackAttemptsMinEnabledCheckBox.UseVisualStyleBackColor = true;
            this.callbackAttemptsMinEnabledCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // callbackAttemptsMinNumericUpDown
            // 
            this.callbackAttemptsMinNumericUpDown.Enabled = false;
            this.callbackAttemptsMinNumericUpDown.Location = new System.Drawing.Point(167, 14);
            this.callbackAttemptsMinNumericUpDown.Name = "callbackAttemptsMinNumericUpDown";
            this.callbackAttemptsMinNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.callbackAttemptsMinNumericUpDown.TabIndex = 28;
            this.callbackAttemptsMinNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.callbackAttemptsMinNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_ValueChanged);
            // 
            // callbackAttemptsMaxNumericUpDown
            // 
            this.callbackAttemptsMaxNumericUpDown.Enabled = false;
            this.callbackAttemptsMaxNumericUpDown.Location = new System.Drawing.Point(313, 14);
            this.callbackAttemptsMaxNumericUpDown.Name = "callbackAttemptsMaxNumericUpDown";
            this.callbackAttemptsMaxNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.callbackAttemptsMaxNumericUpDown.TabIndex = 30;
            this.callbackAttemptsMaxNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.callbackAttemptsMaxNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_ValueChanged);
            // 
            // callbackAttemptsMaxEnabledCheckBox
            // 
            this.callbackAttemptsMaxEnabledCheckBox.AutoSize = true;
            this.callbackAttemptsMaxEnabledCheckBox.Location = new System.Drawing.Point(264, 15);
            this.callbackAttemptsMaxEnabledCheckBox.Name = "callbackAttemptsMaxEnabledCheckBox";
            this.callbackAttemptsMaxEnabledCheckBox.Size = new System.Drawing.Size(46, 17);
            this.callbackAttemptsMaxEnabledCheckBox.TabIndex = 29;
            this.callbackAttemptsMaxEnabledCheckBox.Text = "Max";
            this.callbackAttemptsMaxEnabledCheckBox.UseVisualStyleBackColor = true;
            this.callbackAttemptsMaxEnabledCheckBox.Click += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timeInAfterDateTimePicker);
            this.groupBox1.Controls.Add(this.timeInFilterAfterEnabledCheckBox);
            this.groupBox1.Controls.Add(this.timeInBeforeDateTimePicker);
            this.groupBox1.Controls.Add(this.timeInFilterBeforeEnabledCheckBox);
            this.groupBox1.Controls.Add(this.timeInEmptyCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 86);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.finalStateTimeAfterDateTimePicker);
            this.groupBox2.Controls.Add(this.finalStateTimeFilterAfterEnabledCheckBox);
            this.groupBox2.Controls.Add(this.finalStateTimeBeforeDateTimePicker);
            this.groupBox2.Controls.Add(this.finalStateTimeFilterBeforeEnabledCheckBox);
            this.groupBox2.Controls.Add(this.finalStateTimeEmptyCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 87);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.callbackAttemptsMinEnabledCheckBox);
            this.groupBox3.Controls.Add(this.callbackAttemptsMinNumericUpDown);
            this.groupBox3.Controls.Add(this.callbackAttemptsMaxNumericUpDown);
            this.groupBox3.Controls.Add(this.callbackAttemptsMaxEnabledCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 45);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(111, 120);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(96, 17);
            this.caseSensitiveCheckBox.TabIndex = 27;
            this.caseSensitiveCheckBox.Text = "Case Sensitive";
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // regexCheckBox
            // 
            this.regexCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regexCheckBox.AutoSize = true;
            this.regexCheckBox.Location = new System.Drawing.Point(213, 120);
            this.regexCheckBox.Name = "regexCheckBox";
            this.regexCheckBox.Size = new System.Drawing.Size(57, 17);
            this.regexCheckBox.TabIndex = 34;
            this.regexCheckBox.Text = "Regex";
            this.regexCheckBox.UseVisualStyleBackColor = true;
            this.regexCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_Click);
            // 
            // SummaryFilterDialog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 426);
            this.Controls.Add(this.regexCheckBox);
            this.Controls.Add(this.caseSensitiveCheckBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recordValueFilterComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recordNameFilterComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finalStateFilterComboBox);
            this.Controls.Add(this.callIdFilterComboBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 281);
            this.Name = "SummaryFilterDialog";
            this.ShowInTaskbar = false;
            this.Text = "Call Summary Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummaryFilter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.callbackAttemptsMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callbackAttemptsMaxNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox finalStateFilterComboBox;
        private System.Windows.Forms.ComboBox recordNameFilterComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox recordValueFilterComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timeInAfterDateTimePicker;
        private System.Windows.Forms.CheckBox timeInFilterAfterEnabledCheckBox;
        private System.Windows.Forms.CheckBox timeInFilterBeforeEnabledCheckBox;
        private System.Windows.Forms.DateTimePicker timeInBeforeDateTimePicker;
        private System.Windows.Forms.CheckBox finalStateTimeFilterBeforeEnabledCheckBox;
        private System.Windows.Forms.DateTimePicker finalStateTimeBeforeDateTimePicker;
        private System.Windows.Forms.CheckBox finalStateTimeFilterAfterEnabledCheckBox;
        private System.Windows.Forms.DateTimePicker finalStateTimeAfterDateTimePicker;
        private System.Windows.Forms.CheckBox timeInEmptyCheckBox;
        private System.Windows.Forms.CheckBox finalStateTimeEmptyCheckBox;
        private System.Windows.Forms.CheckBox callbackAttemptsMinEnabledCheckBox;
        private System.Windows.Forms.NumericUpDown callbackAttemptsMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown callbackAttemptsMaxNumericUpDown;
        private System.Windows.Forms.CheckBox callbackAttemptsMaxEnabledCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
        private System.Windows.Forms.CheckBox regexCheckBox;
    }
}