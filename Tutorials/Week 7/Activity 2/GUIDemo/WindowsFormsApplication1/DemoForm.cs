using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DemoForm : Form
    {
        int counter = 0;
        public DemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update counter
            counter += 1;
            //Then update the text on the label
            clickCountLabel.Text = counter + " times";

            buttonReset.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // update lacbel
            if (checkBox.Checked == true) {
                checkboxLabelCheck.Text = "The Checkbox is checked";
            } else {
                checkboxLabelCheck.Text = "The Checkbox is not checked";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGneerateTextForm_Click(object sender, EventArgs e)
        {
            EnterTextForm textForm = new EnterTextForm();

            if (textForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The text you entered on the form was:  \n"
                      + textForm.GetText() + "\nThe number you entered was:  "
                      + textForm.GetNumber());
            }
            else
            {
                MessageBox.Show("You did not enter any text on the form");
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            counter = 0;
            clickCountLabel.Text = counter + " times";
        }
    }
}
