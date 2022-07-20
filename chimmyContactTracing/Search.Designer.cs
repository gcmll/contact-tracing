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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.Font = new System.Drawing.Font("Mont Blanc", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Purple;
            this.btnBack.Location = new System.Drawing.Point(475, 458);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 25);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(21, 100);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(61, 17);
            this.lblFilter.TabIndex = 58;
            this.lblFilter.Text = "Filter by:";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "MM-dd-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(88, 96);
            this.dtpDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(249, 23);
            this.dtpDate.TabIndex = 59;
            this.dtpDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Snow;
            this.btnSearch.Font = new System.Drawing.Font("Mont Blanc SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Purple;
            this.btnSearch.Location = new System.Drawing.Point(343, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 25);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 500);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAllRecord);
            this.Controls.Add(this.listBoxContactData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimmy - Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxContactData;
        private Button btnViewAllRecord;
        private Button btnBack;
        private Label lblFilter;
        private DateTimePicker dtpDate;
        private Button btnSearch;
    }
}