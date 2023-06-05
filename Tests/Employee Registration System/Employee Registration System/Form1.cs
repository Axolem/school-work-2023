using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace Employee_Registration_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Axole Maranjana 220023913

        private readonly BusinessLayerClass businessLayer = new BusinessLayerClass();
        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            emailTxt.Text = businessLayer.generateEmail(nameTxt.Text, surnameTxt.Text);
            phoneTxt.Text = businessLayer.formatNumber(phoneTxt.Text);

            if (businessLayer.validatePassword(passwordTxt.Text))
            {
                MessageBox.Show("Password is valid");
                return;
            }

            MessageBox.Show("Password not valid");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            businessLayer.SaveDataToFile();

            MessageBox.Show("Written to file......");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            emailTxt.Text = ""; //It's a label (-_^)

            nameTxt.Clear();
            phoneTxt.Clear();
            surnameTxt.Clear();
            passwordTxt.Clear();
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            displayLstBx.Items.Clear();  //Clear the previous items is any
            Array.ForEach(businessLayer.ReadDataFromFile(), (row) => displayLstBx.Items.Add(row));
        }
    }
}
