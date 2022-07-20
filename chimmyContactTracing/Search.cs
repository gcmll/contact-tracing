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

        private void btnViewAllRecord_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxContactData.Items.Clear();

                string viewAllRecord = @"C:\Users\camil\source\repos\chimmyContactTracing\chimmyContactTracing\Chimmy-ContactTracing-Information.txt";
                
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
    }
}
