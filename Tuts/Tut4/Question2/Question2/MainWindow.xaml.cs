using System;
using System.Data;
using System.Windows;

namespace Question2
{

    public partial class MainWindow : Window
    {
        //Global variables
        private string name, surname, gender, email;
        private int id;

        //Init new datalayer obj
        private readonly DataLayer dataLayer = new DataLayer();

        public MainWindow()
        {
            InitializeComponent();

            //Load data on form load
            LoadData();
        }

        private void BTNdelete_Click(object sender, RoutedEventArgs e)
        {
            //Check id if id present
            if (!AllFieldsFilled(true))
            {
                return;
            }

            //Delete the row
            try
            {
                dataLayer.DeleteRow(id);
                LoadData();
                _ = MessageBox.Show($"Record {id} deleted successfuly!", "Success!");
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Delete Error!");
            }
        }

        //Method to load data to the dataGrid
        private void LoadData()
        {
            try
            {
                DataTable table = dataLayer.ReadDataBase();
                GRDdisplay.ItemsSource = table.DefaultView;

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Loading Data Error!");
            }
        }


        //Method to clear all field data
        private void Clear()
        {
            name = surname = gender = email = "";
            id = 0;
            TXTemail.Clear();
            TXTgender.Clear();
            TXTid.Clear();
            TXTname.Clear();
            TXTsurname.Clear();
        }


        //method to check if user has entered all the data
        public bool AllFieldsFilled(bool checkId)
        {
            if (checkId)
            {
                if (TXTid.Text == string.Empty)
                {
                    _ = MessageBox.Show("ID address required!");
                    return false;
                }
                //Assing the values to the variables

                try
                {
                    id = int.Parse(TXTid.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Invalid Id Error!");
                    return false;
                }

            }
            else
            {
                if (TXTname.Text == string.Empty)
                {
                    _ = MessageBox.Show("Name required!");
                    return false;
                }
                else if (TXTsurname.Text == string.Empty)
                {
                    _ = MessageBox.Show("Surname required!");
                    return false;
                }
                else if (TXTgender.Text == string.Empty)
                {
                    _ = MessageBox.Show("Gender required!");
                    return false;
                }
                else if (TXTemail.Text == string.Empty)
                {
                    _ = MessageBox.Show("Email address required!");
                    return false;
                }
                else
                {
                    //Assing the values to the variables
                    name = TXTname.Text;
                    surname = TXTsurname.Text;
                    gender = TXTgender.Text;
                    email = TXTemail.Text;

                    return true;
                }


            }

        }

        private void BTNclear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void BTNinsert_Click(object sender, RoutedEventArgs e)
        {
            if (!AllFieldsFilled(false))
            {
                return;
            }

            try
            {
                dataLayer.SaveToDatabase(name, surname, gender, email);
                LoadData();
                _ = MessageBox.Show($"{name} saved successfully", "Success!");
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Save Error!");
            }
        }

        private void BTNupdate_Click(object sender, RoutedEventArgs e)
        {

            if (AllFieldsFilled(true) == false)
            {
                return;
            }

            if (AllFieldsFilled(false) == false)
            {
                return;
            }

            try
            {
                dataLayer.UpdateRow(id, name, surname, gender, email);
                LoadData();
                _ = MessageBox.Show($"{name} updated successfully", "Success!");
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Update Error!");
            }
        }
    }
}
