
namespace WindowsFormsApp1
{
    partial class MainAppWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppWin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteContract = new System.Windows.Forms.Button();
            this.btn_RefreshContracts = new System.Windows.Forms.Button();
            this.dataGridView_ContractsDetails = new System.Windows.Forms.DataGridView();
            this.btn_CreateContract = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonInsertTeamImage = new System.Windows.Forms.Button();
            this.textBox_TeamName = new System.Windows.Forms.TextBox();
            this.pictureBoxInsertTeam = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_TeamLeague = new System.Windows.Forms.TextBox();
            this.textBox_TeamNation = new System.Windows.Forms.TextBox();
            this.btn_InsertTeam = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_LoadTeams = new System.Windows.Forms.Button();
            this.dataGridView_Teams = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerInsertPlayer = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PlayerSalary = new System.Windows.Forms.TextBox();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.textBox_PlayerAssists = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_insertPlayer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_PlayerMatches = new System.Windows.Forms.TextBox();
            this.textBox_PlayerGoals = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_LoadPlayers = new System.Windows.Forms.Button();
            this.dataGridView_Players = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ClearFiltering = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_backUp = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_MaximumAgeFilter = new System.Windows.Forms.TextBox();
            this.textBox_NameFilter = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_MinimumAssistsFilter = new System.Windows.Forms.TextBox();
            this.textBox_MinimumAgeFilter = new System.Windows.Forms.TextBox();
            this.textBox_MinimumGoalsFilter = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_MinimumMatchesFilter = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_MaximumSalaryFilter = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_MaximumPriceFilter = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButton_Or = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton_And = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_RefreshPlayersInFilter = new System.Windows.Forms.Button();
            this.dataGridView_PlayerForFiltering = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContractsDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsertTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teams)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Players)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PlayerForFiltering)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1354, 834);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 808);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_DeleteContract);
            this.groupBox2.Controls.Add(this.btn_RefreshContracts);
            this.groupBox2.Controls.Add(this.dataGridView_ContractsDetails);
            this.groupBox2.Controls.Add(this.btn_CreateContract);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 500);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1319, 293);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contracts Details:";
            // 
            // btn_DeleteContract
            // 
            this.btn_DeleteContract.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeleteContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteContract.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteContract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeleteContract.Location = new System.Drawing.Point(1055, 225);
            this.btn_DeleteContract.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DeleteContract.Name = "btn_DeleteContract";
            this.btn_DeleteContract.Size = new System.Drawing.Size(234, 48);
            this.btn_DeleteContract.TabIndex = 5;
            this.btn_DeleteContract.Text = "Delete Contract";
            this.btn_DeleteContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteContract.UseVisualStyleBackColor = false;
            this.btn_DeleteContract.Click += new System.EventHandler(this.btn_DeleteContract_Click);
            // 
            // btn_RefreshContracts
            // 
            this.btn_RefreshContracts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RefreshContracts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshContracts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_RefreshContracts.Location = new System.Drawing.Point(42, 225);
            this.btn_RefreshContracts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_RefreshContracts.Name = "btn_RefreshContracts";
            this.btn_RefreshContracts.Size = new System.Drawing.Size(236, 48);
            this.btn_RefreshContracts.TabIndex = 4;
            this.btn_RefreshContracts.Text = "Refresh Contracts";
            this.btn_RefreshContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshContracts.UseVisualStyleBackColor = true;
            this.btn_RefreshContracts.Click += new System.EventHandler(this.btn_RefreshContracts_Click);
            // 
            // dataGridView_ContractsDetails
            // 
            this.dataGridView_ContractsDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_ContractsDetails.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_ContractsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ContractsDetails.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_ContractsDetails.Location = new System.Drawing.Point(16, 35);
            this.dataGridView_ContractsDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_ContractsDetails.MultiSelect = false;
            this.dataGridView_ContractsDetails.Name = "dataGridView_ContractsDetails";
            this.dataGridView_ContractsDetails.ReadOnly = true;
            this.dataGridView_ContractsDetails.RowHeadersVisible = false;
            this.dataGridView_ContractsDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_ContractsDetails.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ContractsDetails.RowTemplate.Height = 24;
            this.dataGridView_ContractsDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ContractsDetails.Size = new System.Drawing.Size(1295, 177);
            this.dataGridView_ContractsDetails.TabIndex = 2;
            this.dataGridView_ContractsDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ContractsDetails_CellContentClick);
            // 
            // btn_CreateContract
            // 
            this.btn_CreateContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateContract.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateContract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateContract.Location = new System.Drawing.Point(599, 225);
            this.btn_CreateContract.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CreateContract.Name = "btn_CreateContract";
            this.btn_CreateContract.Size = new System.Drawing.Size(231, 48);
            this.btn_CreateContract.TabIndex = 5;
            this.btn_CreateContract.Text = "Create Contract";
            this.btn_CreateContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateContract.UseVisualStyleBackColor = true;
            this.btn_CreateContract.Click += new System.EventHandler(this.btn_CreateContract_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btn_LoadTeams);
            this.groupBox3.Controls.Add(this.dataGridView_Teams);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.Location = new System.Drawing.Point(16, 256);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1304, 249);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teams :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.buttonInsertTeamImage);
            this.groupBox6.Controls.Add(this.textBox_TeamName);
            this.groupBox6.Controls.Add(this.pictureBoxInsertTeam);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBox_TeamLeague);
            this.groupBox6.Controls.Add(this.textBox_TeamNation);
            this.groupBox6.Controls.Add(this.btn_InsertTeam);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(12, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(658, 210);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Insert Team :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 45);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "Name :";
            // 
            // buttonInsertTeamImage
            // 
            this.buttonInsertTeamImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsertTeamImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInsertTeamImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonInsertTeamImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonInsertTeamImage.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonInsertTeamImage.Location = new System.Drawing.Point(405, 163);
            this.buttonInsertTeamImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonInsertTeamImage.Name = "buttonInsertTeamImage";
            this.buttonInsertTeamImage.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonInsertTeamImage.Size = new System.Drawing.Size(193, 33);
            this.buttonInsertTeamImage.TabIndex = 13;
            this.buttonInsertTeamImage.Text = "Upload Image";
            this.buttonInsertTeamImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInsertTeamImage.UseVisualStyleBackColor = true;
            this.buttonInsertTeamImage.Click += new System.EventHandler(this.buttonInsertTeamImage_Click);
            // 
            // textBox_TeamName
            // 
            this.textBox_TeamName.Location = new System.Drawing.Point(134, 45);
            this.textBox_TeamName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TeamName.Name = "textBox_TeamName";
            this.textBox_TeamName.Size = new System.Drawing.Size(222, 27);
            this.textBox_TeamName.TabIndex = 2;
            // 
            // pictureBoxInsertTeam
            // 
            this.pictureBoxInsertTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInsertTeam.Location = new System.Drawing.Point(405, 25);
            this.pictureBoxInsertTeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxInsertTeam.Name = "pictureBoxInsertTeam";
            this.pictureBoxInsertTeam.Size = new System.Drawing.Size(193, 124);
            this.pictureBoxInsertTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInsertTeam.TabIndex = 12;
            this.pictureBoxInsertTeam.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 125);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 19);
            this.label20.TabIndex = 4;
            this.label20.Text = "Nation :";
            // 
            // textBox_TeamLeague
            // 
            this.textBox_TeamLeague.Location = new System.Drawing.Point(134, 86);
            this.textBox_TeamLeague.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TeamLeague.Name = "textBox_TeamLeague";
            this.textBox_TeamLeague.Size = new System.Drawing.Size(222, 27);
            this.textBox_TeamLeague.TabIndex = 7;
            // 
            // textBox_TeamNation
            // 
            this.textBox_TeamNation.Location = new System.Drawing.Point(134, 125);
            this.textBox_TeamNation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TeamNation.Name = "textBox_TeamNation";
            this.textBox_TeamNation.Size = new System.Drawing.Size(222, 27);
            this.textBox_TeamNation.TabIndex = 5;
            // 
            // btn_InsertTeam
            // 
            this.btn_InsertTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InsertTeam.Location = new System.Drawing.Point(4, 162);
            this.btn_InsertTeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_InsertTeam.Name = "btn_InsertTeam";
            this.btn_InsertTeam.Size = new System.Drawing.Size(195, 34);
            this.btn_InsertTeam.TabIndex = 0;
            this.btn_InsertTeam.Text = "Insert Team";
            this.btn_InsertTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertTeam.UseVisualStyleBackColor = true;
            this.btn_InsertTeam.Click += new System.EventHandler(this.btn_InsertTeam_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "League :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(758, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(410, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Double Click on one of the cells of the teams to update it\'s details or delete";
            // 
            // btn_LoadTeams
            // 
            this.btn_LoadTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadTeams.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadTeams.Location = new System.Drawing.Point(926, 202);
            this.btn_LoadTeams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LoadTeams.Name = "btn_LoadTeams";
            this.btn_LoadTeams.Size = new System.Drawing.Size(176, 36);
            this.btn_LoadTeams.TabIndex = 4;
            this.btn_LoadTeams.Text = "Refresh Teams";
            this.btn_LoadTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LoadTeams.UseVisualStyleBackColor = true;
            this.btn_LoadTeams.Click += new System.EventHandler(this.btn_LoadTeams_Click);
            // 
            // dataGridView_Teams
            // 
            this.dataGridView_Teams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Teams.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teams.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_Teams.Location = new System.Drawing.Point(760, 58);
            this.dataGridView_Teams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Teams.MultiSelect = false;
            this.dataGridView_Teams.Name = "dataGridView_Teams";
            this.dataGridView_Teams.ReadOnly = true;
            this.dataGridView_Teams.RowHeadersVisible = false;
            this.dataGridView_Teams.RowHeadersWidth = 51;
            this.dataGridView_Teams.RowTemplate.Height = 24;
            this.dataGridView_Teams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Teams.Size = new System.Drawing.Size(514, 127);
            this.dataGridView_Teams.TabIndex = 2;
            this.dataGridView_Teams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Teams_CellContentClick);
            this.dataGridView_Teams.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Teams_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btn_LoadPlayers);
            this.groupBox1.Controls.Add(this.dataGridView_Players);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1304, 238);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dateTimePickerInsertPlayer);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBox_PlayerSalary);
            this.groupBox5.Controls.Add(this.textBox_PlayerName);
            this.groupBox5.Controls.Add(this.textBox_PlayerAssists);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBox_ProductPrice);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btn_insertPlayer);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox_PlayerMatches);
            this.groupBox5.Controls.Add(this.textBox_PlayerGoals);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(676, 206);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Insert Player :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // dateTimePickerInsertPlayer
            // 
            this.dateTimePickerInsertPlayer.Location = new System.Drawing.Point(450, 22);
            this.dateTimePickerInsertPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerInsertPlayer.Name = "dateTimePickerInsertPlayer";
            this.dateTimePickerInsertPlayer.Size = new System.Drawing.Size(208, 27);
            this.dateTimePickerInsertPlayer.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDate :";
            // 
            // textBox_PlayerSalary
            // 
            this.textBox_PlayerSalary.Location = new System.Drawing.Point(450, 69);
            this.textBox_PlayerSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_PlayerSalary.Name = "textBox_PlayerSalary";
            this.textBox_PlayerSalary.Size = new System.Drawing.Size(208, 27);
            this.textBox_PlayerSalary.TabIndex = 7;
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Location = new System.Drawing.Point(113, 30);
            this.textBox_PlayerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(208, 27);
            this.textBox_PlayerName.TabIndex = 2;
            // 
            // textBox_PlayerAssists
            // 
            this.textBox_PlayerAssists.Location = new System.Drawing.Point(113, 165);
            this.textBox_PlayerAssists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_PlayerAssists.Name = "textBox_PlayerAssists";
            this.textBox_PlayerAssists.Size = new System.Drawing.Size(210, 27);
            this.textBox_PlayerAssists.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Salary :";
            // 
            // textBox_ProductPrice
            // 
            this.textBox_ProductPrice.Location = new System.Drawing.Point(113, 74);
            this.textBox_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_ProductPrice.Name = "textBox_ProductPrice";
            this.textBox_ProductPrice.Size = new System.Drawing.Size(208, 27);
            this.textBox_ProductPrice.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Assists :";
            // 
            // btn_insertPlayer
            // 
            this.btn_insertPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertPlayer.Location = new System.Drawing.Point(364, 158);
            this.btn_insertPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_insertPlayer.Name = "btn_insertPlayer";
            this.btn_insertPlayer.Size = new System.Drawing.Size(195, 38);
            this.btn_insertPlayer.TabIndex = 0;
            this.btn_insertPlayer.Text = "Insert Player";
            this.btn_insertPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_insertPlayer.UseVisualStyleBackColor = true;
            this.btn_insertPlayer.Click += new System.EventHandler(this.btn_insertPlayer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Matches :";
            // 
            // textBox_PlayerMatches
            // 
            this.textBox_PlayerMatches.Location = new System.Drawing.Point(113, 117);
            this.textBox_PlayerMatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_PlayerMatches.Name = "textBox_PlayerMatches";
            this.textBox_PlayerMatches.Size = new System.Drawing.Size(210, 27);
            this.textBox_PlayerMatches.TabIndex = 12;
            // 
            // textBox_PlayerGoals
            // 
            this.textBox_PlayerGoals.Location = new System.Drawing.Point(450, 116);
            this.textBox_PlayerGoals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_PlayerGoals.Name = "textBox_PlayerGoals";
            this.textBox_PlayerGoals.Size = new System.Drawing.Size(208, 27);
            this.textBox_PlayerGoals.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Goals :";
            // 
            // btn_LoadPlayers
            // 
            this.btn_LoadPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadPlayers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadPlayers.Location = new System.Drawing.Point(926, 184);
            this.btn_LoadPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LoadPlayers.Name = "btn_LoadPlayers";
            this.btn_LoadPlayers.Size = new System.Drawing.Size(176, 38);
            this.btn_LoadPlayers.TabIndex = 3;
            this.btn_LoadPlayers.Text = "Refresh Players";
            this.btn_LoadPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LoadPlayers.UseVisualStyleBackColor = true;
            this.btn_LoadPlayers.Click += new System.EventHandler(this.btn_LoadPlayers_Click);
            // 
            // dataGridView_Players
            // 
            this.dataGridView_Players.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Players.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Players.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_Players.Location = new System.Drawing.Point(761, 31);
            this.dataGridView_Players.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Players.MultiSelect = false;
            this.dataGridView_Players.Name = "dataGridView_Players";
            this.dataGridView_Players.ReadOnly = true;
            this.dataGridView_Players.RowHeadersVisible = false;
            this.dataGridView_Players.RowHeadersWidth = 51;
            this.dataGridView_Players.RowTemplate.Height = 24;
            this.dataGridView_Players.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Players.Size = new System.Drawing.Size(514, 143);
            this.dataGridView_Players.TabIndex = 2;
            this.dataGridView_Players.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Players_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.btn_RefreshPlayersInFilter);
            this.tabPage4.Controls.Add(this.dataGridView_PlayerForFiltering);
            this.tabPage4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1346, 808);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Filtering, BackUp\\Restore";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox4.Controls.Add(this.btn_ClearFiltering);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.btn_restore);
            this.groupBox4.Controls.Add(this.btn_backUp);
            this.groupBox4.Controls.Add(this.btn_Filter);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox_MaximumAgeFilter);
            this.groupBox4.Controls.Add(this.textBox_NameFilter);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.textBox_MinimumAssistsFilter);
            this.groupBox4.Controls.Add(this.textBox_MinimumAgeFilter);
            this.groupBox4.Controls.Add(this.textBox_MinimumGoalsFilter);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.textBox_MinimumMatchesFilter);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.textBox_MaximumSalaryFilter);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox_MaximumPriceFilter);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.radioButton_Or);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.radioButton_And);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox4.Location = new System.Drawing.Point(60, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1282, 496);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter Area";
            // 
            // btn_ClearFiltering
            // 
            this.btn_ClearFiltering.Location = new System.Drawing.Point(457, 428);
            this.btn_ClearFiltering.Name = "btn_ClearFiltering";
            this.btn_ClearFiltering.Size = new System.Drawing.Size(166, 54);
            this.btn_ClearFiltering.TabIndex = 24;
            this.btn_ClearFiltering.Text = "Clear";
            this.btn_ClearFiltering.UseVisualStyleBackColor = true;
            this.btn_ClearFiltering.Click += new System.EventHandler(this.btn_ClearFiltering_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.field1;
            this.pictureBox1.Location = new System.Drawing.Point(951, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 243);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_restore
            // 
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_restore.FlatAppearance.BorderSize = 2;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.ForeColor = System.Drawing.Color.Red;
            this.btn_restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restore.Location = new System.Drawing.Point(1078, 427);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.btn_restore.Size = new System.Drawing.Size(141, 56);
            this.btn_restore.TabIndex = 22;
            this.btn_restore.Text = " Restore";
            this.btn_restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click_1);
            // 
            // btn_backUp
            // 
            this.btn_backUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_backUp.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_backUp.FlatAppearance.BorderSize = 2;
            this.btn_backUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backUp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backUp.ForeColor = System.Drawing.Color.Green;
            this.btn_backUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backUp.Location = new System.Drawing.Point(892, 428);
            this.btn_backUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_backUp.Name = "btn_backUp";
            this.btn_backUp.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.btn_backUp.Size = new System.Drawing.Size(151, 56);
            this.btn_backUp.TabIndex = 22;
            this.btn_backUp.Text = " BackUp";
            this.btn_backUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_backUp.UseVisualStyleBackColor = false;
            this.btn_backUp.Click += new System.EventHandler(this.btn_backUp_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(173, 426);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(179, 56);
            this.btn_Filter.TabIndex = 20;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label25.Location = new System.Drawing.Point(453, 301);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 19);
            this.label25.TabIndex = 19;
            this.label25.Text = "Maximum Age : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(18, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 24);
            this.label15.TabIndex = 7;
            this.label15.Text = "Filter By : ";
            // 
            // textBox_MaximumAgeFilter
            // 
            this.textBox_MaximumAgeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MaximumAgeFilter.Location = new System.Drawing.Point(674, 301);
            this.textBox_MaximumAgeFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MaximumAgeFilter.Name = "textBox_MaximumAgeFilter";
            this.textBox_MaximumAgeFilter.Size = new System.Drawing.Size(168, 23);
            this.textBox_MaximumAgeFilter.TabIndex = 18;
            // 
            // textBox_NameFilter
            // 
            this.textBox_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_NameFilter.Location = new System.Drawing.Point(218, 142);
            this.textBox_NameFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_NameFilter.Name = "textBox_NameFilter";
            this.textBox_NameFilter.Size = new System.Drawing.Size(134, 23);
            this.textBox_NameFilter.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label24.Location = new System.Drawing.Point(20, 297);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 19);
            this.label24.TabIndex = 17;
            this.label24.Text = "Minimum Age : ";
            // 
            // textBox_MinimumAssistsFilter
            // 
            this.textBox_MinimumAssistsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MinimumAssistsFilter.Location = new System.Drawing.Point(674, 247);
            this.textBox_MinimumAssistsFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MinimumAssistsFilter.Name = "textBox_MinimumAssistsFilter";
            this.textBox_MinimumAssistsFilter.Size = new System.Drawing.Size(168, 23);
            this.textBox_MinimumAssistsFilter.TabIndex = 2;
            // 
            // textBox_MinimumAgeFilter
            // 
            this.textBox_MinimumAgeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MinimumAgeFilter.Location = new System.Drawing.Point(218, 301);
            this.textBox_MinimumAgeFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MinimumAgeFilter.Name = "textBox_MinimumAgeFilter";
            this.textBox_MinimumAgeFilter.Size = new System.Drawing.Size(134, 23);
            this.textBox_MinimumAgeFilter.TabIndex = 16;
            // 
            // textBox_MinimumGoalsFilter
            // 
            this.textBox_MinimumGoalsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MinimumGoalsFilter.Location = new System.Drawing.Point(674, 188);
            this.textBox_MinimumGoalsFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MinimumGoalsFilter.Name = "textBox_MinimumGoalsFilter";
            this.textBox_MinimumGoalsFilter.Size = new System.Drawing.Size(168, 23);
            this.textBox_MinimumGoalsFilter.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label23.Location = new System.Drawing.Point(453, 247);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 19);
            this.label23.TabIndex = 15;
            this.label23.Text = "Minimum Asissits : ";
            // 
            // textBox_MinimumMatchesFilter
            // 
            this.textBox_MinimumMatchesFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MinimumMatchesFilter.Location = new System.Drawing.Point(674, 133);
            this.textBox_MinimumMatchesFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MinimumMatchesFilter.Name = "textBox_MinimumMatchesFilter";
            this.textBox_MinimumMatchesFilter.Size = new System.Drawing.Size(168, 23);
            this.textBox_MinimumMatchesFilter.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.Location = new System.Drawing.Point(453, 188);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 19);
            this.label21.TabIndex = 14;
            this.label21.Text = "Minimum Goals :";
            // 
            // textBox_MaximumSalaryFilter
            // 
            this.textBox_MaximumSalaryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MaximumSalaryFilter.Location = new System.Drawing.Point(218, 246);
            this.textBox_MaximumSalaryFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MaximumSalaryFilter.Name = "textBox_MaximumSalaryFilter";
            this.textBox_MaximumSalaryFilter.Size = new System.Drawing.Size(134, 23);
            this.textBox_MaximumSalaryFilter.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(453, 133);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 19);
            this.label19.TabIndex = 13;
            this.label19.Text = "Minimum Matches :";
            // 
            // textBox_MaximumPriceFilter
            // 
            this.textBox_MaximumPriceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MaximumPriceFilter.Location = new System.Drawing.Point(218, 192);
            this.textBox_MaximumPriceFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MaximumPriceFilter.Name = "textBox_MaximumPriceFilter";
            this.textBox_MaximumPriceFilter.Size = new System.Drawing.Size(134, 23);
            this.textBox_MaximumPriceFilter.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.Location = new System.Drawing.Point(20, 248);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 19);
            this.label18.TabIndex = 12;
            this.label18.Text = "Maximum Salary :";
            // 
            // radioButton_Or
            // 
            this.radioButton_Or.AutoSize = true;
            this.radioButton_Or.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton_Or.Location = new System.Drawing.Point(158, 43);
            this.radioButton_Or.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_Or.Name = "radioButton_Or";
            this.radioButton_Or.Size = new System.Drawing.Size(44, 24);
            this.radioButton_Or.TabIndex = 8;
            this.radioButton_Or.TabStop = true;
            this.radioButton_Or.Text = "Or";
            this.radioButton_Or.UseVisualStyleBackColor = true;
            this.radioButton_Or.CheckedChanged += new System.EventHandler(this.radioButton_Or_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.Location = new System.Drawing.Point(20, 192);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "Maximum Price :";
            // 
            // radioButton_And
            // 
            this.radioButton_And.AutoSize = true;
            this.radioButton_And.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton_And.Location = new System.Drawing.Point(158, 78);
            this.radioButton_And.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_And.Name = "radioButton_And";
            this.radioButton_And.Size = new System.Drawing.Size(56, 24);
            this.radioButton_And.TabIndex = 9;
            this.radioButton_And.TabStop = true;
            this.radioButton_And.Text = "And";
            this.radioButton_And.UseVisualStyleBackColor = true;
            this.radioButton_And.CheckedChanged += new System.EventHandler(this.radioButton_And_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(20, 142);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 19);
            this.label16.TabIndex = 10;
            this.label16.Text = "Name :";
            // 
            // btn_RefreshPlayersInFilter
            // 
            this.btn_RefreshPlayersInFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshPlayersInFilter.Location = new System.Drawing.Point(560, 193);
            this.btn_RefreshPlayersInFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_RefreshPlayersInFilter.Name = "btn_RefreshPlayersInFilter";
            this.btn_RefreshPlayersInFilter.Size = new System.Drawing.Size(230, 56);
            this.btn_RefreshPlayersInFilter.TabIndex = 21;
            this.btn_RefreshPlayersInFilter.Text = "Refresh Players List";
            this.btn_RefreshPlayersInFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshPlayersInFilter.UseVisualStyleBackColor = true;
            this.btn_RefreshPlayersInFilter.Click += new System.EventHandler(this.btn_RefreshPlayersInFilter_Click);
            // 
            // dataGridView_PlayerForFiltering
            // 
            this.dataGridView_PlayerForFiltering.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PlayerForFiltering.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_PlayerForFiltering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PlayerForFiltering.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_PlayerForFiltering.Location = new System.Drawing.Point(54, 25);
            this.dataGridView_PlayerForFiltering.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_PlayerForFiltering.Name = "dataGridView_PlayerForFiltering";
            this.dataGridView_PlayerForFiltering.ReadOnly = true;
            this.dataGridView_PlayerForFiltering.RowHeadersVisible = false;
            this.dataGridView_PlayerForFiltering.RowHeadersWidth = 51;
            this.dataGridView_PlayerForFiltering.RowTemplate.Height = 24;
            this.dataGridView_PlayerForFiltering.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PlayerForFiltering.Size = new System.Drawing.Size(1257, 162);
            this.dataGridView_PlayerForFiltering.TabIndex = 0;
            // 
            // MainAppWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1376, 841);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainAppWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContractsDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsertTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teams)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Players)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PlayerForFiltering)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_Teams;
        private System.Windows.Forms.DataGridView dataGridView_Players;
        private System.Windows.Forms.Button btn_LoadTeams;
        private System.Windows.Forms.Button btn_LoadPlayers;
        private System.Windows.Forms.Button btn_CreateContract;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_PlayerForFiltering;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButton_And;
        private System.Windows.Forms.RadioButton radioButton_Or;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_MaximumPriceFilter;
        private System.Windows.Forms.TextBox textBox_MaximumSalaryFilter;
        private System.Windows.Forms.TextBox textBox_MinimumMatchesFilter;
        private System.Windows.Forms.TextBox textBox_MinimumGoalsFilter;
        private System.Windows.Forms.TextBox textBox_MinimumAssistsFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_MaximumAgeFilter;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_MinimumAgeFilter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_RefreshPlayersInFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_PlayerSalary;
        private System.Windows.Forms.TextBox textBox_PlayerAssists;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_PlayerGoals;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PlayerMatches;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_insertPlayer;
        private System.Windows.Forms.TextBox textBox_ProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DeleteContract;
        private System.Windows.Forms.Button btn_RefreshContracts;
        private System.Windows.Forms.DataGridView dataGridView_ContractsDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_TeamLeague;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_InsertTeam;
        private System.Windows.Forms.TextBox textBox_TeamNation;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_TeamName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePickerInsertPlayer;
        private System.Windows.Forms.PictureBox pictureBoxInsertTeam;
        private System.Windows.Forms.Button buttonInsertTeamImage;
        private System.Windows.Forms.Button btn_backUp;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_ClearFiltering;
    }
}

