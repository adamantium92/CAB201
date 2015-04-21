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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.calcConversionButton = new System.Windows.Forms.Button();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyHaveLabel
            // 
            this.currencyHaveLabel.AutoSize = true;
            this.currencyHaveLabel.Location = new System.Drawing.Point(12, 71);
            this.currencyHaveLabel.Name = "currencyHaveLabel";
            this.currencyHaveLabel.Size = new System.Drawing.Size(82, 13);
            this.currencyHaveLabel.TabIndex = 0;
            this.currencyHaveLabel.Text = "Currency I have";
            // 
            // currencyWantLabel
            // 
            this.currencyWantLabel.AutoSize = true;
            this.currencyWantLabel.Location = new System.Drawing.Point(236, 71);
            this.currencyWantLabel.Name = "currencyWantLabel";
            this.currencyWantLabel.Size = new System.Drawing.Size(81, 13);
            this.currencyWantLabel.TabIndex = 1;
            this.currencyWantLabel.Text = "Currency I want";
            // 
            // amountHaveLabel
            // 
            this.amountHaveLabel.AutoSize = true;
            this.amountHaveLabel.Location = new System.Drawing.Point(12, 148);
            this.amountHaveLabel.Name = "amountHaveLabel";
            this.amountHaveLabel.Size = new System.Drawing.Size(76, 13);
            this.amountHaveLabel.TabIndex = 2;
            this.amountHaveLabel.Text = "Amount I have";
            // 
            // amountWantLabel
            // 
            this.amountWantLabel.AutoSize = true;
            this.amountWantLabel.Location = new System.Drawing.Point(248, 148);
            this.amountWantLabel.Name = "amountWantLabel";
            this.amountWantLabel.Size = new System.Drawing.Size(75, 13);
            this.amountWantLabel.TabIndex = 3;
            this.amountWantLabel.Text = "Amount I want";
            // 
            // convertFromComboBox
            // 
            this.convertFromComboBox.FormattingEnabled = true;
            this.convertFromComboBox.Location = new System.Drawing.Point(12, 87);
            this.convertFromComboBox.Name = "convertFromComboBox";
            this.convertFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.convertFromComboBox.TabIndex = 5;
            this.convertFromComboBox.SelectedIndexChanged += new System.EventHandler(this.convertFromComboBox_SelectedIndexChanged);
            // 
            // convertToComboBox
            // 
            this.convertToComboBox.FormattingEnabled = true;
            this.convertToComboBox.Location = new System.Drawing.Point(239, 87);
            this.convertToComboBox.Name = "convertToComboBox";
            this.convertToComboBox.Size = new System.Drawing.Size(121, 21);
            this.convertToComboBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // calcConversionButton
            // 
            this.calcConversionButton.Location = new System.Drawing.Point(146, 161);
            this.calcConversionButton.Name = "calcConversionButton";
            this.calcConversionButton.Size = new System.Drawing.Size(75, 23);
            this.calcConversionButton.TabIndex = 9;
            this.calcConversionButton.Text = "equals";
            this.calcConversionButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(146, 260);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 10;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(146, 284);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 11;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Location = new System.Drawing.Point(146, 241);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(105, 13);
            this.repeatLabel.TabIndex = 12;
            this.repeatLabel.Text = "Another conversion?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 361);
            this.Controls.Add(this.repeatLabel);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.calcConversionButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertToComboBox);
            this.Controls.Add(this.convertFromComboBox);
            this.Controls.Add(this.amountWantLabel);
            this.Controls.Add(this.amountHaveLabel);
            this.Controls.Add(this.currencyWantLabel);
            this.Controls.Add(this.currencyHaveLabel);
            this.Name = "Form1";
            this.Text = "Currency I have";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button calcConversionButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.Label repeatLabel;

     
    }
}

