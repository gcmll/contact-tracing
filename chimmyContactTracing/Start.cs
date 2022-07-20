using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace chimmyContactTracing
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter profileInformation = new StreamWriter(@"C:\Users\camil\source\repos\chimmyContactTracing\chimmyContactTracing\bin\Debug\net6.0-windows\Chimmy-ContactTracing-Information.txt", true);

                profileInformation.WriteLine("Date and Time: " + dtpDateTime.Text);
                profileInformation.WriteLine("Full Name: " + txtBoxLastName.Text + " " + txtBoxSuffix.Text + ", " + txtBoxFirstName.Text + ", " + txtBoxMiddleName.Text);

                if (rdBtnMale.Checked)
                {
                    profileInformation.WriteLine("Sex: Male");
                }
                else if (rdBtnFemale.Checked)
                {
                    profileInformation.WriteLine("Sex: Female");

                }

                profileInformation.WriteLine("Date of Birth: " + dtpBirthDate.Text);
                profileInformation.WriteLine("Age: " + txtBoxAge.Text);
                profileInformation.WriteLine("Nationality: " + txtBoxNationality.Text);
                profileInformation.WriteLine("Address: " + txtBoxAddress.Text);
                profileInformation.WriteLine("Phone Number: " + txtBoxPhoneNumber.Text);
                profileInformation.WriteLine("Landline: " + txtBoxLandline.Text);
                profileInformation.WriteLine("Email Address: " + txtBoxEmailAddress.Text);

                if (rdBtnYes1stOnly.Checked)
                {
                    profileInformation.WriteLine("Are you vaccinated?: Yes, 1st dose only");
                }
                else if (rdBtnYesFullyVaccinated.Checked)
                {
                    profileInformation.WriteLine("Are you vaccinated?: Yes, fully vaccinated");
                }
                else if (rdBtnNotVaccinated.Checked)
                {
                    profileInformation.WriteLine("Are you vaccinated?: No");
                }


                if (rdBtnYes.Checked)
                {
                    profileInformation.WriteLine("Have you been sick in the last 7 days?: Yes");
                }
                else if (rdBtnNo.Checked)
                {
                    profileInformation.WriteLine("Have you been sick in the last 7 days?: No");
                }

                profileInformation.WriteLine("Sickness: " + txtBoxSickness.Text);
                profileInformation.WriteLine("");
                profileInformation.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                DialogResult saveInformation = MessageBox.Show("Your registration has been received. Thank you!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (saveInformation == DialogResult.OK)
                {
                    Hide();
                    Home f1 = new Home();
                    f1.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult exitConfirmation = MessageBox.Show("Are you sure you want to continue?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                try
                {
                    if (exitConfirmation == DialogResult.Yes)
                    {
                        e.Cancel = false;
                    }
                    else if (exitConfirmation == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
