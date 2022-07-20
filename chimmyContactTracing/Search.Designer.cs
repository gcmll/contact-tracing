namespace chimmyContactTracing
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.listBoxContactData = new System.Windows.Forms.ListBox();
            this.btnViewAllRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContactData
            // 
            this.listBoxContactData.FormattingEnabled = true;
            this.listBoxContactData.ItemHeight = 15;
            this.listBoxContactData.Location = new System.Drawing.Point(24, 130);
            this.listBoxContactData.Name = "listBoxContactData";
            this.listBoxContactData.Size = new System.Drawing.Size(553, 319);
            this.listBoxContactData.TabIndex = 50;
            // 
            // btnViewAllRecord
            // 
            this.btnViewAllRecord.BackColor = System.Drawing.Color.Snow;
            this.btnViewAllRecord.Font = new System.Drawing.Font("Mont Blanc SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllRecord.ForeColor = System.Drawing.Color.Purple;
            this.btnViewAllRecord.Location = new System.Drawing.Point(445, 95);
            this.btnViewAllRecord.Name = "btnViewAllRecord";
            this.btnViewAllRecord.Size = new System.Drawing.Size(132, 25);
            this.btnViewAllRecord.TabIndex = 51;
            this.btnViewAllRecord.Text = "View All Record";
            this.btnViewAllRecord.UseVisualStyleBackColor = false;
            this.btnViewAllRecord.Click += new System.EventHandler(this.btnViewAllRecord_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 500);
            this.Controls.Add(this.btnViewAllRecord);
            this.Controls.Add(this.listBoxContactData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimmy - Contact Tracing";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxContactData;
        private Button btnViewAllRecord;
    }
}