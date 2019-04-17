namespace Money_Tracker
{
    partial class DVDsNotAvaliable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVDsNotAvaliable));
            this.panelLoadNotAvaliable = new MetroFramework.Controls.MetroPanel();
            this.lblNotAvaliable = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.btnAgeRating = new System.Windows.Forms.Button();
            this.panelLoadNotAvaliable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoadNotAvaliable
            // 
            this.panelLoadNotAvaliable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLoadNotAvaliable.BackgroundImage")));
            this.panelLoadNotAvaliable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLoadNotAvaliable.Controls.Add(this.btnAgeRating);
            this.panelLoadNotAvaliable.Controls.Add(this.lblAge);
            this.panelLoadNotAvaliable.Controls.Add(this.txtAge);
            this.panelLoadNotAvaliable.Controls.Add(this.lblNotAvaliable);
            this.panelLoadNotAvaliable.HorizontalScrollbarBarColor = true;
            this.panelLoadNotAvaliable.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLoadNotAvaliable.HorizontalScrollbarSize = 10;
            this.panelLoadNotAvaliable.Location = new System.Drawing.Point(0, 41);
            this.panelLoadNotAvaliable.Name = "panelLoadNotAvaliable";
            this.panelLoadNotAvaliable.Size = new System.Drawing.Size(967, 433);
            this.panelLoadNotAvaliable.TabIndex = 0;
            this.panelLoadNotAvaliable.VerticalScrollbarBarColor = true;
            this.panelLoadNotAvaliable.VerticalScrollbarHighlightOnWheel = false;
            this.panelLoadNotAvaliable.VerticalScrollbarSize = 10;
            this.panelLoadNotAvaliable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoadNotAvaliable_Paint);
            // 
            // lblNotAvaliable
            // 
            this.lblNotAvaliable.AutoSize = true;
            this.lblNotAvaliable.BackColor = System.Drawing.Color.Transparent;
            this.lblNotAvaliable.Location = new System.Drawing.Point(394, 18);
            this.lblNotAvaliable.Name = "lblNotAvaliable";
            this.lblNotAvaliable.Size = new System.Drawing.Size(132, 19);
            this.lblNotAvaliable.TabIndex = 21;
            this.lblNotAvaliable.Text = "DVD search by rating";
            this.lblNotAvaliable.UseCustomBackColor = true;
            this.lblNotAvaliable.Click += new System.EventHandler(this.lblNotAvaliable_Click);
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.CustomButton.Image = null;
            this.txtAge.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtAge.CustomButton.Name = "";
            this.txtAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAge.CustomButton.TabIndex = 1;
            this.txtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAge.CustomButton.UseSelectable = true;
            this.txtAge.CustomButton.Visible = false;
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(409, 155);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(117, 23);
            this.txtAge.TabIndex = 33;
            this.txtAge.UseSelectable = true;
            this.txtAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Location = new System.Drawing.Point(297, 156);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(107, 19);
            this.lblAge.TabIndex = 34;
            this.lblAge.Text = "Search by Rating";
            this.lblAge.UseCustomBackColor = true;
            // 
            // btnAgeRating
            // 
            this.btnAgeRating.Location = new System.Drawing.Point(554, 156);
            this.btnAgeRating.Name = "btnAgeRating";
            this.btnAgeRating.Size = new System.Drawing.Size(103, 23);
            this.btnAgeRating.TabIndex = 35;
            this.btnAgeRating.Text = "Search by rating";
            this.btnAgeRating.UseVisualStyleBackColor = true;
            this.btnAgeRating.Click += new System.EventHandler(this.btnAgeRating_Click);
            // 
            // DVDsNotAvaliable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 474);
            this.Controls.Add(this.panelLoadNotAvaliable);
            this.Name = "DVDsNotAvaliable";
            this.Load += new System.EventHandler(this.RecentActivity_Load);
            this.panelLoadNotAvaliable.ResumeLayout(false);
            this.panelLoadNotAvaliable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelLoadNotAvaliable;
        private MetroFramework.Controls.MetroLabel lblNotAvaliable;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroLabel lblAge;
        private System.Windows.Forms.Button btnAgeRating;
    }
}