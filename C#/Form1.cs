using StreetFighterGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetFighter
{
    public partial class Form1 : Form
    {
        private Game game;
        private const string SpecialMove1Name = "Seoi Nage";
        private const string SpecialMove2Name = "Tomoe Nage";
        private const string SpecialMove3Name = "Hadoken";

        private int score;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
        }

        private void punchbtn_Click(object sender, EventArgs e)
        {
            game.Player2Attacks();
            game.Punch();
            player1HealthLabel.Text = game.Player1.Name + " Health: " + game.Player1.Health;
            player2HealthLabel.Text = game.Player2.Name + " Health: " + game.Player2.Health;
            player1Box.Image = Properties.Resources.Ryu;
            hadokenLabel.Text = " ";

            if (game.IsPlayer2Defeated())
            {
                MessageBox.Show(game.Player1.Name + " wins!");
                score++;
                scorelbl.Text = "Score: " + score;
                game.ResetGame();
            }
        }

        private void kickbtn_Click(object sender, EventArgs e)
        {
            game.Player2Attacks();
            game.Kick();
            player1HealthLabel.Text = game.Player1.Name + " Health: " + game.Player1.Health;
            player2HealthLabel.Text = game.Player2.Name + " Health: " + game.Player2.Health;
            player1Box.Image = Properties.Resources.Ryu;
            hadokenLabel.Text = " ";

            if (game.IsPlayer2Defeated())
            {
                MessageBox.Show(game.Player1.Name + " wins!");
                score++;
                scorelbl.Text = "Score: " + score;
                game.ResetGame();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            player1HealthLabel.Text = game.Player1.Name + " Health: " + game.Player1.Health;
            player2HealthLabel.Text = game.Player2.Name + " Health: " + game.Player2.Health;
        }

        private void SpeicalMoves_Click(object sender, EventArgs e)
        {
            int index = SpeicalMoves.SelectedIndex;
            string selectedMove = (string)SpeicalMoves.Items[index];

            if (selectedMove == SpecialMove1Name)
            {
                game.SpeicalAttack1();
                player1Box.Image = Properties.Resources.Ryu;
                hadokenLabel.Text = " ";
            }
            else if (selectedMove == SpecialMove2Name)
            {
                game.SpeicalAttack2();
                player1Box.Image = Properties.Resources.Ryu;
                hadokenLabel.Text = " ";
            }
            else if (selectedMove == SpecialMove3Name)
            {
                game.SpeicalAttack3();
                player1Box.Image = Properties.Resources.Hadoken;
                hadokenLabel.Text = "HADOKEN!!!";
            }
            else
            {
                player1Box.Image = Properties.Resources.Ryu;
                hadokenLabel.Text = " ";
            }

            player2HealthLabel.Text = game.Player2.Name + " Health: " + game.Player2.Health;

            if (game.IsPlayer2Defeated())
            {
                MessageBox.Show(game.Player1.Name + " wins!");
                score++;
                scorelbl.Text = "Score: " + score;
                game.ResetGame();
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

            string letter1Text = letter1.Text;
            string letter2Text = letter2.Text;
            string letter3Text = letter3.Text;

            letter1.Text.Trim();
            letter2.Text.Trim();
            letter3.Text.Trim();

            string combinedLetters = letter1Text + letter2Text + letter3Text;
            string join = String.Join(" ", combinedLetters);

            MessageBox.Show("Welcome " + join + " To Street Figther I");

            playerOnelbl.Text = join;





        }
    }
}

