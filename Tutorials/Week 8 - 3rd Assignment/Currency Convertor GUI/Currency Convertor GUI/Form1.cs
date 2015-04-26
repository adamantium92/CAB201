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
            } // end foreach loop
        }
       
        private void convertFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertToComboBox.Enabled = true;
            convertFromComboBox.Enabled = false;
            // Extract the text inside the parentheses and store in the label
            currentCodeLabel.Text = convertFromComboBox.Text.Split('(',')')[1];
        }

        private void convertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertToComboBox.Enabled = false;
            currentAmountTextBox.Enabled = true;
            // Extract the text inside the parentheses and store in the label
            desiredCodeLabel.Text = convertToComboBox.Text.Split('(', ')')[1];
            currentCodeLabel.Visible = true;           
        }

        private void anotherConversionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
            {
                // Disable controlls
                convertFromComboBox.Enabled = true;
                convertToComboBox.Enabled = false;
                
                // Hide controlls
                groupBox1.Visible = false;
                currentCodeLabel.Visible = false;
                desiredCodeLabel.Visible = false;

                // Reset controlls
                yesRadioButton.Checked = false;
                convertFromComboBox.Text = "";
                convertToComboBox.Text = "";
                currentAmountTextBox.Text = "";
                desiredAmountTextBox.Text = "";
            }
            else if (noRadioButton.Checked)
            {
                // Close the application
                Close();
            }          
        }

        private void currentAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            calcConversionButton.Enabled = true;
        }

        private void calcConversionButton_Click(object sender, EventArgs e)
        {
            double textBoxDoubleVal;
            // Validate the user entered only numerical values
            if (!double.TryParse(currentAmountTextBox.Text, out textBoxDoubleVal))
            {
                // If non-numerical values are entered, clear the textBox
                currentAmountTextBox.Text = "";
                // Display corresponding error message
                MessageBox.Show("Please only enter numerical values.");
                calcConversionButton.Enabled = false;
            }
            // Check if enetered value is a negative
            else if (textBoxDoubleVal < 0)
            {
                // If a negative is detected clear the textBox
                currentAmountTextBox.Text = "";
                // Display corresponding error message
                MessageBox.Show("Please enter a positive numeric value.");
                calcConversionButton.Enabled = false;
            }
            else
            {
                // Pass all entered values to the currencyConversion. Round to 2 decimal places and convert to a string 
                desiredAmountTextBox.Text = Math.Round(Currency_Exchange.currencyConversion(Convert.ToDouble(currentAmountTextBox.Text), currentCodeLabel.Text, desiredCodeLabel.Text), 2).ToString();
                desiredCodeLabel.Visible = true;
                currentAmountTextBox.Enabled = false;
                groupBox1.Visible = true;   
            }      
        }
    }//end class 
}
