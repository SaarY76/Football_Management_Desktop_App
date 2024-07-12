using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class UpdateAndDeleteTeam : Form
    {
        // all of the collections we will use from the Database 
        IMongoCollection<Models.Team> teamsCollection;
        IMongoCollection<Models.Contract> contractsCollection;
        IMongoCollection<Models.Player> playersCollection;
        string teamID;
        private bool isUserChangedPicture = false;

        public UpdateAndDeleteTeam()
        {
            InitializeComponent();
        }

        // the constructor of this Form that gets the collections from the previous Form 
        // and also the Team ID that the user click on the row that represent that Team
        public UpdateAndDeleteTeam(IMongoCollection<Models.Team> teamsCollection, 
            IMongoCollection<Models.Contract> contractsCollection, IMongoCollection<Models.Player> playersCollection,
            string teamID)
        {// constructor
            InitializeComponent();
            this.teamsCollection = teamsCollection;
            this.contractsCollection = contractsCollection;
            this.playersCollection = playersCollection;
            this.teamID = teamID;
            fillPlayersOfTeamDataGridView();
        }

        // the function fills all of the Players from the Database that have a Contract with the Team displayed
        private void fillPlayersOfTeamDataGridView ()
        {
            List<Models.Player> filteredPlayers = new List<Models.Player>();
            List<Models.Contract> filteredContracts = contractsCollection.Find(c => c.teamContractID == teamID).ToList();
            if (filteredContracts.Count > 0)
            {
                foreach (Models.Contract currentContract in filteredContracts)
                {
                    filteredPlayers.Add(playersCollection.Find(p => p.PlayerId == currentContract.PlayerContractID).First());
                }
                dataGridView_PlayersOfTeam.DataSource = filteredPlayers;
                setDataGridViewPlayers();
            }
            else
            {
                dataGridView_PlayersOfTeam.Visible = false;
                label_TeamPlayers.Visible = false;
            }
            textBox_TeamNumOfPlayers.Text = filteredPlayers.Count.ToString();

        }

        // the function sets the formats of the values in columns and hides the 
        // ID of the Players in the datagrigview
        private void setDataGridViewPlayers ()
        {
            int salaryColumnIndex = dataGridView_PlayersOfTeam.Columns["PlayerSalary"].Index;


            dataGridView_PlayersOfTeam.Columns[salaryColumnIndex].DefaultCellStyle.Format = "C";

            int priceColumnIndex = dataGridView_PlayersOfTeam.Columns["PlayerPrice"].Index;


            dataGridView_PlayersOfTeam.Columns[priceColumnIndex].DefaultCellStyle.Format = "C";


            int dateOfBirthColumnIndex = dataGridView_PlayersOfTeam.Columns["PlayerBirthDate"].Index;


            dataGridView_PlayersOfTeam.Columns[dateOfBirthColumnIndex].DefaultCellStyle.Format = "dd/MM/yyyy";

            MainAppWin.hideIdColumnAndRows(dataGridView_PlayersOfTeam);
        }

        // the function is the click event of the delete Team button
        // that deletes a Team from the Database and if it succeded 
        // the user will return to the previous Form Window
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(teamID))
                {
                    teamsCollection.DeleteOne(t => t.TeamId == teamID);
                    
                    FilterDefinition<Models.Contract> allContractsWithID =
                        Builders<Models.Contract>.Filter.Eq(c => c.teamContractID, teamID);
                    
                    contractsCollection.DeleteMany(allContractsWithID);
                    
                    MessageBox.Show("The Team Deleted seccesfully",
                                        "Delete successded",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Delete wasn't succeeded because of:\n" + ex.Message,
                                 "Delete Team failed",
                                MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            } 
        }
        
        // the function is the click event of the update Team button
        // that update the Team's details in the Database and if it succeded 
        // the user will return to the previous Form Window
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string error = "";

            // Find the team with the team ID
            Models.Team team = teamsCollection.Find(t => t.TeamId == teamID).FirstOrDefault();

            if (team != null)
            {
                string teamName = textBoxTeamNameUD.Text;
                string teamNation = textBoxTeamNationUD.Text;
                string teamLeague = textBoxTeamLeagueUD.Text;

                if (string.IsNullOrEmpty(teamName))
                    error += "Team name is empty";

                if (string.IsNullOrEmpty(teamNation))
                    error += "Team Nation is empty";

                if (string.IsNullOrEmpty(teamLeague))
                    error += "Team League is empty";

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("The Update wasn't succeeded \n" + error,
                                "Update Team failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }

                byte[] imageBytesTeam = null;

                if (isUserChangedPicture)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        // Save the image from pictureBoxInsertTeam to the memory stream
                        pictureBoxTeamUD.Image.Save(memoryStream, pictureBoxTeamUD.Image.RawFormat);

                        // Set the image byte array from the memory stream
                        imageBytesTeam = memoryStream.ToArray();

                        // Set team image
                        team.Image = imageBytesTeam;
                    }
                }

                Models.Team updatedTeam = new Models.Team(teamName, teamNation, teamLeague, imageBytesTeam);

                if (team.Equals(updatedTeam))
                {
                    if (!isUserChangedPicture)
                    {
                        MessageBox.Show("The Update wasn't succeeded because you didn't change any value from " +
                                 "the original\n" + error,
                                 "Update Team failed",
                                MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        teamsCollection.ReplaceOne(t => t.TeamId == teamID, team);
                        MessageBox.Show("The Team's Image Updated seccesfully",
                                    "Update succeeded",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        return;
                    }
                }

                // Update the Team in the collection
                try
                {
                    team.TeamName = teamName;
                    team.TeamNation = teamNation;
                    team.TeamLeague = teamLeague;
                    teamsCollection.ReplaceOne(t => t.TeamId == teamID, team);
                    string message = "The following Team Updated to those new Details:\n" + team.ToString();
                    if (isUserChangedPicture)
                        message += "\nAnd a new Image Updated";
                    MessageBox.Show(message,
                                    "Update succeeded",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Update wasn't succeeded\n" + ex.Message,
                                "Update Team failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
            else
            {
                error += "There is no Team with this ID";
                MessageBox.Show("The Update wasn't succeeded\n" + error,
                                "Update Team failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // the function is the click event of the update Image button
        // that let the user choose an Image from his/her PC and load it to the app
        // and then if the user will succeeded to load it into the app it can be updated 
        // in the Database if the Update button will be clicked
        private void btn_updateTeamImage_Click(object sender, EventArgs e)
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
                            pictureBoxTeamUD.Image = (Image)bitmap.Clone();
                            isUserChangedPicture = true;
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
    }
}
