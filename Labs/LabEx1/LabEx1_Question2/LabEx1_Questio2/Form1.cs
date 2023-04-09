using System;
using System.Windows.Forms;

namespace LabEx1_Questio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate payment and projected balance
        private readonly decimal interest = 1.25m;
        private decimal monthlyPayment, purchasePrice, balance, finalPayment;

        private void BTNcalculate_Click(object sender, EventArgs e)
        {
            try
            {

                //Clear previous data if user doesn't clicked clear before input a new value
                LSTBXdisplay.Items.Clear();
                //Do initial calculations
                purchasePrice = decimal.Parse(TXTBXprice.Text);
                balance = purchasePrice * interest; monthlyPayment = 0;
                //Write the headings before the loop
                _ = LSTBXdisplay.Items.Add("Payment               New Balance");
                _ = LSTBXdisplay.Items.Add("======               ==========");
                // Output payment and projected balance for each month
                while (balance > 15m)
                {
                    //Display one row 
                    _ = LSTBXdisplay.Items.Add($"{monthlyPayment:C}                  {balance:C}");
                    //Recalculate the payment for the next term
                    monthlyPayment = Math.Round(balance * 0.12m, 2);
                    balance -= monthlyPayment;
                }

                // Output final payment and balance when balance is less than or equal to 15
                finalPayment = Math.Round(balance, 2);
                _ = LSTBXdisplay.Items.Add($"Final payment: {finalPayment:C}, Final balance: R0.00");

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Use 'escape' to clear the form
            if (e.KeyCode == Keys.Escape)
            {
                Reset_Data();
            }
            //Calculate on 'Enter'
            else if (e.KeyCode == Keys.Enter)
            {
                BTNcalculate_Click(sender, e);
            }
        }

        // Closing the Form (App)
        private void BTNexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            Reset_Data();
        }
        private void Reset_Data()
        {
            //Clearing all fields
            LSTBXdisplay.Items.Clear();
            TXTBXprice.Clear();
            TXTBXname.Clear();
            //Reset variables
            finalPayment = 0;
            monthlyPayment = 0;
            purchasePrice = 0;
            balance = 0;
        }

    }
}
