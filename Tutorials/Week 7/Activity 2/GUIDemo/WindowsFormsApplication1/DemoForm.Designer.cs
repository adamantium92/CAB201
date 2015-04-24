namespace WindowsFormsApplication1
{
    partial class DemoForm
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
            this.clickMeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clickCountLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkboxLabelCheck = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonGneerateTextForm = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            this.clickMeButton.Location = new System.Drawing.Point(89, 55);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(75, 23);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.Text = "Click Me";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The button has been clicked:";
            // 
            // clickCountLabel
            // 
            this.clickCountLabel.AutoSize = true;
            this.clickCountLabel.Location = new System.Drawing.Point(100, 117);
            this.clickCountLabel.Name = "clickCountLabel";
            this.clickCountLabel.Size = new System.Drawing.Size(40, 13);
            this.clickCountLabel.TabIndex = 2;
            this.clickCountLabel.Text = "0 times";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(114, 161);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 3;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkboxLabelCheck
            // 
            this.checkboxLabelCheck.AutoSize = true;
            this.checkboxLabelCheck.Location = new System.Drawing.Point(45, 194);
            this.checkboxLabelCheck.Name = "checkboxLabelCheck";
            this.checkboxLabelCheck.Size = new System.Drawing.Size(153, 13);
            this.checkboxLabelCheck.TabIndex = 4;
            this.checkboxLabelCheck.Text = "The Checkbox is not checked.";
            this.checkboxLabelCheck.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(103, 226);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonGneerateTextForm
            // 
            this.buttonGneerateTextForm.Location = new System.Drawing.Point(197, 227);
            this.buttonGneerateTextForm.Name = "buttonGneerateTextForm";
            this.buttonGneerateTextForm.Size = new System.Drawing.Size(75, 23);
            this.buttonGneerateTextForm.TabIndex = 6;
            this.buttonGneerateTextForm.Text = "Text Form";
            this.buttonGneerateTextForm.UseVisualStyleBackColor = true;
            this.buttonGneerateTextForm.Click += new System.EventHandler(this.buttonGneerateTextForm_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(13, 226);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGneerateTextForm);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.checkboxLabelCheck);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.clickCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clickMeButton);
            this.Name = "DemoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clickCountLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label checkboxLabelCheck;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonGneerateTextForm;
        private System.Windows.Forms.Button buttonReset;
    }
}

