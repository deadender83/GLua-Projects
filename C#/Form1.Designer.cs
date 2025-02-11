namespace StreetFighter
{
    partial class Form1
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
            this.playerOnelbl = new System.Windows.Forms.Label();
            this.player2lbl = new System.Windows.Forms.Label();
            this.player1HealthLabel = new System.Windows.Forms.Label();
            this.player2HealthLabel = new System.Windows.Forms.Label();
            this.kickbtn = new System.Windows.Forms.Button();
            this.SpeicalMoves = new System.Windows.Forms.ListBox();
            this.hadokenLabel = new System.Windows.Forms.Label();
            this.PlayersNamelbl = new System.Windows.Forms.Label();
            this.letter1 = new System.Windows.Forms.ComboBox();
            this.letter2 = new System.Windows.Forms.ComboBox();
            this.letter3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player2Box = new System.Windows.Forms.PictureBox();
            this.player1Box = new System.Windows.Forms.PictureBox();
            this.punchbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Box)).BeginInit();
            this.SuspendLayout();
            // 
            // playerOnelbl
            // 
            this.playerOnelbl.AutoSize = true;
            this.playerOnelbl.Location = new System.Drawing.Point(553, 71);
            this.playerOnelbl.Name = "playerOnelbl";
            this.playerOnelbl.Size = new System.Drawing.Size(74, 16);
            this.playerOnelbl.TabIndex = 2;
            this.playerOnelbl.Text = "Player One";
            // 
            // player2lbl
            // 
            this.player2lbl.AutoSize = true;
            this.player2lbl.Location = new System.Drawing.Point(774, 71);
            this.player2lbl.Name = "player2lbl";
            this.player2lbl.Size = new System.Drawing.Size(75, 16);
            this.player2lbl.TabIndex = 3;
            this.player2lbl.Text = "Player Two";
            // 
            // player1HealthLabel
            // 
            this.player1HealthLabel.AutoSize = true;
            this.player1HealthLabel.Location = new System.Drawing.Point(538, 248);
            this.player1HealthLabel.Name = "player1HealthLabel";
            this.player1HealthLabel.Size = new System.Drawing.Size(49, 16);
            this.player1HealthLabel.TabIndex = 4;
            this.player1HealthLabel.Text = "Health:";
            // 
            // player2HealthLabel
            // 
            this.player2HealthLabel.AutoSize = true;
            this.player2HealthLabel.Location = new System.Drawing.Point(774, 248);
            this.player2HealthLabel.Name = "player2HealthLabel";
            this.player2HealthLabel.Size = new System.Drawing.Size(49, 16);
            this.player2HealthLabel.TabIndex = 5;
            this.player2HealthLabel.Text = "Health:";
            // 
            // kickbtn
            // 
            this.kickbtn.Image = global::StreetFighter.Properties.Resources.Screenshot_2024_04_12_113447;
            this.kickbtn.Location = new System.Drawing.Point(635, 280);
            this.kickbtn.Name = "kickbtn";
            this.kickbtn.Size = new System.Drawing.Size(103, 96);
            this.kickbtn.TabIndex = 8;
            this.kickbtn.Text = "Kick";
            this.kickbtn.UseVisualStyleBackColor = true;
            this.kickbtn.Click += new System.EventHandler(this.kickbtn_Click);
            // 
            // SpeicalMoves
            // 
            this.SpeicalMoves.BackColor = System.Drawing.Color.Yellow;
            this.SpeicalMoves.FormattingEnabled = true;
            this.SpeicalMoves.ItemHeight = 16;
            this.SpeicalMoves.Items.AddRange(new object[] {
            "Seoi Nage",
            "Tomoe Nage",
            "Hadoken"});
            this.SpeicalMoves.Location = new System.Drawing.Point(331, 292);
            this.SpeicalMoves.Name = "SpeicalMoves";
            this.SpeicalMoves.Size = new System.Drawing.Size(120, 84);
            this.SpeicalMoves.TabIndex = 9;
            this.SpeicalMoves.Click += new System.EventHandler(this.SpeicalMoves_Click);
            // 
            // hadokenLabel
            // 
            this.hadokenLabel.AutoSize = true;
            this.hadokenLabel.Location = new System.Drawing.Point(294, 136);
            this.hadokenLabel.Name = "hadokenLabel";
            this.hadokenLabel.Size = new System.Drawing.Size(0, 16);
            this.hadokenLabel.TabIndex = 12;
            // 
            // PlayersNamelbl
            // 
            this.PlayersNamelbl.AutoSize = true;
            this.PlayersNamelbl.Location = new System.Drawing.Point(36, 16);
            this.PlayersNamelbl.Name = "PlayersNamelbl";
            this.PlayersNamelbl.Size = new System.Drawing.Size(112, 16);
            this.PlayersNamelbl.TabIndex = 13;
            this.PlayersNamelbl.Text = "Enter Your Name:";
            // 
            // letter1
            // 
            this.letter1.FormattingEnabled = true;
            this.letter1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letter1.Location = new System.Drawing.Point(39, 35);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(38, 24);
            this.letter1.TabIndex = 14;
            // 
            // letter2
            // 
            this.letter2.FormattingEnabled = true;
            this.letter2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letter2.Location = new System.Drawing.Point(83, 35);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(38, 24);
            this.letter2.TabIndex = 15;
            // 
            // letter3
            // 
            this.letter3.FormattingEnabled = true;
            this.letter3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letter3.Location = new System.Drawing.Point(127, 35);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(38, 24);
            this.letter3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "This Button Kicks The Enemy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "This Button Punchs The Enemy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "These Are Your Speical Attacks";
            // 
            // player2Box
            // 
            this.player2Box.Image = global::StreetFighter.Properties.Resources.Ken;
            this.player2Box.Location = new System.Drawing.Point(777, 90);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(100, 155);
            this.player2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Box.TabIndex = 11;
            this.player2Box.TabStop = false;
            // 
            // player1Box
            // 
            this.player1Box.Image = global::StreetFighter.Properties.Resources.Ryu;
            this.player1Box.Location = new System.Drawing.Point(541, 90);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(100, 155);
            this.player1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Box.TabIndex = 10;
            this.player1Box.TabStop = false;
            // 
            // punchbtn
            // 
            this.punchbtn.BackColor = System.Drawing.Color.Red;
            this.punchbtn.Image = global::StreetFighter.Properties.Resources.Screenshot_2024_04_12_113418;
            this.punchbtn.Location = new System.Drawing.Point(514, 282);
            this.punchbtn.Name = "punchbtn";
            this.punchbtn.Size = new System.Drawing.Size(93, 94);
            this.punchbtn.TabIndex = 6;
            this.punchbtn.Text = "Punch";
            this.punchbtn.UseVisualStyleBackColor = false;
            this.punchbtn.Click += new System.EventHandler(this.punchbtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(188, 35);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 20;
            this.submitbtn.Text = "submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(661, 16);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(102, 32);
            this.scorelbl.TabIndex = 21;
            this.scorelbl.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Press Any Move To Play Again";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.PlayersNamelbl);
            this.Controls.Add(this.hadokenLabel);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.SpeicalMoves);
            this.Controls.Add(this.kickbtn);
            this.Controls.Add(this.punchbtn);
            this.Controls.Add(this.player2HealthLabel);
            this.Controls.Add(this.player1HealthLabel);
            this.Controls.Add(this.player2lbl);
            this.Controls.Add(this.playerOnelbl);
            this.Name = "Form1";
            this.Text = "Street Fighter I";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerOnelbl;
        private System.Windows.Forms.Label player2lbl;
        private System.Windows.Forms.Label player1HealthLabel;
        private System.Windows.Forms.Label player2HealthLabel;
        private System.Windows.Forms.Button punchbtn;
        private System.Windows.Forms.Button kickbtn;
        private System.Windows.Forms.ListBox SpeicalMoves;
        private System.Windows.Forms.PictureBox player1Box;
        private System.Windows.Forms.PictureBox player2Box;
        private System.Windows.Forms.Label hadokenLabel;
        private System.Windows.Forms.Label PlayersNamelbl;
        private System.Windows.Forms.ComboBox letter1;
        private System.Windows.Forms.ComboBox letter2;
        private System.Windows.Forms.ComboBox letter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label label4;
    }
}

