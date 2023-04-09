using System;
using System.Windows.Forms;

namespace LabEx1_Question1
{
    public partial class CalculatorApp : Form
    {
        private decimal valueA = 0.0m, valueB = 0.0m, results = 0.0m;
        private string operators = "";
        public CalculatorApp()
        {
            InitializeComponent();
        }

        //This function handles all numbers clicks
        private void Action_All_Numbers_Clicks(object sender, EventArgs e)
        {
            // Check if there is a different number otherwise keep zero
            if (TXTBXdisplay.Text == "0")
            {
                //Display current number if there was a zero
                TXTBXdisplay.Text = Get_The_Clicked_BTN_Value(sender);
            }
            else
            {
                // Take the number displayed and concatinat the current clicked one 
                TXTBXdisplay.Text += Get_The_Clicked_BTN_Value(sender);
            }
        }

        private void Action_All_Operators_Clicks(object sender, EventArgs e)
        {
            operators = Get_The_Clicked_BTN_Value(sender);
            valueA = decimal.Parse(TXTBXdisplay.Text);
            TXTBXdisplay.Clear();
        }

        //Reset all values and input
        private void BTNclear_Click(object sender, EventArgs e)
        {
            TXTBXdisplay.Clear();
            valueA = 0.0m;
            valueB = 0.0m;
            results = 0.0m;
        }

        private void BTNequalsTo_Click(object sender, EventArgs e)
        {
            valueB = decimal.Parse(TXTBXdisplay.Text);

            switch (operators)
            {
                case "-":
                    valueB = decimal.Parse(TXTBXdisplay.Text);
                    results = valueA - valueB;
                    TXTBXdisplay.Text = results.ToString().Substring(0, 7);
                    break;
                case "+":
                    valueB = decimal.Parse(TXTBXdisplay.Text);
                    results = valueA + valueB;
                    TXTBXdisplay.Text = results.ToString().Substring(0, 7);
                    break;
                case "*":
                    valueB = decimal.Parse(TXTBXdisplay.Text);
                    results = valueA * valueB;
                    TXTBXdisplay.Text = results.ToString().Substring(0, 7);
                    break;
                case "/":
                    valueB = decimal.Parse(TXTBXdisplay.Text);
                    results = valueA / valueB;
                    TXTBXdisplay.Text = results.ToString().Substring(0, 7);
                    break;
                case "%":
                    valueB = decimal.Parse(TXTBXdisplay.Text);
                    results = valueA % valueB;
                    TXTBXdisplay.Text = results.ToString().Substring(0, 7);
                    break;
            }

        }

        //Returns the string value of the currently clicked button
        private string Get_The_Clicked_BTN_Value(object sender)
        {
            return sender.ToString().Substring(sender.ToString().Length - 1, 1);
        }
    }
}
