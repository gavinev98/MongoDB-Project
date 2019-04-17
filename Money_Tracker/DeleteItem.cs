using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Money_Tracker
{
    public partial class DeleteItem : MetroFramework.Forms.MetroForm
    {

        //Connection to Mongo Database

        static MongoClient mongoDB = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase dataBase = mongoDB.GetDatabase("DVDSystem");
        static IMongoCollection<DVD> collections = dataBase.GetCollection<DVD>("DVDs");

        public DeleteItem()
        {
            InitializeComponent();
            RetrieveInfo();
        }

        public void RetrieveInfo()

        {
            List<DVD> listOfDocuments = collections.AsQueryable().ToList<DVD>();

            dataView.DataSource = listOfDocuments;

        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {

        }

        private void lblAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            DeleteFromMongo();
        }

        public void DeleteFromMongo()
        {
            collections.DeleteOne(s => s.Id == ObjectId.Parse(txtObjectID.Text));
            RetrieveInfo();

            MessageBox.Show("The DVD has been Successfully Deleted");
        }

        private void RetrieveInfo(object sender, DataGridViewCellEventArgs e)
        {
            txtObjectID.Text = dataView.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtDVDName.Text = dataView.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtRating.Text = dataView.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtAvalibility.Text = dataView.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtCost.Text = dataView.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtActor1.Text = dataView.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtActor2.Text = dataView.Rows[e.RowIndex].Cells[6].Value.ToString();

            txtActor3.Text = dataView.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
