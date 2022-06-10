namespace chimmyContactTracing
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("By clicking 'OK' you agree to our privacy policy.", "Chimmy - Contact Tracing",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}