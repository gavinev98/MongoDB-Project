using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Money_Tracker
{
    public partial class UpdateItem : MetroFramework.Forms.MetroForm
    {

        //Connection to Mongo Database

        static MongoClient mongoDB = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase dataBase = mongoDB.GetDatabase("DVDSystem");
        static IMongoCollection<DVD> collections = dataBase.GetCollection<DVD>("DVDs");

        public UpdateItem()
        {
            InitializeComponent();
            RetrieveInfo();

        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
           
        }

        public void RetrieveInfo()

        {
            List<DVD> listOfDocuments = collections.AsQueryable().ToList<DVD>();

            dataView.DataSource = listOfDocuments;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            UpdateDVDMongo();
        }

        public void UpdateDVDMongo()
        {

            var updatingDVD = Builders<DVD>.Update.Set("dvdName", txtDVDName.Text)
                .Set("rating", txtRating.Text).Set("avaliable", txtAvalibility.Text).Set("cost", txtCost.Text)
                .Set("actors1", txtActor1.Text).Set("actors2", txtActor2.Text).Set("actors3", txtActor3.Text);

            collections.UpdateOne(s => s.Id == ObjectId.Parse(txtObjectID.Text), updatingDVD);

            RetrieveInfo();

            MessageBox.Show("DVD has been sucuessfully updated");
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RetrieveDocuments(object sender, DataGridViewCellEventArgs e)
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
