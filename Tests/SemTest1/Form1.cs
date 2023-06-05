using System.Collections.Generic;
using System.Windows.Forms;

namespace SemTest1
{
	public partial class Form1 : Form
	{
		// Axole Maranjana
		// 220023913
		DataManager dataManager = new DataManager();
		List<Data> data = new List<Data>();
		Data displayedData;

		public Form1()
		{
			InitializeComponent();
			//Call the read function when the form loads
			data = dataManager.readFromFile();
		}

		private void loadBTN_Click(object sender, System.EventArgs e)
		{
			//Get the first record
			//displayedData = data[0];
			displayedData = dataManager.getRecord(1);

			//Display the first item
			numberTXT.Text = displayedData.Number.ToString();
			nameTXT.Text = displayedData.Name;
			surnameTXT.Text = displayedData.Surname;
			emailTXT.Text = displayedData.Email;
			ipAddressTXT.Text = displayedData.Ip;
		}

		private void nextBTN_Click(object sender, System.EventArgs e)
		{
			displayedData = dataManager.getRecord(displayedData.Number + 1);

			//Display the first item
			numberTXT.Text = displayedData.Number.ToString();
			nameTXT.Text = displayedData.Name;
			surnameTXT.Text = displayedData.Surname;
			emailTXT.Text = displayedData.Email;
			ipAddressTXT.Text = displayedData.Ip;
		}

		private void prevBTN_Click(object sender, System.EventArgs e)
		{
			displayedData = dataManager.getRecord(displayedData.Number - 1);

			//Display the first item
			numberTXT.Text = displayedData.Number.ToString();
			nameTXT.Text = displayedData.Name;
			surnameTXT.Text = displayedData.Surname;
			emailTXT.Text = displayedData.Email;
			ipAddressTXT.Text = displayedData.Ip;
		}

		private void _comRD_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_comRD.Checked)
			{
				List<Data> domainData = dataManager.determineDomain("com");
				displayLSTBX.Items.Clear();

				foreach (Data record in domainData)
				{
					displayLSTBX.Items.Add($"{record.Number} \t {record.Name} \t \t {record.Surname} \t \t {record.Email} \t \t {record.Gender} \t {record.Ip}");
				}
			}

		}

		private void _govRD_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_govRD.Checked)
			{
				List<Data> domainData = dataManager.determineDomain("gov");
				displayLSTBX.Items.Clear();
				foreach (Data record in domainData)
				{
					displayLSTBX.Items.Add($"{record.Number} \t {record.Name} \t \t {record.Surname} \t \t {record.Email} \t \t {record.Gender} \t {record.Ip}");
				}
			}
		}

		private void _eduRD_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_eduRD.Checked)
			{
				List<Data> domainData = dataManager.determineDomain("edu");
				displayLSTBX.Items.Clear();
				foreach (Data record in domainData)
				{
					displayLSTBX.Items.Add($"{record.Number} \t {record.Name} \t \t {record.Surname} \t \t {record.Email} \t \t {record.Gender} \t {record.Ip}");
				}
			}

		}

		private void _ruRD_CheckedChanged(object sender, System.EventArgs e)
		{

			if (_ruRD.Checked)
			{
				List<Data> domainData = dataManager.determineDomain("ru");
				displayLSTBX.Items.Clear();
				foreach (Data record in domainData)
				{
					displayLSTBX.Items.Add($"{record.Number} \t {record.Name} \t \t {record.Surname} \t \t {record.Email} \t \t {record.Gender} \t {record.Ip}");
				}
			}
		}

		private void _ukRD_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_ukRD.Checked)
			{
				List<Data> domainData = dataManager.determineDomain("uk");
				displayLSTBX.Items.Clear();
				foreach (Data record in domainData)
				{
					displayLSTBX.Items.Add($"{record.Number} \t {record.Name} \t \t {record.Surname} \t \t {record.Email} \t \t {record.Gender} \t {record.Ip}");
				}
			}
		}

		private void _jpRD_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_jpRD.Checked)
			{
				List<Data> domainData = dataManager.determineDomain("jp");
				displayLSTBX.Items.Clear();
				foreach (Data record in domainData)
				{
					displayLSTBX.Items.Add($"{record.Number} \t {record.Name} \t \t {record.Surname} \t \t {record.Email} \t \t {record.Gender} \t {record.Ip}");
				}
			}
		}
	}
}

