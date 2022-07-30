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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan));
            this.cmbBoxDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pBoxCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxDevice
            // 
            this.cmbBoxDevice.FormattingEnabled = true;
            this.cmbBoxDevice.Location = new System.Drawing.Point(81, 107);
            this.cmbBoxDevice.Name = "cmbBoxDevice";
            this.cmbBoxDevice.Size = new System.Drawing.Size(237, 23);
            this.cmbBoxDevice.TabIndex = 0;
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
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.pBoxCapture);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cmbBoxDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimmy - Contact Tracing";
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
    }
}