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
                DialogResult consentConfirmation = MessageBox.Show("By clicking 'OK' you agree to our privacy policy.", "Chimmy - Contact Tracing",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (consentConfirmation == DialogResult.OK)
                {
                    Hide();
                    Start f2 = new Start();
                    f2.Show();
                }
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
                Hide();
                Search f3 = new Search();
                f3.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}