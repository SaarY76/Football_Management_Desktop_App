using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1.Models
{
    public class Contract
    {
        // replacing the id with one we will create
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ConrtactId { get; set; }

        [BsonElement("player_id"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string PlayerContractID { get; set; }

        [BsonElement("team_id"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string teamContractID { get; set; }

        public Contract (string playerID , string teamID)
        {// constructor
            this.PlayerContractID = playerID;
            this.teamContractID = teamID;
        }

        public override string ToString ()
        {
            return "Contract :\n" + "Team ID : " + this.teamContractID + "\nPlayer ID : " + this.PlayerContractID + "\n";
        }
    }
}
