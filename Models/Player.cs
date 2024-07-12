using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WindowsFormsApp1.Models
{
    [Serializable]
    public class Player
    {
        // replacing the id with one we will create
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string PlayerId { get; set; }

        [BsonElement("player_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string PlayerName { get; set; }

        [BsonElement("player_birth_date"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime PlayerBirthDate { get; set; }

        [BsonElement("player_price"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public double PlayerPrice { get; set; }

        [BsonElement("player_salary"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public double PlayerSalary { get; set; }

        [BsonElement("player__matches"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int PlayerMatches { get; set; }

        [BsonElement("player_goals"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int PlayerGoals { get; set; }

        [BsonElement("player_assists"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int PlayerAssists { get; set; }

        public Player(string playerName, DateTime birthDate, double price, double salary, int matches, int goals, int assists)
        {// constructor
            PlayerName = playerName;
            PlayerPrice = price;
            PlayerSalary = salary;
            PlayerMatches = matches;
            PlayerGoals = goals;
            PlayerAssists = assists;
            PlayerBirthDate = birthDate;
        }

        public override string ToString()
        {
            return "Player : \n" +
                    "Name : " + this.PlayerName + "\n" +
                    "Price : " + this.PlayerPrice + "₪\n" +
                    "Salary : " + this.PlayerSalary + "₪\n" +
                    "Birth Date : " + this.PlayerBirthDate.ToString() + "\n" + 
                    "Number of Matches : " + this.PlayerMatches + "\n" + 
                    "Number of Goals : " + this.PlayerGoals + "\n" +
                    "Number of Assists : " + this.PlayerAssists + "\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   PlayerId == player.PlayerId &&
                   PlayerName == player.PlayerName &&
                   PlayerBirthDate == player.PlayerBirthDate &&
                   PlayerPrice == player.PlayerPrice &&
                   PlayerSalary == player.PlayerSalary &&
                   PlayerMatches == player.PlayerMatches &&
                   PlayerGoals == player.PlayerGoals &&
                   PlayerAssists == player.PlayerAssists;
        }
    }
}
