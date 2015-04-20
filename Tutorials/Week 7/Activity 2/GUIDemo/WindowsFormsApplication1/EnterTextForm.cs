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
    public partial class EnterTextForm : Form
    {
        public EnterTextForm()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "") & (numericUpDown.Value >= 1))
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }     


        }

        public string GetText()
        {
            return textBox1.Text;
        }
        
        public int GetNumber()
        {
            return Decimal.ToInt32(numericUpDown.Value); 
        }
    }
}
