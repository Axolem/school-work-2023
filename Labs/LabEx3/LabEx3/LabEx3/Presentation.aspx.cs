using BusinessLayer;
using System;
using System.Windows.Forms;

namespace LabEx3
{
    public partial class Presentation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string name, surname, email, idNumber;
        private int age;
        private readonly BusinessLogic business = new BusinessLogic();

        protected void ClearBTN_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        protected void ExitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        protected void SaveBTN_Click(object sender, EventArgs e)
        {
            name = nameTXT.Text;
            surname = surnameTXT.Text;
            idNumber = idTXT.Text;
            email = ageTXT.Text;
            age = int.Parse(ageTXT.Text);

            bool saved = business.SendToDatabase(name, surname, email, age, idNumber);
            if (saved)
            {

                _ = MessageBox.Show("Saved"); ClearFields();
            }
            else
            {
                _ = MessageBox.Show("Failed");
            }
        }

        protected void CreateBTN_Click(object sender, EventArgs e)
        {
            // Get values from the form
            name = nameTXT.Text;
            surname = surnameTXT.Text;
            idNumber = idTXT.Text;

            //Generate age & email using business layer
            age = business.GetAge(idNumber);
            email = business.CreateEmail(name, surname);

            //Display generated age z& email back on the form
            ageTXT.Text = age.ToString();
            emailTXT.Text = email.ToString();
        }

        private void ClearFields()
        {
            //Reset the labels
            ageTXT.Text = string.Empty;
            emailTXT.Text = string.Empty;

            // reset the fields
            idTXT.Text = string.Empty;
            nameTXT.Text = string.Empty;
            surnameTXT.Text = string.Empty;

            //Reset the vars
            name = string.Empty;
            surname = string.Empty;
            email = string.Empty;
            idNumber = string.Empty;
            age = 0;

        }

    }
}