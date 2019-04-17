using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Tracker
{
    public partial class CustomMessageBox : MetroFramework.Forms.MetroForm
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        static CustomMessageBox msgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string Caption, string btnOk, string btnCancel)
        {
            msgBox = new CustomMessageBox();
            msgBox.movieLabel.Text = text;
            
            result = DialogResult.No;

            msgBox.ShowDialog();

            return result;



        }


        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
