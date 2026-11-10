namespace ProjectGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblround = new System.Windows.Forms.Label();
            this.gbavatars = new System.Windows.Forms.GroupBox();
            this.btnSetupPlayer2 = new System.Windows.Forms.Button();
            this.btnSetupPlayer1 = new System.Windows.Forms.Button();
            this.picAvatar4 = new System.Windows.Forms.PictureBox();
            this.picAvatar3 = new System.Windows.Forms.PictureBox();
            this.picAvatar2 = new System.Windows.Forms.PictureBox();
            this.picAvatar1 = new System.Windows.Forms.PictureBox();
            this.rbAvatar4 = new System.Windows.Forms.RadioButton();
            this.rbAvatar3 = new System.Windows.Forms.RadioButton();
            this.rbAvatar2 = new System.Windows.Forms.RadioButton();
            this.rbAvatar1 = new System.Windows.Forms.RadioButton();
            this.gbPlayer1score = new System.Windows.Forms.GroupBox();
            this.lblPlayer1Points = new System.Windows.Forms.Label();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.picdefaultPlayer1 = new System.Windows.Forms.PictureBox();
            this.gbPlayer2score = new System.Windows.Forms.GroupBox();
            this.lblPlayer2Points = new System.Windows.Forms.Label();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.picdefaultPlayer2 = new System.Windows.Forms.PictureBox();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.lstGameResults = new System.Windows.Forms.ListBox();
            this.gbInitializations = new System.Windows.Forms.GroupBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.numTotalRounds = new System.Windows.Forms.NumericUpDown();
            this.lblname2 = new System.Windows.Forms.Label();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblTotalrounds = new System.Windows.Forms.Label();
            this.lblgameName = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.lblteamname = new System.Windows.Forms.Label();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            this.gbavatars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).BeginInit();
            this.gbPlayer1score.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdefaultPlayer1)).BeginInit();
            this.gbPlayer2score.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdefaultPlayer2)).BeginInit();
            this.gbReport.SuspendLayout();
            this.gbInitializations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAction
            // 
            this.gbAction.BackColor = System.Drawing.Color.Transparent;
            this.gbAction.Controls.Add(this.lblCurrentRound);
            this.gbAction.Controls.Add(this.picDice);
            this.gbAction.Controls.Add(this.picDice2);
            this.gbAction.Controls.Add(this.btnRollDice);
            this.gbAction.Controls.Add(this.lblPlayerTurn);
            this.gbAction.Controls.Add(this.lblround);
            this.gbAction.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAction.ForeColor = System.Drawing.Color.White;
            this.gbAction.Location = new System.Drawing.Point(32, 283);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(329, 292);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.BackColor = System.Drawing.Color.Navy;
            this.lblCurrentRound.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRound.Location = new System.Drawing.Point(165, 55);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(19, 20);
            this.lblCurrentRound.TabIndex = 5;
            this.lblCurrentRound.Text = "0";
            // 
            // picDice
            // 
            this.picDice.BackColor = System.Drawing.Color.Transparent;
            this.picDice.Image = global::ProjectGame.Properties.Resources.dice1;
            this.picDice.Location = new System.Drawing.Point(94, 194);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(90, 90);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDice.TabIndex = 4;
            this.picDice.TabStop = false;
            this.picDice2.BackColor = System.Drawing.Color.Transparent;
            this.picDice2.Image = global::ProjectGame.Properties.Resources.dice1;
            this.picDice2.Location = new System.Drawing.Point(202, 194);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(90, 90);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDice2.TabIndex = 6;
            this.picDice2.TabStop = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRollDice.Location = new System.Drawing.Point(75, 147);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(119, 23);
            this.btnRollDice.TabIndex = 3;
            this.btnRollDice.Text = "Roll ";
            this.btnRollDice.UseVisualStyleBackColor = true;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlayerTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(65, 107);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(146, 21);
            this.lblPlayerTurn.TabIndex = 2;
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblround.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblround.Location = new System.Drawing.Point(85, 57);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(57, 21);
            this.lblround.TabIndex = 0;
            this.lblround.Text = "Round";
            // 
            // gbavatars
            // 
            this.gbavatars.BackColor = System.Drawing.Color.Transparent;
            this.gbavatars.Controls.Add(this.btnSetupPlayer2);
            this.gbavatars.Controls.Add(this.btnSetupPlayer1);
            this.gbavatars.Controls.Add(this.picAvatar4);
            this.gbavatars.Controls.Add(this.picAvatar3);
            this.gbavatars.Controls.Add(this.picAvatar2);
            this.gbavatars.Controls.Add(this.picAvatar1);
            this.gbavatars.Controls.Add(this.rbAvatar4);
            this.gbavatars.Controls.Add(this.rbAvatar3);
            this.gbavatars.Controls.Add(this.rbAvatar2);
            this.gbavatars.Controls.Add(this.rbAvatar1);
            this.gbavatars.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbavatars.ForeColor = System.Drawing.Color.White;
            this.gbavatars.Location = new System.Drawing.Point(389, 98);
            this.gbavatars.Name = "gbavatars";
            this.gbavatars.Size = new System.Drawing.Size(307, 383);
            this.gbavatars.TabIndex = 2;
            this.gbavatars.TabStop = false;
            this.gbavatars.Text = "Avatars";
            // 
            // btnSetupPlayer2
            // 
            this.btnSetupPlayer2.Enabled = false;
            this.btnSetupPlayer2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSetupPlayer2.Location = new System.Drawing.Point(34, 329);
            this.btnSetupPlayer2.Name = "btnSetupPlayer2";
            this.btnSetupPlayer2.Size = new System.Drawing.Size(223, 30);
            this.btnSetupPlayer2.TabIndex = 9;
            this.btnSetupPlayer2.TabStop = false;
            this.btnSetupPlayer2.Text = "Set Up Player 2";
            this.btnSetupPlayer2.UseVisualStyleBackColor = true;
            this.btnSetupPlayer2.Click += new System.EventHandler(this.btnSetupPlayer2_Click);
            // 
            // btnSetupPlayer1
            // 
            this.btnSetupPlayer1.Enabled = false;
            this.btnSetupPlayer1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSetupPlayer1.Location = new System.Drawing.Point(34, 264);
            this.btnSetupPlayer1.Name = "btnSetupPlayer1";
            this.btnSetupPlayer1.Size = new System.Drawing.Size(223, 33);
            this.btnSetupPlayer1.TabIndex = 8;
            this.btnSetupPlayer1.Text = "Set Up Player 1";
            this.btnSetupPlayer1.UseVisualStyleBackColor = true;
            this.btnSetupPlayer1.Click += new System.EventHandler(this.btnSetupPlayer1_Click);
            // 
            // picAvatar4
            // 
            this.picAvatar4.Image = global::ProjectGame.Properties.Resources.avatar4;
            this.picAvatar4.Location = new System.Drawing.Point(171, 169);
            this.picAvatar4.Name = "picAvatar4";
            this.picAvatar4.Size = new System.Drawing.Size(76, 78);
            this.picAvatar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar4.TabIndex = 7;
            this.picAvatar4.TabStop = false;
            // 
            // picAvatar3
            // 
            this.picAvatar3.Image = global::ProjectGame.Properties.Resources.avatar3;
            this.picAvatar3.Location = new System.Drawing.Point(171, 49);
            this.picAvatar3.Name = "picAvatar3";
            this.picAvatar3.Size = new System.Drawing.Size(76, 78);
            this.picAvatar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar3.TabIndex = 6;
            this.picAvatar3.TabStop = false;
            // 
            // picAvatar2
            // 
            this.picAvatar2.Image = global::ProjectGame.Properties.Resources.avatar2;
            this.picAvatar2.Location = new System.Drawing.Point(43, 169);
            this.picAvatar2.Name = "picAvatar2";
            this.picAvatar2.Size = new System.Drawing.Size(76, 78);
            this.picAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar2.TabIndex = 5;
            this.picAvatar2.TabStop = false;
            // 
            // picAvatar1
            // 
            this.picAvatar1.Image = global::ProjectGame.Properties.Resources.avatar1__1_;
            this.picAvatar1.Location = new System.Drawing.Point(43, 49);
            this.picAvatar1.Name = "picAvatar1";
            this.picAvatar1.Size = new System.Drawing.Size(76, 78);
            this.picAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar1.TabIndex = 4;
            this.picAvatar1.TabStop = false;
            this.picAvatar1.Click += new System.EventHandler(this.picAvatar1_Click);
            // 
            // rbAvatar4
            // 
            this.rbAvatar4.AutoSize = true;
            this.rbAvatar4.Location = new System.Drawing.Point(148, 196);
            this.rbAvatar4.Name = "rbAvatar4";
            this.rbAvatar4.Size = new System.Drawing.Size(17, 16);
            this.rbAvatar4.TabIndex = 3;
            this.rbAvatar4.TabStop = true;
            this.rbAvatar4.UseVisualStyleBackColor = true;
            // 
            // rbAvatar3
            // 
            this.rbAvatar3.AutoSize = true;
            this.rbAvatar3.Location = new System.Drawing.Point(148, 76);
            this.rbAvatar3.Name = "rbAvatar3";
            this.rbAvatar3.Size = new System.Drawing.Size(17, 16);
            this.rbAvatar3.TabIndex = 2;
            this.rbAvatar3.TabStop = true;
            this.rbAvatar3.UseVisualStyleBackColor = true;
            this.rbAvatar3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbAvatar2
            // 
            this.rbAvatar2.AutoSize = true;
            this.rbAvatar2.Location = new System.Drawing.Point(20, 198);
            this.rbAvatar2.Name = "rbAvatar2";
            this.rbAvatar2.Size = new System.Drawing.Size(17, 16);
            this.rbAvatar2.TabIndex = 1;
            this.rbAvatar2.TabStop = true;
            this.rbAvatar2.UseVisualStyleBackColor = true;
            // 
            // rbAvatar1
            // 
            this.rbAvatar1.AutoSize = true;
            this.rbAvatar1.Location = new System.Drawing.Point(20, 76);
            this.rbAvatar1.Name = "rbAvatar1";
            this.rbAvatar1.Size = new System.Drawing.Size(17, 16);
            this.rbAvatar1.TabIndex = 0;
            this.rbAvatar1.TabStop = true;
            this.rbAvatar1.UseVisualStyleBackColor = true;
            this.rbAvatar1.CheckedChanged += new System.EventHandler(this.rbavatar1_CheckedChanged);
            // 
            // gbPlayer1score
            // 
            this.gbPlayer1score.BackColor = System.Drawing.Color.Transparent;
            this.gbPlayer1score.Controls.Add(this.lblPlayer1Points);
            this.gbPlayer1score.Controls.Add(this.lblPoint1);
            this.gbPlayer1score.Controls.Add(this.picdefaultPlayer1);
            this.gbPlayer1score.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1score.ForeColor = System.Drawing.Color.White;
            this.gbPlayer1score.Location = new System.Drawing.Point(731, 102);
            this.gbPlayer1score.Name = "gbPlayer1score";
            this.gbPlayer1score.Size = new System.Drawing.Size(401, 180);
            this.gbPlayer1score.TabIndex = 3;
            this.gbPlayer1score.TabStop = false;
            this.gbPlayer1score.Text = "Player 1 Score";
            // 
            // lblPlayer1Points
            // 
            this.lblPlayer1Points.AutoSize = true;
            this.lblPlayer1Points.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Points.Location = new System.Drawing.Point(231, 79);
            this.lblPlayer1Points.Name = "lblPlayer1Points";
            this.lblPlayer1Points.Size = new System.Drawing.Size(49, 58);
            this.lblPlayer1Points.TabIndex = 2;
            this.lblPlayer1Points.Text = "0";
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Traditional Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.ForeColor = System.Drawing.Color.White;
            this.lblPoint1.Location = new System.Drawing.Point(222, 53);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(69, 26);
            this.lblPoint1.TabIndex = 1;
            this.lblPoint1.Text = "POINT";
            // 
            // picdefaultPlayer1
            // 
            this.picdefaultPlayer1.Image = global::ProjectGame.Properties.Resources.avatar_default;
            this.picdefaultPlayer1.Location = new System.Drawing.Point(30, 42);
            this.picdefaultPlayer1.Name = "picdefaultPlayer1";
            this.picdefaultPlayer1.Size = new System.Drawing.Size(100, 100);
            this.picdefaultPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdefaultPlayer1.TabIndex = 0;
            this.picdefaultPlayer1.TabStop = false;
            this.picdefaultPlayer1.Click += new System.EventHandler(this.picdefaultPlayer1_Click);
            // 
            // gbPlayer2score
            // 
            this.gbPlayer2score.BackColor = System.Drawing.Color.Transparent;
            this.gbPlayer2score.Controls.Add(this.lblPlayer2Points);
            this.gbPlayer2score.Controls.Add(this.lblPoint2);
            this.gbPlayer2score.Controls.Add(this.picdefaultPlayer2);
            this.gbPlayer2score.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer2score.ForeColor = System.Drawing.Color.White;
            this.gbPlayer2score.Location = new System.Drawing.Point(725, 318);
            this.gbPlayer2score.Name = "gbPlayer2score";
            this.gbPlayer2score.Size = new System.Drawing.Size(401, 163);
            this.gbPlayer2score.TabIndex = 4;
            this.gbPlayer2score.TabStop = false;
            this.gbPlayer2score.Text = "Player 2 Score";
            // 
            // lblPlayer2Points
            // 
            this.lblPlayer2Points.AutoSize = true;
            this.lblPlayer2Points.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Points.Location = new System.Drawing.Point(242, 65);
            this.lblPlayer2Points.Name = "lblPlayer2Points";
            this.lblPlayer2Points.Size = new System.Drawing.Size(49, 58);
            this.lblPlayer2Points.TabIndex = 3;
            this.lblPlayer2Points.Text = "0";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Font = new System.Drawing.Font("Traditional Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint2.ForeColor = System.Drawing.Color.White;
            this.lblPoint2.Location = new System.Drawing.Point(236, 39);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(69, 26);
            this.lblPoint2.TabIndex = 2;
            this.lblPoint2.Text = "POINT";
            // 
            // picdefaultPlayer2
            // 
            this.picdefaultPlayer2.Image = global::ProjectGame.Properties.Resources.avatar_default;
            this.picdefaultPlayer2.Location = new System.Drawing.Point(36, 46);
            this.picdefaultPlayer2.Name = "picdefaultPlayer2";
            this.picdefaultPlayer2.Size = new System.Drawing.Size(100, 100);
            this.picdefaultPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdefaultPlayer2.TabIndex = 1;
            this.picdefaultPlayer2.TabStop = false;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbReport.Controls.Add(this.lstGameResults);
            this.gbReport.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReport.ForeColor = System.Drawing.Color.White;
            this.gbReport.Location = new System.Drawing.Point(1162, 114);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(320, 367);
            this.gbReport.TabIndex = 5;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // lstGameResults
            // 
            this.lstGameResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstGameResults.Font = new System.Drawing.Font("Microsoft JhengHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGameResults.ForeColor = System.Drawing.Color.White;
            this.lstGameResults.FormattingEnabled = true;
            this.lstGameResults.ItemHeight = 17;
            this.lstGameResults.Location = new System.Drawing.Point(23, 53);
            this.lstGameResults.Name = "lstGameResults";
            this.lstGameResults.Size = new System.Drawing.Size(271, 276);
            this.lstGameResults.TabIndex = 7;
            // 
            // gbInitializations
            // 
            this.gbInitializations.BackColor = System.Drawing.Color.Transparent;
            this.gbInitializations.Controls.Add(this.txtPlayer2Name);
            this.gbInitializations.Controls.Add(this.txtPlayer1Name);
            this.gbInitializations.Controls.Add(this.numTotalRounds);
            this.gbInitializations.Controls.Add(this.lblname2);
            this.gbInitializations.Controls.Add(this.lblname1);
            this.gbInitializations.Controls.Add(this.lblTotalrounds);
            this.gbInitializations.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInitializations.ForeColor = System.Drawing.Color.AliceBlue;
            this.gbInitializations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbInitializations.Location = new System.Drawing.Point(32, 58);
            this.gbInitializations.Name = "gbInitializations";
            this.gbInitializations.Size = new System.Drawing.Size(329, 200);
            this.gbInitializations.TabIndex = 0;
            this.gbInitializations.TabStop = false;
            this.gbInitializations.Text = "Initializations";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPlayer2Name.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.txtPlayer2Name.Location = new System.Drawing.Point(167, 149);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(134, 27);
            this.txtPlayer2Name.TabIndex = 5;
            this.txtPlayer2Name.TextChanged += new System.EventHandler(this.txtPlayer2Name_TextChanged);
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPlayer1Name.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.txtPlayer1Name.Location = new System.Drawing.Point(167, 89);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(134, 27);
            this.txtPlayer1Name.TabIndex = 4;
            this.txtPlayer1Name.TextChanged += new System.EventHandler(this.txtPlayer1Name_TextChanged);
            // 
            // numTotalRounds
            // 
            this.numTotalRounds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numTotalRounds.Font = new System.Drawing.Font("Ravie", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalRounds.ForeColor = System.Drawing.Color.White;
            this.numTotalRounds.Location = new System.Drawing.Point(185, 40);
            this.numTotalRounds.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTotalRounds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTotalRounds.Name = "numTotalRounds";
            this.numTotalRounds.Size = new System.Drawing.Size(63, 23);
            this.numTotalRounds.TabIndex = 3;
            this.numTotalRounds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblname2
            // 
            this.lblname2.AutoSize = true;
            this.lblname2.BackColor = System.Drawing.Color.Transparent;
            this.lblname2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblname2.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblname2.Location = new System.Drawing.Point(20, 149);
            this.lblname2.Name = "lblname2";
            this.lblname2.Size = new System.Drawing.Size(116, 21);
            this.lblname2.TabIndex = 2;
            this.lblname2.Text = "Player 2 Name";
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.BackColor = System.Drawing.Color.Transparent;
            this.lblname1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblname1.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblname1.Location = new System.Drawing.Point(20, 95);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(116, 21);
            this.lblname1.TabIndex = 1;
            this.lblname1.Text = "Player 1 Name";
            // 
            // lblTotalrounds
            // 
            this.lblTotalrounds.AutoSize = true;
            this.lblTotalrounds.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalrounds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalrounds.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalrounds.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalrounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalrounds.Location = new System.Drawing.Point(27, 44);
            this.lblTotalrounds.Name = "lblTotalrounds";
            this.lblTotalrounds.Size = new System.Drawing.Size(112, 21);
            this.lblTotalrounds.TabIndex = 0;
            this.lblTotalrounds.Text = "Game Rounds";
            this.lblTotalrounds.Click += new System.EventHandler(this.lblrounds_Click);
            // 
            // lblgameName
            // 
            this.lblgameName.AutoSize = true;
            this.lblgameName.BackColor = System.Drawing.Color.Transparent;
            this.lblgameName.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameName.ForeColor = System.Drawing.Color.White;
            this.lblgameName.Location = new System.Drawing.Point(604, 22);
            this.lblgameName.Name = "lblgameName";
            this.lblgameName.Size = new System.Drawing.Size(257, 40);
            this.lblgameName.TabIndex = 6;
            this.lblgameName.Text = "Higher Luck";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResetAll.Location = new System.Drawing.Point(432, 498);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(204, 77);
            this.btnResetAll.TabIndex = 7;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStartGame.Location = new System.Drawing.Point(835, 498);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(198, 77);
            this.btnStartGame.TabIndex = 8;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnShowResults
            // 
            this.btnShowResults.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowResults.Location = new System.Drawing.Point(1216, 498);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(198, 77);
            this.btnShowResults.TabIndex = 9;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            // 
            // lblteamname
            // 
            this.lblteamname.AutoSize = true;
            this.lblteamname.BackColor = System.Drawing.Color.Transparent;
            this.lblteamname.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteamname.ForeColor = System.Drawing.Color.White;
            this.lblteamname.Location = new System.Drawing.Point(774, 62);
            this.lblteamname.Name = "lblteamname";
            this.lblteamname.Size = new System.Drawing.Size(259, 19);
            this.lblteamname.TabIndex = 10;
            this.lblteamname.Text = "Team : work hard not smart";
            this.lblteamname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjectGame.Properties.Resources.téléchargement;
            this.ClientSize = new System.Drawing.Size(1545, 648);
            this.Controls.Add(this.lblteamname);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.gbPlayer2score);
            this.Controls.Add(this.lblgameName);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbPlayer1score);
            this.Controls.Add(this.gbavatars);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbInitializations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            this.gbavatars.ResumeLayout(false);
            this.gbavatars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).EndInit();
            this.gbPlayer1score.ResumeLayout(false);
            this.gbPlayer1score.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdefaultPlayer1)).EndInit();
            this.gbPlayer2score.ResumeLayout(false);
            this.gbPlayer2score.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdefaultPlayer2)).EndInit();
            this.gbReport.ResumeLayout(false);
            this.gbInitializations.ResumeLayout(false);
            this.gbInitializations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInitializations;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.GroupBox gbavatars;
        private System.Windows.Forms.GroupBox gbPlayer1score;
        private System.Windows.Forms.GroupBox gbPlayer2score;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.NumericUpDown numTotalRounds;
        private System.Windows.Forms.Label lblname2;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label lblTotalrounds;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblgameName;
        private System.Windows.Forms.RadioButton rbAvatar4;
        private System.Windows.Forms.RadioButton rbAvatar3;
        private System.Windows.Forms.RadioButton rbAvatar2;
        private System.Windows.Forms.RadioButton rbAvatar1;
        private System.Windows.Forms.PictureBox picAvatar1;
        private System.Windows.Forms.PictureBox picAvatar2;
        private System.Windows.Forms.PictureBox picAvatar3;
        private System.Windows.Forms.PictureBox picAvatar4;
        private System.Windows.Forms.Button btnSetupPlayer2;
        private System.Windows.Forms.Button btnSetupPlayer1;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.PictureBox picdefaultPlayer1;
        private System.Windows.Forms.PictureBox picdefaultPlayer2;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Label lblPlayer1Points;
        private System.Windows.Forms.Label lblPlayer2Points;
        private System.Windows.Forms.ListBox lstGameResults;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label lblteamname;
        private System.Windows.Forms.Label lblCurrentRound;
    }
}

