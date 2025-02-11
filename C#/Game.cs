using System;
using System.Windows.Forms;

namespace StreetFighterGame
{
    public partial class Game
    {
        private Fighter player1 { get; set; }
        private Fighter player2 { get; set; }


        public Fighter Player1
        {
            get { return player1; }
        }

        public Fighter Player2
        {
            get { return player2; }
        }
        public Game()
        {
            player1 = new Fighter("Player 1");
            player2 = new Fighter("Player 2");
        }

        public void Punch()
        {
            int damage = player1.PunchAttack();
            player2.TakeDamage(damage);
            player2.Player2Attacks();
        }

        public void Kick()
        {
            int damage = player1.KickAttack();
            player2.TakeDamage(damage);
            player2.Player2Attacks();
        }

        public void SpeicalAttack1()
        {
            int damage = player1.SpeicalAttack1();
            player2.TakeDamage(damage);
        }

        public void SpeicalAttack2()
        {
            int damage = player1.SpeicalAttack2();
            player2.TakeDamage(damage);
        }

        public void SpeicalAttack3()
        {
            int damage = player1.SpeicalAttack3();
            player2.TakeDamage(damage);
        }

        public void AttackPlayer2()
        {
            int damage = player2.PunchAttack();
            player1.TakeDamage(damage);
        }

        public bool IsPlayer1Defeated()
        {
            return player1.IsDefeated();
        }

        public bool IsPlayer2Defeated()
        {
            return player2.IsDefeated();
        }

        public void ResetGame()
        {
            player1 = new Fighter("Player 1");
            player2 = new Fighter("Player 2");
        }
        public void Player2Attacks()
        {
            int damage = player2.Player2Attacks();
            player1.TakeDamage(damage);
        }

    }
}
