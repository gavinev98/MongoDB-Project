namespace Money_Tracker
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tileUpdateItem = new MetroFramework.Controls.MetroTile();
            this.homeTile = new MetroFramework.Controls.MetroTile();
            this.lblDashboard = new MetroFramework.Controls.MetroLabel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.metroTile3);
            this.panelMain.Controls.Add(this.metroTile2);
            this.panelMain.Controls.Add(this.tileUpdateItem);
            this.panelMain.Controls.Add(this.homeTile);
            this.panelMain.Controls.Add(this.lblDashboard);
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(887, 513);
            this.panelMain.TabIndex = 0;
            this.panelMain.UseCustomBackColor = true;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.AllowDrop = true;
            this.metroTile3.BackColor = System.Drawing.Color.LightBlue;
            this.metroTile3.Location = new System.Drawing.Point(479, 282);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(143, 149);
            this.metroTile3.TabIndex = 20;
            this.metroTile3.Text = "Delete DVD";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.AllowDrop = true;
            this.metroTile2.BackColor = System.Drawing.Color.CadetBlue;
            this.metroTile2.Location = new System.Drawing.Point(263, 282);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(152, 149);
            this.metroTile2.TabIndex = 19;
            this.metroTile2.Text = "Search By Rating/Age";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tileUpdateItem
            // 
            this.tileUpdateItem.ActiveControl = null;
            this.tileUpdateItem.AllowDrop = true;
            this.tileUpdateItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tileUpdateItem.Location = new System.Drawing.Point(479, 88);
            this.tileUpdateItem.Name = "tileUpdateItem";
            this.tileUpdateItem.Size = new System.Drawing.Size(143, 149);
            this.tileUpdateItem.TabIndex = 18;
            this.tileUpdateItem.Text = "Update DVD";
            this.tileUpdateItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileUpdateItem.TileImage = ((System.Drawing.Image)(resources.GetObject("tileUpdateItem.TileImage")));
            this.tileUpdateItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUpdateItem.UseCustomBackColor = true;
            this.tileUpdateItem.UseCustomForeColor = true;
            this.tileUpdateItem.UseSelectable = true;
            this.tileUpdateItem.UseTileImage = true;
            this.tileUpdateItem.Click += new System.EventHandler(this.tileUpdateItem_Click_1);
            // 
            // homeTile
            // 
            this.homeTile.ActiveControl = null;
            this.homeTile.AllowDrop = true;
            this.homeTile.BackColor = System.Drawing.Color.Teal;
            this.homeTile.Location = new System.Drawing.Point(263, 88);
            this.homeTile.Name = "homeTile";
            this.homeTile.Size = new System.Drawing.Size(143, 149);
            this.homeTile.TabIndex = 17;
            this.homeTile.Text = "Add DVD";
            this.homeTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeTile.TileImage = ((System.Drawing.Image)(resources.GetObject("homeTile.TileImage")));
            this.homeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeTile.UseCustomBackColor = true;
            this.homeTile.UseCustomForeColor = true;
            this.homeTile.UseSelectable = true;
            this.homeTile.UseTileImage = true;
            this.homeTile.Click += new System.EventHandler(this.homeTile_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDashboard.Location = new System.Drawing.Point(363, 20);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(170, 31);
            this.lblDashboard.TabIndex = 16;
            this.lblDashboard.Text = "DVD Database";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDashboard.UseCustomBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(886, 540);
            this.Controls.Add(this.panelMain);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMain;
        private MetroFramework.Controls.MetroLabel lblDashboard;
        private MetroFramework.Controls.MetroTile homeTile;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile tileUpdateItem;
    }
}

