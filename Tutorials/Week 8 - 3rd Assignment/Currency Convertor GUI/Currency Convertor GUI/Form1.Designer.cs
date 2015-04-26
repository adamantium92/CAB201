namespace Currency_Convertor_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.currencyHaveLabel = new System.Windows.Forms.Label();
            this.currencyWantLabel = new System.Windows.Forms.Label();
            this.amountHaveLabel = new System.Windows.Forms.Label();
            this.amountWantLabel = new System.Windows.Forms.Label();
            this.convertFromComboBox = new System.Windows.Forms.ComboBox();
            this.convertToComboBox = new System.Windows.Forms.ComboBox();
            this.currentAmountTextBox = new System.Windows.Forms.TextBox();
            this.desiredAmountTextBox = new System.Windows.Forms.TextBox();
            this.calcConversionButton = new System.Windows.Forms.Button();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentCodeLabel = new System.Windows.Forms.Label();
            this.desiredCodeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyHaveLabel
            // 
            this.currencyHaveLabel.AutoSize = true;
            this.currencyHaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyHaveLabel.Location = new System.Drawing.Point(60, 70);
            this.currencyHaveLabel.Name = "currencyHaveLabel";
            this.currencyHaveLabel.Size = new System.Drawing.Size(97, 13);
            this.currencyHaveLabel.TabIndex = 0;
            this.currencyHaveLabel.Text = "Currency I have";
            // 
            // currencyWantLabel
            // 
            this.currencyWantLabel.AutoSize = true;
            this.currencyWantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyWantLabel.Location = new System.Drawing.Point(323, 70);
            this.currencyWantLabel.Name = "currencyWantLabel";
            this.currencyWantLabel.Size = new System.Drawing.Size(96, 13);
            this.currencyWantLabel.TabIndex = 1;
            this.currencyWantLabel.Text = "Currency I want";
            // 
            // amountHaveLabel
            // 
            this.amountHaveLabel.AutoSize = true;
            this.amountHaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountHaveLabel.Location = new System.Drawing.Point(60, 147);
            this.amountHaveLabel.Name = "amountHaveLabel";
            this.amountHaveLabel.Size = new System.Drawing.Size(89, 13);
            this.amountHaveLabel.TabIndex = 2;
            this.amountHaveLabel.Text = "Amount I have";
            // 
            // amountWantLabel
            // 
            this.amountWantLabel.AutoSize = true;
            this.amountWantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountWantLabel.Location = new System.Drawing.Point(323, 147);
            this.amountWantLabel.Name = "amountWantLabel";
            this.amountWantLabel.Size = new System.Drawing.Size(88, 13);
            this.amountWantLabel.TabIndex = 3;
            this.amountWantLabel.Text = "Amount I want";
            // 
            // convertFromComboBox
            // 
            this.convertFromComboBox.FormattingEnabled = true;
            this.convertFromComboBox.Location = new System.Drawing.Point(60, 86);
            this.convertFromComboBox.Name = "convertFromComboBox";
            this.convertFromComboBox.Size = new System.Drawing.Size(173, 21);
            this.convertFromComboBox.TabIndex = 5;
            this.convertFromComboBox.SelectedIndexChanged += new System.EventHandler(this.convertFromComboBox_SelectedIndexChanged);
            // 
            // convertToComboBox
            // 
            this.convertToComboBox.Enabled = false;
            this.convertToComboBox.FormattingEnabled = true;
            this.convertToComboBox.Location = new System.Drawing.Point(326, 86);
            this.convertToComboBox.Name = "convertToComboBox";
            this.convertToComboBox.Size = new System.Drawing.Size(162, 21);
            this.convertToComboBox.TabIndex = 6;
            this.convertToComboBox.SelectedIndexChanged += new System.EventHandler(this.convertToComboBox_SelectedIndexChanged);
            // 
            // currentAmountTextBox
            // 
            this.currentAmountTextBox.Enabled = false;
            this.currentAmountTextBox.Location = new System.Drawing.Point(61, 163);
            this.currentAmountTextBox.Name = "currentAmountTextBox";
            this.currentAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentAmountTextBox.TabIndex = 7;
            this.currentAmountTextBox.TextChanged += new System.EventHandler(this.currentAmountTextBox_TextChanged);
            // 
            // desiredAmountTextBox
            // 
            this.desiredAmountTextBox.Enabled = false;
            this.desiredAmountTextBox.Location = new System.Drawing.Point(326, 162);
            this.desiredAmountTextBox.Name = "desiredAmountTextBox";
            this.desiredAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.desiredAmountTextBox.TabIndex = 8;
            // 
            // calcConversionButton
            // 
            this.calcConversionButton.Enabled = false;
            this.calcConversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcConversionButton.Location = new System.Drawing.Point(194, 155);
            this.calcConversionButton.Name = "calcConversionButton";
            this.calcConversionButton.Size = new System.Drawing.Size(75, 32);
            this.calcConversionButton.TabIndex = 9;
            this.calcConversionButton.Text = "equals";
            this.calcConversionButton.UseVisualStyleBackColor = true;
            this.calcConversionButton.Click += new System.EventHandler(this.calcConversionButton_Click);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRadioButton.Location = new System.Drawing.Point(33, 30);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(46, 17);
            this.yesRadioButton.TabIndex = 10;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.anotherConversionRadioButton_CheckedChanged);
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRadioButton.Location = new System.Drawing.Point(33, 53);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(41, 17);
            this.noRadioButton.TabIndex = 11;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.anotherConversionRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noRadioButton);
            this.groupBox1.Controls.Add(this.yesRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(161, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 89);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Another Conversion?";
            this.groupBox1.Visible = false;
            // 
            // currentCodeLabel
            // 
            this.currentCodeLabel.AutoSize = true;
            this.currentCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCodeLabel.Location = new System.Drawing.Point(23, 166);
            this.currentCodeLabel.Name = "currentCodeLabel";
            this.currentCodeLabel.Size = new System.Drawing.Size(36, 13);
            this.currentCodeLabel.TabIndex = 14;
            this.currentCodeLabel.Text = "Code";
            this.currentCodeLabel.Visible = false;
            // 
            // desiredCodeLabel
            // 
            this.desiredCodeLabel.AutoSize = true;
            this.desiredCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredCodeLabel.Location = new System.Drawing.Point(288, 165);
            this.desiredCodeLabel.Name = "desiredCodeLabel";
            this.desiredCodeLabel.Size = new System.Drawing.Size(36, 13);
            this.desiredCodeLabel.TabIndex = 15;
            this.desiredCodeLabel.Text = "Code";
            this.desiredCodeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 361);
            this.Controls.Add(this.desiredCodeLabel);
            this.Controls.Add(this.currentCodeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcConversionButton);
            this.Controls.Add(this.desiredAmountTextBox);
            this.Controls.Add(this.currentAmountTextBox);
            this.Controls.Add(this.convertToComboBox);
            this.Controls.Add(this.convertFromComboBox);
            this.Controls.Add(this.amountWantLabel);
            this.Controls.Add(this.amountHaveLabel);
            this.Controls.Add(this.currencyWantLabel);
            this.Controls.Add(this.currencyHaveLabel);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyHaveLabel;
        private System.Windows.Forms.Label currencyWantLabel;
        private System.Windows.Forms.Label amountHaveLabel;
        private System.Windows.Forms.Label amountWantLabel;
        private System.Windows.Forms.ComboBox convertFromComboBox;
        private System.Windows.Forms.ComboBox convertToComboBox;
        private System.Windows.Forms.TextBox currentAmountTextBox;
        private System.Windows.Forms.TextBox desiredAmountTextBox;
        private System.Windows.Forms.Button calcConversionButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentCodeLabel;
        private System.Windows.Forms.Label desiredCodeLabel;

     
    }
}

