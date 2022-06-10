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
                StreamWriter profileInformation = new StreamWriter(@"C:\Users\camil\source\repos\chimmyContactTracing\chimmyContactTracing\Chimmy-ContactTracing-Information.txt", true);

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
    }
}
