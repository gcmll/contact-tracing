using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace chimmyContactTracing
{
    public partial class Scan : Form
    {
        public static string textPassedScan;

        public Scan()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInformationCollection;
        VideoCaptureDevice scannerDevice;

        private void Scan_Load(object sender, EventArgs e)
        {
            try
            {
                filterInformationCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterINfo in filterInformationCollection)
                    cmbBoxDevice.Items.Add(filterINfo.Name);
                cmbBoxDevice.SelectedIndex = 0;

                txtBoxQRDecode.Text = Start.textPassedStart;
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                scannerDevice = new VideoCaptureDevice(filterInformationCollection[cmbBoxDevice.SelectedIndex].MonikerString);
                scannerDevice.NewFrame += ScannerDevice_NewFrame;
                scannerDevice.Start();
                timerScan.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }      
        }

        private void ScannerDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pBoxCapture.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }

        private void Scan_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (scannerDevice.IsRunning == true)
                 scannerDevice.Stop();
        }

        private void timerScan_Tick(object sender, EventArgs e)
        {
            if (pBoxCapture.Image != null)
            {
                try
                {
                    if (pBoxCapture.Image != null)
                    {
                        BarcodeReader QRCodeReader = new BarcodeReader();
                        Result QRInformation = QRCodeReader.Decode((Bitmap)pBoxCapture.Image);

                        if (QRInformation != null)
                            txtBoxQRDecode.Text = QRInformation.ToString();
                        timerScan.Stop();

                        if (txtBoxQRDecode.Text == "")
                        {
                            MessageBox.Show("No QR code detected, please scan the QR code again.", "Chimmy - Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult QRCodeResult = MessageBox.Show("QR code was scanned successfully.", "Chimmy - Contact Tracing",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (QRCodeResult == DialogResult.OK)
                            {
                                textPassedScan = txtBoxQRDecode.Text;
                                Hide();
                                Start f2 = new Start();
                                f2.Show();
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }      
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Start f2 = new Start();
                f2.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
