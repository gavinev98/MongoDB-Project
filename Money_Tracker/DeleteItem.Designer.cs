namespace Money_Tracker
{
    partial class DeleteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItem));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.lblObjectID = new MetroFramework.Controls.MetroLabel();
            this.txtObjectID = new MetroFramework.Controls.MetroTextBox();
            this.txtActor3 = new MetroFramework.Controls.MetroTextBox();
            this.txtActor2 = new MetroFramework.Controls.MetroTextBox();
            this.btnAddItem = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblAddItem = new MetroFramework.Controls.MetroLabel();
            this.txtActor1 = new MetroFramework.Controls.MetroTextBox();
            this.txtCost = new MetroFramework.Controls.MetroTextBox();
            this.txtAvalibility = new MetroFramework.Controls.MetroTextBox();
            this.txtRating = new MetroFramework.Controls.MetroTextBox();
            this.txtDVDName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.dataView);
            this.metroPanel1.Controls.Add(this.lblObjectID);
            this.metroPanel1.Controls.Add(this.txtObjectID);
            this.metroPanel1.Controls.Add(this.txtActor3);
            this.metroPanel1.Controls.Add(this.txtActor2);
            this.metroPanel1.Controls.Add(this.btnAddItem);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lblAddItem);
            this.metroPanel1.Controls.Add(this.txtActor1);
            this.metroPanel1.Controls.Add(this.txtCost);
            this.metroPanel1.Controls.Add(this.txtAvalibility);
            this.metroPanel1.Controls.Add(this.txtRating);
            this.metroPanel1.Controls.Add(this.txtDVDName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 19);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1013, 431);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(764, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Select DVD";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(622, 88);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(380, 233);
            this.dataView.TabIndex = 49;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RetrieveInfo);
            // 
            // lblObjectID
            // 
            this.lblObjectID.AutoSize = true;
            this.lblObjectID.BackColor = System.Drawing.Color.Transparent;
            this.lblObjectID.ForeColor = System.Drawing.Color.Transparent;
            this.lblObjectID.Location = new System.Drawing.Point(-106, 76);
            this.lblObjectID.Name = "lblObjectID";
            this.lblObjectID.Size = new System.Drawing.Size(60, 19);
            this.lblObjectID.TabIndex = 48;
            this.lblObjectID.Text = "ObjectID";
            this.lblObjectID.UseCustomBackColor = true;
            // 
            // txtObjectID
            // 
            // 
            // 
            // 
            this.txtObjectID.CustomButton.Image = null;
            this.txtObjectID.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtObjectID.CustomButton.Name = "";
            this.txtObjectID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtObjectID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObjectID.CustomButton.TabIndex = 1;
            this.txtObjectID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObjectID.CustomButton.UseSelectable = true;
            this.txtObjectID.CustomButton.Visible = false;
            this.txtObjectID.Lines = new string[0];
            this.txtObjectID.Location = new System.Drawing.Point(146, 65);
            this.txtObjectID.MaxLength = 32767;
            this.txtObjectID.Name = "txtObjectID";
            this.txtObjectID.PasswordChar = '\0';
            this.txtObjectID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObjectID.SelectedText = "";
            this.txtObjectID.SelectionLength = 0;
            this.txtObjectID.SelectionStart = 0;
            this.txtObjectID.ShortcutsEnabled = true;
            this.txtObjectID.Size = new System.Drawing.Size(142, 23);
            this.txtObjectID.TabIndex = 47;
            this.txtObjectID.UseSelectable = true;
            this.txtObjectID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObjectID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtActor3
            // 
            // 
            // 
            // 
            this.txtActor3.CustomButton.Image = null;
            this.txtActor3.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtActor3.CustomButton.Name = "";
            this.txtActor3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtActor3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtActor3.CustomButton.TabIndex = 1;
            this.txtActor3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtActor3.CustomButton.UseSelectable = true;
            this.txtActor3.CustomButton.Visible = false;
            this.txtActor3.Lines = new string[0];
            this.txtActor3.Location = new System.Drawing.Point(462, 298);
            this.txtActor3.MaxLength = 32767;
            this.txtActor3.Name = "txtActor3";
            this.txtActor3.PasswordChar = '\0';
            this.txtActor3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtActor3.SelectedText = "";
            this.txtActor3.SelectionLength = 0;
            this.txtActor3.SelectionStart = 0;
            this.txtActor3.ShortcutsEnabled = true;
            this.txtActor3.Size = new System.Drawing.Size(142, 23);
            this.txtActor3.TabIndex = 45;
            this.txtActor3.UseSelectable = true;
            this.txtActor3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtActor3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtActor2
            // 
            // 
            // 
            // 
            this.txtActor2.CustomButton.Image = null;
            this.txtActor2.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtActor2.CustomButton.Name = "";
            this.txtActor2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtActor2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtActor2.CustomButton.TabIndex = 1;
            this.txtActor2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtActor2.CustomButton.UseSelectable = true;
            this.txtActor2.CustomButton.Visible = false;
            this.txtActor2.Lines = new string[0];
            this.txtActor2.Location = new System.Drawing.Point(308, 298);
            this.txtActor2.MaxLength = 32767;
            this.txtActor2.Name = "txtActor2";
            this.txtActor2.PasswordChar = '\0';
            this.txtActor2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtActor2.SelectedText = "";
            this.txtActor2.SelectionLength = 0;
            this.txtActor2.SelectionStart = 0;
            this.txtActor2.ShortcutsEnabled = true;
            this.txtActor2.Size = new System.Drawing.Size(142, 23);
            this.txtActor2.TabIndex = 46;
            this.txtActor2.UseSelectable = true;
            this.txtActor2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtActor2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Peru;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(146, 362);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(142, 23);
            this.btnAddItem.TabIndex = 44;
            this.btnAddItem.Text = "Delete Item";
            this.btnAddItem.UseCustomBackColor = true;
            this.btnAddItem.UseCustomForeColor = true;
            this.btnAddItem.UseSelectable = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(-106, 213);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "Avaliable";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(-106, 313);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Actors";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(-106, 266);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Cost";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(-106, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Rating";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(-106, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "DVD Name";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItem.Location = new System.Drawing.Point(178, 23);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(76, 19);
            this.lblAddItem.TabIndex = 38;
            this.lblAddItem.Text = "Delete Item";
            this.lblAddItem.UseCustomBackColor = true;
            this.lblAddItem.Click += new System.EventHandler(this.lblAddItem_Click);
            // 
            // txtActor1
            // 
            // 
            // 
            // 
            this.txtActor1.CustomButton.Image = null;
            this.txtActor1.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtActor1.CustomButton.Name = "";
            this.txtActor1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtActor1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtActor1.CustomButton.TabIndex = 1;
            this.txtActor1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtActor1.CustomButton.UseSelectable = true;
            this.txtActor1.CustomButton.Visible = false;
            this.txtActor1.Lines = new string[0];
            this.txtActor1.Location = new System.Drawing.Point(146, 298);
            this.txtActor1.MaxLength = 32767;
            this.txtActor1.Name = "txtActor1";
            this.txtActor1.PasswordChar = '\0';
            this.txtActor1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtActor1.SelectedText = "";
            this.txtActor1.SelectionLength = 0;
            this.txtActor1.SelectionStart = 0;
            this.txtActor1.ShortcutsEnabled = true;
            this.txtActor1.Size = new System.Drawing.Size(142, 23);
            this.txtActor1.TabIndex = 37;
            this.txtActor1.UseSelectable = true;
            this.txtActor1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtActor1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCost
            // 
            // 
            // 
            // 
            this.txtCost.CustomButton.Image = null;
            this.txtCost.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtCost.CustomButton.Name = "";
            this.txtCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCost.CustomButton.TabIndex = 1;
            this.txtCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCost.CustomButton.UseSelectable = true;
            this.txtCost.CustomButton.Visible = false;
            this.txtCost.Lines = new string[0];
            this.txtCost.Location = new System.Drawing.Point(146, 251);
            this.txtCost.MaxLength = 32767;
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCost.SelectedText = "";
            this.txtCost.SelectionLength = 0;
            this.txtCost.SelectionStart = 0;
            this.txtCost.ShortcutsEnabled = true;
            this.txtCost.Size = new System.Drawing.Size(142, 23);
            this.txtCost.TabIndex = 36;
            this.txtCost.UseSelectable = true;
            this.txtCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAvalibility
            // 
            // 
            // 
            // 
            this.txtAvalibility.CustomButton.Image = null;
            this.txtAvalibility.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtAvalibility.CustomButton.Name = "";
            this.txtAvalibility.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAvalibility.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAvalibility.CustomButton.TabIndex = 1;
            this.txtAvalibility.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAvalibility.CustomButton.UseSelectable = true;
            this.txtAvalibility.CustomButton.Visible = false;
            this.txtAvalibility.Lines = new string[0];
            this.txtAvalibility.Location = new System.Drawing.Point(146, 202);
            this.txtAvalibility.MaxLength = 32767;
            this.txtAvalibility.Name = "txtAvalibility";
            this.txtAvalibility.PasswordChar = '\0';
            this.txtAvalibility.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvalibility.SelectedText = "";
            this.txtAvalibility.SelectionLength = 0;
            this.txtAvalibility.SelectionStart = 0;
            this.txtAvalibility.ShortcutsEnabled = true;
            this.txtAvalibility.Size = new System.Drawing.Size(142, 23);
            this.txtAvalibility.TabIndex = 35;
            this.txtAvalibility.UseSelectable = true;
            this.txtAvalibility.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAvalibility.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRating
            // 
            // 
            // 
            // 
            this.txtRating.CustomButton.Image = null;
            this.txtRating.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtRating.CustomButton.Name = "";
            this.txtRating.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRating.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRating.CustomButton.TabIndex = 1;
            this.txtRating.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRating.CustomButton.UseSelectable = true;
            this.txtRating.CustomButton.Visible = false;
            this.txtRating.Lines = new string[0];
            this.txtRating.Location = new System.Drawing.Point(146, 158);
            this.txtRating.MaxLength = 32767;
            this.txtRating.Name = "txtRating";
            this.txtRating.PasswordChar = '\0';
            this.txtRating.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRating.SelectedText = "";
            this.txtRating.SelectionLength = 0;
            this.txtRating.SelectionStart = 0;
            this.txtRating.ShortcutsEnabled = true;
            this.txtRating.Size = new System.Drawing.Size(142, 23);
            this.txtRating.TabIndex = 34;
            this.txtRating.UseSelectable = true;
            this.txtRating.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRating.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDVDName
            // 
            // 
            // 
            // 
            this.txtDVDName.CustomButton.Image = null;
            this.txtDVDName.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtDVDName.CustomButton.Name = "";
            this.txtDVDName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDVDName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDVDName.CustomButton.TabIndex = 1;
            this.txtDVDName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDVDName.CustomButton.UseSelectable = true;
            this.txtDVDName.CustomButton.Visible = false;
            this.txtDVDName.Lines = new string[0];
            this.txtDVDName.Location = new System.Drawing.Point(146, 111);
            this.txtDVDName.MaxLength = 32767;
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.PasswordChar = '\0';
            this.txtDVDName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDVDName.SelectedText = "";
            this.txtDVDName.SelectionLength = 0;
            this.txtDVDName.SelectionStart = 0;
            this.txtDVDName.ShortcutsEnabled = true;
            this.txtDVDName.Size = new System.Drawing.Size(142, 23);
            this.txtDVDName.TabIndex = 33;
            this.txtDVDName.UseSelectable = true;
            this.txtDVDName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDVDName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(37, 69);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "ObjectID";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(37, 206);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 55;
            this.metroLabel8.Text = "Avaliable";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Location = new System.Drawing.Point(37, 306);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 54;
            this.metroLabel9.Text = "Actors";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.Location = new System.Drawing.Point(37, 259);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(35, 19);
            this.metroLabel10.TabIndex = 53;
            this.metroLabel10.Text = "Cost";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.Location = new System.Drawing.Point(37, 166);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(46, 19);
            this.metroLabel11.TabIndex = 52;
            this.metroLabel11.Text = "Rating";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel12.Location = new System.Drawing.Point(37, 115);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(75, 19);
            this.metroLabel12.TabIndex = 51;
            this.metroLabel12.Text = "DVD Name";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DeleteItem";
            this.Text = "DeleteItem";
            this.Load += new System.EventHandler(this.DeleteItem_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView dataView;
        private MetroFramework.Controls.MetroLabel lblObjectID;
        private MetroFramework.Controls.MetroTextBox txtObjectID;
        private MetroFramework.Controls.MetroTextBox txtActor3;
        private MetroFramework.Controls.MetroTextBox txtActor2;
        private MetroFramework.Controls.MetroButton btnAddItem;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblAddItem;
        private MetroFramework.Controls.MetroTextBox txtActor1;
        private MetroFramework.Controls.MetroTextBox txtCost;
        private MetroFramework.Controls.MetroTextBox txtAvalibility;
        private MetroFramework.Controls.MetroTextBox txtRating;
        private MetroFramework.Controls.MetroTextBox txtDVDName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}