using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp1.Models
{
    public class Team
    {
        // replacing the id with one we will create
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string TeamId { get; set; }

        [BsonElement("team_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string TeamName { get; set; }

        [BsonElement("nation"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string TeamNation { get; set; }

        [BsonElement("league_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string TeamLeague { get; set; }

        // Image field
        [BsonElement("image"), BsonRepresentation(MongoDB.Bson.BsonType.Binary)]
        public byte[] Image { get; set; }

        public Team (string name, string nation, string leagueName, byte[] image)
        {
            this.TeamName = name;
            this.TeamNation = nation;
            this.TeamLeague = leagueName;
            this.Image = image;
        }

        public bool Equals (Models.Team other)
        {
            if (this.TeamName != other.TeamName)
                return false;
            if (this.TeamNation != other.TeamNation)
                return false;
            if (this.TeamLeague != other.TeamLeague)
                return false;

            return true;
        }

        public override string ToString()
        {
            return "Team :\n" + "Name :" + this.TeamName + 
                 "\nNation : "+ this.TeamNation + "\nLeague : " + this.TeamLeague+"\n";
        }
    }
}
