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
        public static string textPassedStart;

        public Start()
        {
            InitializeComponent();
        }

        void autoFill()
        {
            try
            {
                string perQRInformation = txtBoxQRDecode.Text;
                string[] scannedQRCodeInformation = new string[] { " " };
                string[] infoQR = perQRInformation.Split(scannedQRCodeInformation, StringSplitOptions.None);
                string lastName = infoQR[0];
                string firstName = infoQR[1];
                string middleName = infoQR[2];
                string suffix = infoQR[3];
                string sex = infoQR[4];
                string dateOfBirth = infoQR[5];
                string age = infoQR[6];
                string nationality = infoQR[7];
                string address = infoQR[8] + " " + infoQR[9] + " " + infoQR[10] + " " + infoQR[11] + " " + infoQR[12] + " " + infoQR[13];
                string phoneNumber = infoQR[14];
                string landlineNumber = infoQR[15];
                string emailAddress = infoQR[16];
                string vaccinationStatus = infoQR[17];
                string haveBeenSick = infoQR[18];
                string sickness = infoQR[19];

                txtBoxLastName.Text = lastName;
                txtBoxFirstName.Text = firstName;
                txtBoxMiddleName.Text = middleName;
                txtBoxSuffix.Text = suffix;
                if (sex == "Male")
                {
                    rdBtnMale.Checked = true;
                }
                else
                {
                    rdBtnFemale.Checked = true;
                }
                dtpBirthDate.Text = dateOfBirth;
                txtBoxAge.Text = age;
                txtBoxNationality.Text = nationality;
                txtBoxAddress.Text = address;
                txtBoxPhoneNumber.Text = phoneNumber;
                txtBoxLandline.Text = landlineNumber;
                txtBoxEmailAddress.Text = emailAddress;
                if (vaccinationStatus == "1stDoseOnly")
                {
                    rdBtnYes1stOnly.Checked = true;
                }
                else if (vaccinationStatus == "FullyVax")
                {
                    rdBtnYesFullyVaccinated.Checked = true;
                }
                else
                {
                    rdBtnNotVaccinated.Checked = true;
                }
                if (haveBeenSick == "Yes")
                {
                    rdBtnYes.Checked = true;
                }
                else
                {
                    rdBtnNo.Checked = true;
                }
                txtBoxSickness.Text = sickness;
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
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

        private void pBoxScan_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Scan f4 = new Scan();
                f4.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            txtBoxQRDecode.Text = Scan.textPassedScan;
        }

        private void pBoxAutoFill_Click(object sender, EventArgs e)
        {
            if (txtBoxQRDecode.Text == "")
            {
                MessageBox.Show("Please scan the QR code first.", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                autoFill();
            }
        }
    }
}
