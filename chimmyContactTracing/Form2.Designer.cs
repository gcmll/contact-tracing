namespace chimmyContactTracing
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpDateTime1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Snow;
            this.btnSave.Font = new System.Drawing.Font("Mont Blanc", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Purple;
            this.btnSave.Location = new System.Drawing.Point(449, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(284, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "*If an information is not available, kindly leave the field blank.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(358, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 15);
            this.label16.TabIndex = 64;
            this.label16.Text = "Date and Time";
            // 
            // dtpDateTime1
            // 
            this.dtpDateTime1.Checked = false;
            this.dtpDateTime1.CustomFormat = "   MM/dd/yyyy hh:mm tt";
            this.dtpDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime1.Location = new System.Drawing.Point(360, 95);
            this.dtpDateTime1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDateTime1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpDateTime1.Name = "dtpDateTime1";
            this.dtpDateTime1.Size = new System.Drawing.Size(207, 23);
            this.dtpDateTime1.TabIndex = 63;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chimmyContactTracing.Properties.Resources.ChimmyCT_Start_Background;
            this.ClientSize = new System.Drawing.Size(601, 596);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtpDateTime1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimmy - Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Label label12;
        public Label label16;
        private DateTimePicker dtpDateTime1;
    }
}