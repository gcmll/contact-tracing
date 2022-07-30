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
            this.SuspendLayout();
            // 
            // cmbBoxDevice
            // 
            this.cmbBoxDevice.FormattingEnabled = true;
            this.cmbBoxDevice.Location = new System.Drawing.Point(89, 107);
            this.cmbBoxDevice.Name = "cmbBoxDevice";
            this.cmbBoxDevice.Size = new System.Drawing.Size(229, 23);
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
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cmbBoxDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimmy - Contact Tracing";
            this.Load += new System.EventHandler(this.Scan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbBoxDevice;
        private Label lblDevice;
    }
}