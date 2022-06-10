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
