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
    public partial class AddItem : MetroFramework.Forms.MetroForm
    {
        //Connection to Mongo Database

        static MongoClient mongoDB = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase dataBase = mongoDB.GetDatabase("DVDSystem");
        static IMongoCollection<DVD> collections = dataBase.GetCollection<DVD>("DVDs");
       
        public AddItem()
        {
            
            InitializeComponent();
          
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        public void ReadDocs()

        {
            List<DVD> listOfDocuments = collections.AsQueryable().ToList<DVD>();

           // dataView.DataSource = listOfDocuments;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            InsertIntoMongo();

        }

        public void InsertIntoMongo()
        {
            DVD dvdsDetails = new DVD(txtDVDName.Text, Convert.ToInt32(txtRating.Text), txtAvalibility.Text, txtCost.Text, txtActor1.Text, txtActor2.Text, txtActor3.Text);
            collections.InsertOne(dvdsDetails);

            MessageBox.Show("Dvd has been added to the database");

        }

        private void ReadDocs(object sender, EventArgs e)
        {
           
        }

        private void ReadAllDocs(object sender, DataGridViewCellEventArgs e)
        {
           // txtDVDName.Text = dataView.Rows[e.RowIndex].Cells[0].Value.ToString();

           // txtRating.Text = dataView.Rows[e.RowIndex].Cells[1].Value.ToString();

           // txtAvalibility.Text = dataView.Rows[e.RowIndex].Cells[2].Value.ToString();

           // txtCost.Text = dataView.Rows[e.RowIndex].Cells[3].Value.ToString();

           // txtActor1.Text = dataView.Rows[e.RowIndex].Cells[4].Value.ToString();

           // txtActor2.Text = dataView.Rows[e.RowIndex].Cells[4].Value.ToString();

          //  txtActor3.Text = dataView.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
}
