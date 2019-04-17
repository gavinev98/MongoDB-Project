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
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void metroPanel2_Click(object sender, EventArgs e)
        {
            using (AddItem itemFrm = new AddItem())
            {
                itemFrm.ShowDialog();
            }
        }

        private void tileUpdateItem_Click(object sender, EventArgs e)
        {
            using (UpdateItem itemFrm = new UpdateItem())
            {
                itemFrm.ShowDialog();
            }
        }

        private void homeTile_Click(object sender, EventArgs e)
        {
            using (AddItem itmFrm = new AddItem())
            {
                itmFrm.ShowDialog();
            }

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            using (DeleteItem itmFrm = new DeleteItem())
            {
                itmFrm.ShowDialog();
            }
        }

        private void tileUpdateItem_Click_1(object sender, EventArgs e)
        {
            using (UpdateItem itemFrm = new UpdateItem())
            {
                itemFrm.ShowDialog();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            using (DVDsNotAvaliable itemNotAvaliable = new DVDsNotAvaliable())
            {
                itemNotAvaliable.ShowDialog();
            }
        }
    }
}
