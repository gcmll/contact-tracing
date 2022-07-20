using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chimmyContactTracing
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            dtpDate.Enabled = false;
        }

        private void btnViewAllRecord_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxContactData.Items.Clear();

                string viewAllRecord = @".\Chimmy-ContactTracing-Information.txt";
                
                List<string> showRecordsList = new List<string>();
                showRecordsList = File.ReadAllLines(viewAllRecord).ToList();

                foreach (string line in showRecordsList)
                {
                    listBoxContactData.Items.Add(line);
                    {
                        File.WriteAllLines(viewAllRecord, showRecordsList.ToArray());
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void searchDateFilter()
        {
            try
            {
                listBoxContactData.Items.Clear();

                string contactInformation = "";

                string dateData = dtpDate.Text;
                string fileLocation = (@"C:\Users\camil\Documents\chimmyCT\" + dateData + ".txt");

                StreamReader outputFile;
                outputFile = File.OpenText(fileLocation);

                while (contactInformation != null)
                {
                    contactInformation = outputFile.ReadLine();

                    if (contactInformation != null)
                    {
                        listBoxContactData.Items.Add(contactInformation);
                    }
                }
                outputFile.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void seachSelectedFIlter()
        {
            try
            {
                listBoxContactData.Items.Clear();

                string contactInformation = "";

                string selectedDataFilter = cmbBoxFilter.Text;   
                string fileLocation = (@"C:\Users\camil\Documents\chimmyCT\" + selectedDataFilter + ".txt");

                StreamReader outputFile;
                outputFile = File.OpenText(fileLocation);

                while (contactInformation != null)
                {
                    contactInformation = outputFile.ReadLine();

                    if (contactInformation != null)
                    {
                        listBoxContactData.Items.Add(contactInformation);
                    }
                }
                outputFile.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxContactData.Items.Clear();

                if (cmbBoxFilter.Text == "Date")
                {
                    string dateDataFilter = dtpDate.Text;
                    string fileLocation = (@"C:\Users\camil\Documents\chimmyCT\" + dateDataFilter + ".txt");

                    if (File.Exists(fileLocation) == true)
                    {
                        searchDateFilter();
                    }
                    else
                    {
                        listBoxContactData.Items.Add("No Record Found.");
                    }
                }
                else if (cmbBoxFilter.Text == "Vaccination Status - Only 1st dose")
                {
                    string vaxStatusFilter = cmbBoxFilter.Text;
                    string fileLocation = (@"C:\Users\camil\Documents\chimmyCT\" + vaxStatusFilter + ".txt");

                    if (File.Exists(fileLocation) == true)
                    {
                        seachSelectedFIlter();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxFilter.Text == "" || cmbBoxFilter.Text == "Vaccination Status - Only 1st dose" || cmbBoxFilter.Text == "Vaccination Status - Fully vaccinated" ||
                    cmbBoxFilter.Text == "Vaccination Status - Not vaccinated" || cmbBoxFilter.Text == "Have been sick in the last 7 days")
                {
                    btnSearch.Enabled = true;
                    dtpDate.Enabled = false;
                }
                else if (cmbBoxFilter.Text == "Date")
                {
                    btnSearch.Enabled = true;
                    dtpDate.Enabled = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Home f1 = new Home();
                f1.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
