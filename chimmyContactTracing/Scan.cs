﻿using System;
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

namespace chimmyContactTracing
{
    public partial class Scan : Form
    {
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
            try
            {
                if (scannerDevice.IsRunning == true)
                    scannerDevice.Stop();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}