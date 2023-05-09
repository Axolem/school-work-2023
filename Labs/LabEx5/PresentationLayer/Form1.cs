using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private BusinessLayerClass businessLayer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            businessLayer = new BusinessLayerClass();
        }

        //This function handles all numbers clicks
        private void Action_All_Numbers_Clicks(object sender, EventArgs e)
        {
            if (TXTBXdisplay.Text.Contains("="))
            {
                Clear();
            }
            // Check if there is a different number otherwise keep zero
            if (TXTBXdisplay.Text == "0")
            {
                //Display current number if there was a zero
                TXTBXdisplay.Text = businessLayer.Get_The_Clicked_BTN_Value(sender);
            }
            else
            {
                // Take the number displayed and concatinat the current clicked one 
                TXTBXdisplay.Text += businessLayer.Get_The_Clicked_BTN_Value(sender);
            }
        }

        private void Action_All_Operators_Clicks(object sender, EventArgs e)
        {
            businessLayer.Operator = businessLayer.Get_The_Clicked_BTN_Value(sender);
            try
            {
                businessLayer.ValueA = decimal.Parse(TXTBXdisplay.Text);
            }
            catch (Exception)
            {
                string[] textInField = TXTBXdisplay.Text.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(textInField);
                businessLayer.ValueA = decimal.Parse(textInField[1]);
            }
            finally
            {

                TXTBXdisplay.Clear();
            }
        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {
            try
            {
                businessLayer.ValueB = decimal.Parse(TXTBXdisplay.Text);
            }
            catch (Exception)
            {
                string[] textInField = TXTBXdisplay.Text.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(textInField);
                businessLayer.ValueB = decimal.Parse(textInField[1]);
            }
            finally
            {
                TXTBXdisplay.Text = businessLayer.CalculateTotal();
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            TXTBXdisplay.Clear();
            businessLayer.ValueA = 0.0m;
            businessLayer.ValueB = 0.0m;
            businessLayer.Operator = "";
        }
    }
}
