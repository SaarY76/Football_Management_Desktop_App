using System;
namespace WindowsFormsApp1.Models
{
    public class ContractDetails
    {
        public string ContractID { get; set; }

        // Player Attributes
        public string PlayerContractID { get; set; }

        public string PlayerName { get; set; }

        public DateTime PlayerBirthDate { get; set; }

        public double PlayerPrice { get; set; }

        public double PlayerSalary { get; set; }

        public int PlayerMatches { get; set; }

        public int PlayerGoals { get; set; }

        public int PlayerAssists { get; set; }

        // Team Attributes
        public string TeamContractID { get; set; }

        public string TeamName { get; set; }

        public string TeamNation { get; set; }

        public string TeamLeague { get; set; }

        public ContractDetails(string contractID ,Models.Player player, Models.Team team)
        {// constructor
            ContractID = contractID;
            PlayerContractID = player.PlayerId;
            PlayerName = player.PlayerName;
            PlayerBirthDate = player.PlayerBirthDate;
            PlayerPrice = player.PlayerPrice;
            PlayerSalary = player.PlayerSalary;
            PlayerMatches = player.PlayerMatches;
            PlayerGoals = player.PlayerGoals;
            PlayerAssists = player.PlayerAssists;

            TeamContractID = team.TeamId;
            TeamName = team.TeamName;
            TeamLeague = team.TeamLeague;
            TeamNation = team.TeamNation;
        }
    }
}
