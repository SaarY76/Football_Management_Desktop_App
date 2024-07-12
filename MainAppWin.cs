using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class MainAppWin : Form
    {
        // all of the collections we will use from the Database
        IMongoCollection<Models.Player> playersCollection { get; set; }
        IMongoCollection<Models.Team> teamsCollection { get; set; }
        IMongoCollection<Models.Contract> contractsCollection { get; set; }

        // Three Lists that we will save them the collections data because we will make some of the Models parameters dissapear
        private List<Models.ContractDetails> contractsDetailsList;
        private List<Models.Player> playersList;
        private List<Models.Team> teamsList;

        // Byte array for using Images
        public byte[] imageBytesTeam;

        public MainAppWin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;

            // Declare a mongo client
            MongoClient mongoClient;

            try
            {
                mongoClient = new MongoClient(connectionString);

                // Get the database Object itself
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                playersCollection = db.GetCollection<Models.Player>("Players");
                teamsCollection = db.GetCollection<Models.Team>("Teams");
                contractsCollection = db.GetCollection<Models.Contract>("Contracts");

                // When the form is loaded then we whould like to load all the existing Teams and Players upon the scrren
                LoadPlayers();
                LoadTeams();
                LoadContractsWithDetails();

                // Disable buttons on startup
                isCreateContractIsPossible();
                isContractDeleteButtonCanEnable();
                btn_Filter.Enabled = false;

                // inserting valid ages to the DateTime picker
                DateTime maxDate = DateTime.Now.AddYears(-15);
                dateTimePickerInsertPlayer.MaxDate = maxDate;
                dateTimePickerInsertPlayer.Value = maxDate;
                DateTime minDate = DateTime.Now.AddYears(-50);
                dateTimePickerInsertPlayer.MinDate = minDate;
            }
            catch (Exception ex)
            {// unseccessful connection to the Database
                MessageBox.Show("We got the Following error message:\n\n" + ex.Message,
                                "Mongo Client was not created", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // the function hides the ID columns of the two Players datagridviews that we will put as parameter
        public static void hideIdColumnAndRows(DataGridView dataGridView)
        {
            dataGridView.Select();
            if (dataGridView.DataSource != null)
            {
                // Hide the header in the first column
                dataGridView.Columns[0].Visible = false;

                // Hide all rows in the first column
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells[0].Style.BackColor = dataGridView.DefaultCellStyle.BackColor;
                    row.Cells[0].ReadOnly = true;
                }
            }
        }

        // the function load all of the Players from Database and insert them into Data gridview 
        private void LoadPlayers()
        {
            FilterDefinition<Models.Player> emptyFilter = Builders<Models.Player>.Filter.Empty;
            playersList = playersCollection.Find(emptyFilter).ToList();

            dataGridView_Players.DataSource = playersList;
            dataGridView_PlayerForFiltering.DataSource = playersList;


            int salaryColumnIndex = dataGridView_Players.Columns["PlayerSalary"].Index;


            dataGridView_Players.Columns[salaryColumnIndex].DefaultCellStyle.Format = "C";


            int salaryColumnIndexForFiltering = dataGridView_PlayerForFiltering.Columns["PlayerSalary"].Index;


            dataGridView_PlayerForFiltering.Columns[salaryColumnIndexForFiltering].DefaultCellStyle.Format = "C";


            int priceColumnIndexForFiltering = dataGridView_PlayerForFiltering.Columns["PlayerPrice"].Index;


            dataGridView_PlayerForFiltering.Columns[priceColumnIndexForFiltering].DefaultCellStyle.Format = "C";


            int priceColumnIndex = dataGridView_Players.Columns["PlayerPrice"].Index;


            dataGridView_Players.Columns[priceColumnIndex].DefaultCellStyle.Format = "C";


            int dateOfBirthColumnIndex = dataGridView_Players.Columns["PlayerBirthDate"].Index;


            dataGridView_Players.Columns[dateOfBirthColumnIndex].DefaultCellStyle.Format = "dd/MM/yyyy";


            int dateOfBirthColumnIndexForFiltering = dataGridView_PlayerForFiltering.Columns["PlayerBirthDate"].Index;


            dataGridView_PlayerForFiltering.Columns[dateOfBirthColumnIndexForFiltering].DefaultCellStyle.Format = "dd/MM/yyyy";


            hideIdColumnAndRows(dataGridView_Players);
            hideIdColumnAndRows(dataGridView_PlayerForFiltering);
        }

        // the click function of the refresh Players button
        private void btn_LoadPlayers_Click(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        // the function is of a button that when the user click on it 
        // it takes all of the values the user insertded and if there are no 
        // errors , it builds an Player Object and insert it to the Players Table
        private void btn_insertPlayer_Click(object sender, EventArgs e)
        {
            string error = "";// a string to add the error messages to the user

            Models.Player player;

            // checking if there is an error in one of the text boxes the user need to fill
            if (string.IsNullOrEmpty(textBox_PlayerName.Text))
                error += "Player Name is not valid";

            DateTime birthDate = dateTimePickerInsertPlayer.Value;

            double price = -1;
            double salary = -1;
            int matches = -1;
            int goals = -1;
            int assists = -1;


            if (string.IsNullOrEmpty(textBox_ProductPrice.Text) || !double.TryParse(textBox_ProductPrice.Text, out _))
                error += "\nPlayer Price is not valid";
            else
            {
                price = Convert.ToDouble(textBox_ProductPrice.Text);
                if (price < 0)
                    error += "\nPlayer Price is a negative number";
            }

            if (string.IsNullOrEmpty(textBox_PlayerSalary.Text) || !double.TryParse(textBox_PlayerSalary.Text, out _))
                error += "\nPlayer Salary is not valid";
            else
            {
                salary = Convert.ToDouble(textBox_PlayerSalary.Text);
                if (salary < 0)
                    error += "\nPlayer Salary is a negative number";
            }

            if (string.IsNullOrEmpty(textBox_PlayerMatches.Text) || !int.TryParse(textBox_PlayerMatches.Text, out _))
                error += "\nPlayer Matches is not valid";
            else
            {
                matches = Convert.ToInt32(textBox_PlayerMatches.Text);
                if (matches < 0)
                    error += "\nPlayer Matches is a negative number";
            }

            if (string.IsNullOrEmpty(textBox_PlayerGoals.Text) || !int.TryParse(textBox_PlayerGoals.Text, out _))
                error += "\nPlayer Goals is not valid";
            else
            {
                goals = Convert.ToInt32(textBox_PlayerGoals.Text);
                if (goals < 0)
                    error += "\nPlayer Goals is a negative number";
            }

            if (string.IsNullOrEmpty(textBox_PlayerAssists.Text) || !int.TryParse(textBox_PlayerAssists.Text, out _))
                error += "\nPlayer Assists is not valid";
            else
            {
                assists = Convert.ToInt32(textBox_PlayerAssists.Text);
                if (assists < 0)
                    error += "\nPlayer Assists is a negative number";
            }


            if (!error.Equals(""))// there is at least one error
            {
                MessageBox.Show("Not all of the values inserted ,Please type correctly\n" + error,
                                "Insert failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else // there are no errors
            {
                string name = textBox_PlayerName.Text.Trim();

                price = Convert.ToDouble(textBox_ProductPrice.Text);
                salary = Convert.ToDouble(textBox_PlayerSalary.Text);
                matches = Convert.ToInt32(textBox_PlayerMatches.Text);
                goals = Convert.ToInt32(textBox_PlayerGoals.Text);
                assists = Convert.ToInt32(textBox_PlayerAssists.Text);

                player = new Player(name, birthDate, price, salary, matches, goals, assists);
                bool isSame = false;
                foreach (Models.Player currentPlayer in playersList)
                {
                    if (currentPlayer.Equals(player))
                    {
                        isSame = true;
                        break;
                    }
                }
                if (!isSame)
                {
                    playersCollection.InsertOne(player);

                    MessageBox.Show("The following Player was inserted :\n" + player.ToString(),
                                        "Insert successded",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    LoadPlayers();
                    isCreateContractIsPossible();
                    isContractDeleteButtonCanEnable();
                    clearPlayerTextBoxes();
                    return;
                }
                MessageBox.Show("There is the same player already in the database\n" + error,
                                "Insert failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // the function clear all of the textboxes text in the filter tab
        private void clearPlayerTextBoxes()
        {
            textBox_PlayerName.Text = "";
            textBox_ProductPrice.Text = "";
            textBox_PlayerSalary.Text = "";
            textBox_PlayerMatches.Text = "";
            textBox_PlayerGoals.Text = "";
            textBox_PlayerAssists.Text = "";
        }

        // the function is the click even for the insert Team button that takes all of the user's values inserted
        // and create with them a Team in the Database
        private void btn_InsertTeam_Click(object sender, EventArgs e)
        {
            string error = "";// a string to add the error messages to the user

            Models.Team team;

            // checking if there is an error in one of the text boxes the user need to fill
            if (string.IsNullOrEmpty(textBox_TeamName.Text))
                error += "Team Name is not valid";

            if (string.IsNullOrEmpty(textBox_TeamNation.Text))
                error += "\nTeam Nation Name is not valid";

            if (string.IsNullOrEmpty(textBox_TeamLeague.Text))
                error += "\nTeam League Name is not valid";

            if (pictureBoxInsertTeam.Image == null)
                error += "\nTeam Image is not uploaded";

            if (!error.Equals(""))// there is at least one error
            {
                MessageBox.Show("Not all of the values inserted ,Please type correctly\n" + error,
                                "Insert failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else // there are no errors
            {
                string name = textBox_TeamName.Text.Trim();
                string nation = textBox_TeamNation.Text.Trim();
                string league = textBox_TeamLeague.Text.Trim();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Save the image from pictureBoxInsertTeam to the memory stream
                    pictureBoxInsertTeam.Image.Save(memoryStream, pictureBoxInsertTeam.Image.RawFormat);

                    // Set the image byte array from the memory stream
                    imageBytesTeam = memoryStream.ToArray();
                }

                team = new Team(name, nation, league, imageBytesTeam);
                bool isSame = false;
                foreach (Models.Team currentTeam in teamsList)
                {
                    if (currentTeam.Equals(team))
                    {
                        isSame = true;
                        break;
                    }
                }
                if (!isSame)
                {
                    teamsCollection.InsertOne(team);

                    MessageBox.Show("The following Team was inserted :\n" + team.ToString() + "\nAnd Image Uploaded",
                                        "Insert successded",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    clearTeamTextBoxes();
                    LoadTeams();
                    isCreateContractIsPossible();
                    pictureBoxInsertTeam.Image = null;
                    return;
                }
                MessageBox.Show("There is the same Team already in the database\n" + error,
                                "Insert failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // the function clears all of the textboxes in the insert Team group box
        private void clearTeamTextBoxes()
        {
            textBox_TeamName.Text = "";
            textBox_TeamNation.Text = "";
            textBox_TeamLeague.Text = "";
        }

        // the function load all of the Teams from Database and insert them into Data gridview 
        private void LoadTeams()
        {
            FilterDefinition<Models.Team> emptyFilter = Builders<Models.Team>.Filter.Empty;
            teamsList = teamsCollection.Find(emptyFilter).ToList();

            dataGridView_Teams.DataSource = teamsList;
            // Hide the header in the first column
            dataGridView_Teams.Columns[4].Visible = false;

            // Hide all rows in the first column
            foreach (DataGridViewRow row in dataGridView_Teams.Rows)
            {
                row.Cells[4].Style.BackColor = dataGridView_Teams.DefaultCellStyle.BackColor;
                row.Cells[4].ReadOnly = true;
            }
            hideIdColumnAndRows(dataGridView_Teams);
        }

        // the function is the click event for the refresh Teams button
        private void btn_LoadTeams_Click(object sender, EventArgs e)
        {
            LoadTeams();
        }

        // the function checks if the button of the create contract can be enabled
        // and sets it by conditions
        private void isCreateContractIsPossible()
        {
            if (dataGridView_Players.DataSource == null || dataGridView_Players.Rows.Count == 0 ||
                dataGridView_Teams.DataSource == null || dataGridView_Teams.Rows.Count == 0 ||
                dataGridView_Players.CurrentRow == null || dataGridView_Teams.CurrentRow == null)
            {
                btn_CreateContract.Enabled = false;
            }
            else
                btn_CreateContract.Enabled = true;
        }

        // the function is the click event for the create Contract that takes the two rows data
        // that the user clicked on them and insert the Contract with the ID of the two Models into the Database
        private void btn_CreateContract_Click(object sender, EventArgs e)
        {
            string error = "";// a string to add the error messages to the user

            string playerID = playersList[dataGridView_Players.CurrentRow.Index].PlayerId;
            string teamID = teamsList[dataGridView_Teams.CurrentRow.Index].TeamId;

            if (string.IsNullOrEmpty(playerID))
                error += "There is no Player selected !";
            if (string.IsNullOrEmpty(teamID))
                error += "There is no Team selected !";

            if (string.IsNullOrEmpty(error))// there are no errors
            {
                Models.Contract contract = new Contract(playerID, teamID);

                Models.Contract playerToFind = contractsCollection.Find
                    (c => c.PlayerContractID == playerID).FirstOrDefault();

                if (playerToFind != null)// The selected Player has a Contract with a Team
                {
                    MessageBox.Show("The player you selected already has a contract with a team\n",
                                "Insert Contract failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }

                // The Player has no Contract with any team so we can insert a contract between him and the selected Team
                contractsCollection.InsertOne(contract);

                MessageBox.Show("The Contract was inserted !\n",
                                    "Insert successded",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                LoadContractsWithDetails();
                isContractDeleteButtonCanEnable();
            }
            else // there is at least one error
            {
                MessageBox.Show("The Contract insert wasn't succeded \n" + error,
                                "Insert Contract failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // the function insert into a data gridview the details from each 
        // Contract in the Database by using the two IDs of the two Models in the Contract Document in the Database
        private void LoadContractsWithDetails()
        {
            FilterDefinition<Models.Contract> emptyFilter = Builders<Models.Contract>.Filter.Empty;
            List<Models.Contract> loadedContracts = contractsCollection.Find(emptyFilter).ToList();

            if (loadedContracts == null)
                return;

            contractsDetailsList = new List<ContractDetails>();

            if (loadedContracts != null)
            {
                foreach (Models.Contract currentContract in loadedContracts)
                {
                    string contractID = currentContract.ConrtactId;
                    string currentPlayerID = currentContract.PlayerContractID;
                    string currentTeamID = currentContract.teamContractID;

                    Models.Player player = playersCollection.Find(p => p.PlayerId == currentPlayerID).FirstOrDefault();
                    Models.Team team = teamsCollection.Find(t => t.TeamId == currentTeamID).FirstOrDefault();

                    Models.ContractDetails currentContractDetails = new ContractDetails(contractID, player, team);
                    contractsDetailsList.Add(currentContractDetails);
                }
            }

            dataGridView_ContractsDetails.DataSource = contractsDetailsList;

            int dateOfBirthColumnIndex = dataGridView_ContractsDetails.Columns["PlayerBirthDate"].Index;


            dataGridView_ContractsDetails.Columns[dateOfBirthColumnIndex].DefaultCellStyle.Format = "dd/MM/yyyy";


            int salaryColumnIndex = dataGridView_ContractsDetails.Columns["PlayerSalary"].Index;


            dataGridView_ContractsDetails.Columns[salaryColumnIndex].DefaultCellStyle.Format = "C";


            int priceColumnIndex = dataGridView_ContractsDetails.Columns["PlayerPrice"].Index;


            dataGridView_ContractsDetails.Columns[priceColumnIndex].DefaultCellStyle.Format = "C";


            hideIdsFromContractsDataGridView();
        }

        // the function hides in the Contracts Details dataGridView the IDs of the the Models in it
        private void hideIdsFromContractsDataGridView()
        {
            dataGridView_ContractsDetails.Select();


            if (dataGridView_ContractsDetails.DataSource != null)
            {
                // Hide the header in the first column
                dataGridView_ContractsDetails.Columns[0].Visible = false;
                dataGridView_ContractsDetails.Columns[1].Visible = false;
                dataGridView_ContractsDetails.Columns[9].Visible = false;

                // Hide all rows in the first column
                foreach (DataGridViewRow row in dataGridView_ContractsDetails.Rows)
                {
                    row.Cells[0].Style.BackColor = dataGridView_ContractsDetails.DefaultCellStyle.BackColor;
                    row.Cells[0].ReadOnly = true;

                    row.Cells[1].Style.BackColor = dataGridView_ContractsDetails.DefaultCellStyle.BackColor;
                    row.Cells[1].ReadOnly = true;

                    row.Cells[9].Style.BackColor = dataGridView_ContractsDetails.DefaultCellStyle.BackColor;
                    row.Cells[9].ReadOnly = true;
                }
            }
        }

        // the function is the click event of the refresh button of the Cntracts details data gridview
        private void btn_RefreshContracts_Click(object sender, EventArgs e)
        {
            LoadContractsWithDetails();
        }

        // the function checks if the delete Contract button can be set to enable
        // and sets it by conditions
        private void isContractDeleteButtonCanEnable()
        {
            if (dataGridView_ContractsDetails.DataSource == null || dataGridView_ContractsDetails.Rows.Count == 0
                || dataGridView_ContractsDetails.CurrentRow == null)
                btn_DeleteContract.Enabled = false;
            else
                btn_DeleteContract.Enabled = true;
        }

        // the function is the click event of the Delete Contract button that deletes a Contract from the Database
        private void btn_DeleteContract_Click(object sender, EventArgs e)
        {
            if (dataGridView_ContractsDetails.Rows.Count != 0)
            {
                try
                {
                    string selectedContractID = contractsDetailsList[dataGridView_ContractsDetails.CurrentRow.Index].ContractID;
                    contractsCollection.DeleteOne(c => c.ConrtactId == selectedContractID);

                    MessageBox.Show("The Contract deleted successfully",
                                            "Delete successded",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    LoadContractsWithDetails();
                    if (dataGridView_ContractsDetails.Rows.Count == 0)
                        btn_DeleteContract.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Delete wasn't succeeded because\n" + ex.Message,
                                 "Delete Contract failed",
                                MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
                
            }
        }

        // the function is the Double click event of cell in the datagriview of Teams that 
        // sends the data from it into a new Form Window that there the user can set the Team's details 
        // or delete it from the Database
        private void dataGridView_Teams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAndDeleteTeam teamDetailsWindow = new UpdateAndDeleteTeam(teamsCollection, contractsCollection,
                playersCollection, teamsList[dataGridView_Teams.CurrentRow.Index].TeamId);

            teamDetailsWindow.textBoxTeamNameUD.Text = dataGridView_Teams.CurrentRow.Cells[1].Value.ToString();
            teamDetailsWindow.textBoxTeamNationUD.Text = dataGridView_Teams.CurrentRow.Cells[2].Value.ToString();
            teamDetailsWindow.textBoxTeamLeagueUD.Text = dataGridView_Teams.CurrentRow.Cells[3].Value.ToString();

            if (teamsList[dataGridView_Teams.CurrentRow.Index].Image != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(teamsList[dataGridView_Teams.CurrentRow.Index].Image))
                {
                    teamDetailsWindow.pictureBoxTeamUD.Image = new Bitmap(Image.FromStream(memoryStream));
                }
            }
            else
            {
                teamDetailsWindow.pictureBoxTeamUD.Image = null; // or set to a default image
            }
            teamDetailsWindow.ShowDialog();

            LoadTeams();
            LoadContractsWithDetails();
        }

        // the function gets a DateTime Object and returns the age of the Player
        private int calculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            // Check if the birth date hasn't occurred yet this year
            if (birthDate > currentDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        // the function filter the players by or filter and shows it in data grid view
        private List<Models.Player> filteredByOrOperator()
        {
            FilterDefinition<Models.Player> emptyFilter = Builders<Models.Player>.Filter.Empty;
            List<Models.Player> allPlayers = playersCollection.Find(emptyFilter).ToList();

            if (allPlayers.Count == 0)
                return new List<Models.Player>();

            string name = textBox_NameFilter.Text.ToLower();

            double price = -1, salary = -1;
            int minimumAge = -1, maximumAge = -1, minimumMatches = -1, minimumGoals = -1, minimumAsissts = -1;


            if (!string.IsNullOrEmpty(textBox_MaximumPriceFilter.Text))
                price = Convert.ToDouble(textBox_MaximumPriceFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MaximumSalaryFilter.Text) && double.TryParse(textBox_MaximumSalaryFilter.Text, out _))
                salary = Convert.ToDouble(textBox_MaximumSalaryFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumAgeFilter.Text) && int.TryParse(textBox_MinimumAgeFilter.Text, out _))
                minimumAge = Convert.ToInt32(textBox_MinimumAgeFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MaximumAgeFilter.Text) && int.TryParse(textBox_MaximumAgeFilter.Text, out _))
                maximumAge = Convert.ToInt32(textBox_MaximumAgeFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumMatchesFilter.Text) && int.TryParse(textBox_MinimumMatchesFilter.Text, out _))
                minimumMatches = Convert.ToInt32(textBox_MinimumMatchesFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumGoalsFilter.Text) && int.TryParse(textBox_MinimumGoalsFilter.Text, out _))
                minimumGoals = Convert.ToInt32(textBox_MinimumGoalsFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumAssistsFilter.Text) && int.TryParse(textBox_MinimumAssistsFilter.Text, out _))
                minimumAsissts = Convert.ToInt32(textBox_MinimumAssistsFilter.Text);



            List<Models.Player> filteredPlayers = new List<Models.Player>();

            foreach (Models.Player currentPlayer in allPlayers)
            {
                if (!string.IsNullOrEmpty(name) && currentPlayer.PlayerName.ToLower() == name)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (price != -1 && price > 0 && currentPlayer.PlayerPrice <= price)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (salary != -1 &&  salary > 0 && currentPlayer.PlayerSalary <= salary)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (minimumAge != -1 &&  minimumAge > 0 && calculateAge(currentPlayer.PlayerBirthDate) >= minimumAge)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (maximumAge != -1 && maximumAge > 0 && calculateAge(currentPlayer.PlayerBirthDate) <= maximumAge)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (minimumMatches != -1 && minimumMatches > 0 && currentPlayer.PlayerMatches >= minimumMatches)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (minimumGoals != -1 && minimumGoals > 0 && currentPlayer.PlayerGoals >= minimumGoals)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
                if (minimumAsissts != -1 && minimumAsissts > 0 && currentPlayer.PlayerAssists >= minimumAsissts)
                {
                    filteredPlayers.Add(currentPlayer);
                    continue;
                }
            }
            // if all of the filter fields are not inserted by the user we will return all of the Players
            if (string.IsNullOrEmpty(name) && price == -1 && salary == -1 && minimumAge == -1 &&
                maximumAge == -1 && minimumMatches == -1 && minimumGoals == -1 && minimumAsissts == -1)
                return allPlayers;

            return filteredPlayers.Count == 0 ? new List<Models.Player>() : filteredPlayers;
        }

        // the function filter the players by and filter and shows it in data grid view
        private List<Models.Player> filteredByAndOperator()
        {
            FilterDefinition<Models.Player> emptyFilter = Builders<Models.Player>.Filter.Empty;
            List<Models.Player> allPlayers = playersCollection.Find(emptyFilter).ToList();

            if (allPlayers.Count == 0)
                return new List<Models.Player>();

            string name = textBox_NameFilter.Text;

            double price = -1, salary = -1;
            int minimumAge = -1, maximumAge = -1, minimumMatches = -1, minimumGoals = -1, minimumAsissts = -1;


            if (!string.IsNullOrEmpty(textBox_MaximumPriceFilter.Text) && double.TryParse(textBox_MaximumPriceFilter.Text, out _))
                price = Convert.ToDouble(textBox_MaximumPriceFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MaximumSalaryFilter.Text) && double.TryParse(textBox_MaximumSalaryFilter.Text, out _))
                salary = Convert.ToDouble(textBox_MaximumSalaryFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumAgeFilter.Text) && int.TryParse(textBox_MinimumAgeFilter.Text, out _))
                minimumAge = Convert.ToInt32(textBox_MinimumAgeFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MaximumAgeFilter.Text) && int.TryParse(textBox_MaximumAgeFilter.Text, out _))
                maximumAge = Convert.ToInt32(textBox_MaximumAgeFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumMatchesFilter.Text) && int.TryParse(textBox_MinimumMatchesFilter.Text, out _))
                minimumMatches = Convert.ToInt32(textBox_MinimumMatchesFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumGoalsFilter.Text) && int.TryParse(textBox_MinimumGoalsFilter.Text, out _))
                minimumGoals = Convert.ToInt32(textBox_MinimumGoalsFilter.Text);

            if (!string.IsNullOrEmpty(textBox_MinimumAssistsFilter.Text) && int.TryParse(textBox_MinimumAssistsFilter.Text, out _))
                minimumAsissts = Convert.ToInt32(textBox_MinimumAssistsFilter.Text);


            if (maximumAge != -1 && minimumAge != -1 && maximumAge < minimumAge)
            {
                maximumAge = -1;
                minimumAge = -1;

                MessageBox.Show("The maximum age is smaller then the minimum age so we ignore these filters",
                                "Age filters values are wrong",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            List<Models.Player> filteredPlayers = allPlayers;
            if (!string.IsNullOrEmpty(name))
                filteredPlayers = filteredPlayers.FindAll(p => p.PlayerName == name);
            if (price > 0)
                filteredPlayers = filteredPlayers.FindAll(p => p.PlayerPrice <= price);
            if (salary > 0)
                filteredPlayers = filteredPlayers.FindAll(p => p.PlayerSalary <= salary);
            if (minimumAge > 0)
                filteredPlayers = filteredPlayers.FindAll(p => calculateAge(p.PlayerBirthDate) >= minimumAge);
            if (maximumAge > 0)
                filteredPlayers = filteredPlayers.FindAll(p => calculateAge(p.PlayerBirthDate) <= maximumAge);
            if (minimumMatches > 0)
                filteredPlayers = filteredPlayers.FindAll(p => p.PlayerMatches >= minimumMatches);
            if (minimumGoals > 0)
                filteredPlayers = filteredPlayers.FindAll(p => p.PlayerGoals >= minimumGoals);
            if (minimumAsissts > 0)
                filteredPlayers = filteredPlayers.FindAll(p => p.PlayerAssists >= minimumAsissts);

            return filteredPlayers;
        }

        // the function is the click event of the Filter button that filters the 
        // Players field details of the Players in the Database and shows the results 
        // by calling another function by the operator the user chose
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string whichOperatorIsOn;
            List<Models.Player> filteredPlayers;
            if (radioButton_Or.Checked)
                whichOperatorIsOn = "or";
            else
                whichOperatorIsOn = "and";

            if (whichOperatorIsOn == "or")
                filteredPlayers = filteredByOrOperator();
            else
                filteredPlayers = filteredByAndOperator();

            dataGridView_PlayerForFiltering.DataSource = filteredPlayers;
        }

        // the function is the Checked Changed event of the Or radio button
        // and if it's enabled the Filter button is set to enabled
        private void radioButton_Or_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Or.Checked)
                btn_Filter.Enabled = true;
        }

        // the function is the Checked Changed event of the And radio button
        // and if it's enabled the Filter button is set to enabled
        private void radioButton_And_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_And.Checked)
                btn_Filter.Enabled = true;
        }

        // the function is the click even of the refresh Players in the Filter datagridview 
        private void btn_RefreshPlayersInFilter_Click(object sender, EventArgs e)
        {
            LoadAllPlayersForFiltering();
        }

        // the function loads all of the Players in the Database into a datagridview in the Filters tab
        private void LoadAllPlayersForFiltering ()
        {
            FilterDefinition<Models.Player> emptyFilter = Builders<Models.Player>.Filter.Empty;
            List<Models.Player> allPlayers = playersCollection.Find(emptyFilter).ToList();

            dataGridView_PlayerForFiltering.DataSource = allPlayers;
        }

        // the function is the datagridview of the Players cell content click that if the user clicked 
        // and also in the datagridview of the Teams, the create contract button can be set to enabled
        private void dataGridView_Players_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Teams.CurrentRow != null)
                btn_CreateContract.Enabled = true;
            else
                btn_CreateContract.Enabled = false;
        }

        // the function is the datagridview of the Teams cell content click that if the user clicked 
        // and also in the datagridview of the Players, the create contract button can be set to enabled
        private void dataGridView_Teams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Players.CurrentRow != null)
                btn_CreateContract.Enabled = true;
            else
                btn_CreateContract.Enabled = false;
        }

        // the function is the cell content click of the Contracts datagridview 
        // that enable the delete contract button
        private void dataGridView_ContractsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_DeleteContract.Enabled = true;
        }

        // the function is the click event of the insert image button in the insert Team group box  
        // that opens to the user the option to choose an image from his/her PC 
        // and load it to the app so after all of the field values inserted 
        // the Team can be upload to the Database
        private void buttonInsertTeamImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    try
                    {
                        using (Bitmap bitmap = new Bitmap(selectedImagePath))
                        {
                            // Clone the bitmap to prevent raw format error
                            
                            pictureBoxInsertTeam.Image = (Image)bitmap.Clone();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid image file. Please select a valid image.\n" + ex.Message, "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // the function is the click event of the backup button that backs up 
        // the Database content into a folder that the user inserted in the APP.config file
        private void btn_backUp_Click(object sender, EventArgs e)
        {
            try
            {
                string backUpPath = ConfigurationManager.AppSettings["pathForBackUp"];
                string backUpLocation = ConfigurationManager.AppSettings["pathForBackUpLocation"];
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.StartInfo = startInfo;
                process.Start();
                process.StandardInput.WriteLine("@cd " + backUpPath);  // MongoDB bin directory
                process.StandardInput.WriteLine("@" + backUpLocation);  // database name and desired backup location
                process.StandardInput.Close();
                string output = process.StandardOutput.ReadToEnd();  // Capture output
                process.WaitForExit();
                MessageBox.Show("Backup Succeeded !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The back up isn't Succeeded : " + ex.Message);
            }
        }

        // the function is the click event of the restore button that restores 
        // the content the user backed up before in a folder in his/her PC
        // that the path is from the App.config file that the user inserted there
        private void btn_restore_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.StartInfo = startInfo;
                process.Start();
                string restore = ConfigurationManager.AppSettings["pathForRestore"];
                string restoreLocation = ConfigurationManager.AppSettings["pathForRestoreLocation"];
                process.StandardInput.WriteLine("@cd " + restore);  // MongoDB bin directory
                process.StandardInput.WriteLine("@" + restoreLocation);  // database name and backup location
                process.StandardInput.Close();
                string output = process.StandardOutput.ReadToEnd();  // Capture output
                process.WaitForExit();
                MessageBox.Show("Restore Succeeded !");
                LoadPlayers();
                LoadTeams();
                LoadContractsWithDetails();
                LoadAllPlayersForFiltering();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // the function clears all of the fields values in the Filtering tab
        private void btn_ClearFiltering_Click(object sender, EventArgs e)
        {
            textBox_NameFilter.Text = "";
            textBox_MaximumPriceFilter.Text = "";
            textBox_MaximumSalaryFilter.Text = "";
            textBox_MinimumAgeFilter.Text = "";
            textBox_MinimumMatchesFilter.Text = "";
            textBox_MinimumGoalsFilter.Text = "";
            textBox_MinimumAssistsFilter.Text = "";
            textBox_MaximumAgeFilter.Text = "";
        }
    }
}
