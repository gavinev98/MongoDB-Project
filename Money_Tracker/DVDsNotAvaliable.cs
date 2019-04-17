using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Money_Tracker
{
    public partial class DVDsNotAvaliable : MetroFramework.Forms.MetroForm
    {

        

        //Connection to Mongo Database

        static MongoClient mongoDB = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase dataBase = mongoDB.GetDatabase("DVDSystem");
        static IMongoCollection<BsonDocument> collections = dataBase.GetCollection<BsonDocument>("DVDs");


      

        public DVDsNotAvaliable()
        {
            InitializeComponent();

        }



        private void RecentActivity_Load(object sender, EventArgs e)
        {

        }

        /*
        private static void map(IMongoDatabase database)
        {

            // Firstly I will store all my map information inside of a map variable.
            //I am creating a map function and each dvd will be the 'this' parameter.

            string mapfunction = @"
                            function() {
                                    var dvd = this;
                                         emit(collections.rating, { count: 1, priceFee: collections.price});
        }";


            string reduceFunction = @"
                              function(key, values) {
                                 var result = {count: 0, priceFee: 0};

                                 values.forEach(function(value){
                                 result.count += value.count;
                                 result.priceFee += value.priceFee;
                        });
                     return result;
                }";


            var collection = dataBase.GetCollection<BsonDocument>("DVDSystem");
            var options = new MapReduceOptionsBuilder();
            options.setFinalize(finalize);
            options.setOutput(MapReduceOutput.Inline);

            var results = collection.MapReduce(map, reduce, options);

            foreach (var result in results.GetResults())
            {
                Console.WriteLine(results.ToJson());
            }

        }
        */


        public void MapFunc(int specifiedAge)
        {
            BsonJavaScript map = "function() { " +
                   "emit(this.dvdName, {'price' : this.cost , 'Rating' : this.rating});}";

            //Reduce function which does nothing than returning the result
            BsonJavaScript reduce = "function(key, values) { " +
                            "values.forEach(" +
                                "function(value) {" +
                                    "return value;" +
                                "});" +
                            "}";

            // Filtering Movies to only show movies depending on rating chosen by user

            var filteringMovies = Builders<BsonDocument>.Filter.Eq("rating", specifiedAge);

            //Options for the result of the output
            var options = new MapReduceOptions<BsonDocument, BsonDocument>
            {
                OutputOptions = MapReduceOutputOptions.Inline,
                Filter = filteringMovies,
            };


            //Excute map and reduce functions
            var resultMR = collections.MapReduce(map, reduce, options);

            //print first result only

            try
            {

                CustomMessageBox.Show(resultMR.First().ToJson<MongoDB.Bson.BsonDocument>(), "caption", "caption", "caption");
            }
            catch(Exception e)
            {
                MessageBox.Show("No Movies found with rating : " + txtAge.Text);
            }

        }





        private void lblNotAvaliable_Click(object sender, EventArgs e)
        {

        }

        private void panelLoadNotAvaliable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAgeRating_Click(object sender, EventArgs e)
        {
            var age = Convert.ToInt32(txtAge.Text);

            MapFunc(age);
        }
    }
}
