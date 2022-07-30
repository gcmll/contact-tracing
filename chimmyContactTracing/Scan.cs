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
            filterInformationCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterINfo in filterInformationCollection)
                cmbBoxDevice.Items.Add(filterINfo.Name);
            cmbBoxDevice.SelectedIndex = 0; 
        }
    }
}
