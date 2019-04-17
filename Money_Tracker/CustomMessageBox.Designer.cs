namespace Money_Tracker
{
    partial class CustomMessageBox
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblListOfMovies = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.movieLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 37);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(703, 320);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.UseWaitCursor = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblListOfMovies
            // 
            this.lblListOfMovies.AutoSize = true;
            this.lblListOfMovies.Location = new System.Drawing.Point(296, 15);
            this.lblListOfMovies.Name = "lblListOfMovies";
            this.lblListOfMovies.Size = new System.Drawing.Size(91, 19);
            this.lblListOfMovies.TabIndex = 2;
            this.lblListOfMovies.Text = "List Of Movies";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel2.Controls.Add(this.movieLabel);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(165, 26);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(389, 187);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.UseWaitCursor = true;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(16, 18);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(0, 0);
            this.movieLabel.TabIndex = 2;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 356);
            this.Controls.Add(this.lblListOfMovies);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lblListOfMovies;
        private MetroFramework.Controls.MetroLabel movieLabel;
    }
}