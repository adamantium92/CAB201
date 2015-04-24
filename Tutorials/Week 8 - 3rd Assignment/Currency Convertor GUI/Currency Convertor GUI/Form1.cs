using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Convertor_GUI {
    
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            // Initialse combobox week 5 slide 31
            Form1_loadComboBox();
        }

        private void Form1_loadComboBox()
        {
            string country = "";

            // Store all values (currency codes) in Enum in a string array
            string[] currencyCodes = Enum.GetNames(typeof(Currencies));

            // Loop through each currency code and assign its corresponding country name
            foreach (string code in currencyCodes)
            {
                switch (code)
                {
                    case "AUD": country = "Australia";
                        break;
                    case "CYN": country = "China";
                        break;
                    case "DKK": country = "Denmark";
                        break;
                    case "EUR": country = "Europe";
                        break;
                    case "INR": country = "India";
                        break;
                    case "NZD": country = "New Zealand";
                        break;
                    case "AED": country = "United Arab Emirates";
                        break;
                    case "UKP": country = "United Kingdom";
                        break;
                    case "USD": country = "United States";
                        break;
                    case "VND": country = "Vietnam";
                        break;
                    default: country = "Unknown Currency Code";
                        break;
                }
               
                // Add the Country and currency code to both combobox items
                convertFromComboBox.Items.Add(country + " (" + code + ")");
                convertToComboBox.Items.Add(country + " (" + code + ")");
            }
        }

        
        private void convertFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertToComboBox.Enabled = true;
            convertFromComboBox.Enabled = false; 
        }

        private void convertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertToComboBox.Enabled = false;
            currentAmountTextBox.Enabled = true;
           // currentCodeLabel.Text = convertFromComboBox.SelectedText; 
           // currentCodeLabel.Visible = true; 
        }

       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void anotherConversionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
            {
                // Refresh the form
            }
            else if (noRadioButton.Checked)
            {
                // Close the application
            }
           
           
        }

        private void currentAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // int value = Convert.ToInt32(currentAmountTextBox.Text);
            int parsedValue;
            if (!int.TryParse(currentAmountTextBox.Text, out parsedValue))
            {
                //currentAmountTextBox.Text = "";
                MessageBox.Show("Please enter a positive numeric value.");
                calcConversionButton.Enabled = false;
                
            }
            else if (parsedValue < 0)
            {
                currentAmountTextBox.Text = "";
                MessageBox.Show("Please enter a positive numeric value.");
                calcConversionButton.Enabled = false;
               
            }
            else
            {
                calcConversionButton.Enabled = true; 
            }

           
            // Check for Type int or float
            // True check for positive (if x is > 0) - True enable calcConversionButton & Disable convertToComboBox/ False error message 
            // False error message
        }

        private void calcConversionButton_Click(object sender, EventArgs e)
        {
            // Call method to calculate conversion
            // Dispaly in desiredAmountTextBox
            // Diable currentAmountTextBox
            // Make visible radio buttons
        }
    }//end class 
}
