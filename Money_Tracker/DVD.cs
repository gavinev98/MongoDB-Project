using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Money_Tracker
{
    class DVD
    {
        

        public DVD(String dvdName, int rating, String avaliable, String cost, String actors1, String actors2, String actors3)
        {
            this.dvdName = dvdName;
            this.rating = rating;
            this.avaliable = avaliable;
            this.cost = cost;
            this.actors1 = actors1;
            this.actors2 = actors2;
            this.actors3 = actors3;




        }
        

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("dvdName")]
        public String dvdName { get; set; }
        [BsonElement("rating")]
        public int rating { get; set; }
        [BsonElement("avaliable")]
        public String avaliable { get; set; }
        [BsonElement("cost")]
        public String cost { get; set; }
        [BsonElement("actor1")]
        public String actors1 { get; set; }
        [BsonElement("actor2")]
        public String actors2 { get; set; }
        [BsonElement("actor3")]
        public String actors3 { get; set; }

     
       

    }
}
