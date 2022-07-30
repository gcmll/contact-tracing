namespace chimmyContactTracing
{
    partial class Scan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan));
            this.cmbBoxDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pBoxCapture = new System.Windows.Forms.PictureBox();
            this.timerScan = new System.Windows.Forms.Timer(this.components);
            this.txtBoxQRDecode = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxDevice
            // 
            this.cmbBoxDevice.FormattingEnabled = true;
            this.cmbBoxDevice.Location = new System.Drawing.Point(81, 107);
            this.cmbBoxDevice.Name = "cmbBoxDevice";
            this.cmbBoxDevice.Size = new System.Drawing.Size(237, 23);
            this.cmbBoxDevice.TabIndex = 2;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.BackColor = System.Drawing.Color.Transparent;
            this.lblDevice.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDevice.ForeColor = System.Drawing.Color.White;
            this.lblDevice.Location = new System.Drawing.Point(23, 108);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(52, 17);
            this.lblDevice.TabIndex = 61;
            this.lblDevice.Text = "Device:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Font = new System.Drawing.Font("Mont Blanc SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Purple;
            this.btnStart.Location = new System.Drawing.Point(324, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 25);
            this.btnStart.TabIndex = 62;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBoxCapture
            // 
            this.pBoxCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxCapture.Location = new System.Drawing.Point(23, 141);
            this.pBoxCapture.Name = "pBoxCapture";
            this.pBoxCapture.Size = new System.Drawing.Size(394, 350);
            this.pBoxCapture.TabIndex = 63;
            this.pBoxCapture.TabStop = false;
            // 
            // timerScan
            // 
            this.timerScan.Interval = 1000;
            this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
            // 
            // txtBoxQRDecode
            // 
            this.txtBoxQRDecode.Location = new System.Drawing.Point(462, 141);
            this.txtBoxQRDecode.Multiline = true;
            this.txtBoxQRDecode.Name = "txtBoxQRDecode";
            this.txtBoxQRDecode.Size = new System.Drawing.Size(300, 350);
            this.txtBoxQRDecode.TabIndex = 64;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.Font = new System.Drawing.Font("Mont Blanc", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Purple;
            this.btnBack.Location = new System.Drawing.Point(311, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 25);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxQRDecode);
            this.Controls.Add(this.pBoxCapture);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cmbBoxDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimmy - Contact Tracing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scan_FormClosing);
            this.Load += new System.EventHandler(this.Scan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbBoxDevice;
        private Label lblDevice;
        private Button btnStart;
        private PictureBox pBoxCapture;
        private System.Windows.Forms.Timer timerScan;
        private TextBox txtBoxQRDecode;
        private Button btnBack;
    }
}