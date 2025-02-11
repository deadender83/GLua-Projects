using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    internal class Cards
    {
        private PictureBox firstCardPictureBox;
        private PictureBox secondCardPictureBox;

        public Cards(PictureBox newFirstCardPictureBox , PictureBox newSecondCardPictureBox)
        {
            firstCardPictureBox = newFirstCardPictureBox;
            secondCardPictureBox = newSecondCardPictureBox;
        }


        public void changePictureBox()
        {
            Random random = new Random();
            int firstRandomCard = random.Next(1, 15);
            int firstRandomSuit = random.Next(1, 5);

            int secondRandomCard = random.Next(1, 15);
            int secondRandomSuit = random.Next(1, 5);

            int card = firstRandomCard;
            int card2 = secondRandomCard;

            const int Ace = 1;
            const int Jack = 11;
            const int Queen = 12;
            const int King = 13;

            const int Two = 2;
            const int Three = 3;
            const int Four = 4;
            const int Five = 5;
            const int Six = 6;
            const int Seven = 7;
            const int Eight = 8;
            const int Nine = 9;
            const int Ten = 10;

            switch (card)
            {
                case Ace:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_clubs;
                    }
                    break;

                case King:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_clubs;
                    }
                    break;

                case Queen:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_clubs;
                    }
                    break;

                case Jack:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_clubs;
                    }
                    break;

                case Two:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_clubs;
                    }
                    break;

                case Three:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_clubs;
                    }
                    break;

                case Four:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_clubs;
                    }
                    break;

                case Five:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_clubs;
                    }
                    break;

                case Six:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_clubs;
                    }
                    break;

                case Seven:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_clubs;
                    }
                    break;

                case Eight:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_clubs;
                    }
                    break;

                case Nine:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_clubs;
                    }
                    break;

                case Ten:
                    if (firstRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_hearts;
                    }
                    else if (firstRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_diamonds;
                    }
                    else if (firstRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_spades;
                    }
                    else if (firstRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_clubs;
                    }
                    break;
            }
            switch (card2)
            {
                case Ace:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.ace_of_clubs;
                    }
                    break;

                case King:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.king_of_clubs;
                    }
                    break;

                case Queen:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.queen_of_clubs;
                    }
                    break;

                case Jack:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources.jack_of_clubs;
                    }
                    break;

                case Two:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._2_of_clubs;
                    }
                    break;

                case Three:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._3_of_clubs;
                    }
                    break;

                case Four:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._4_of_clubs;
                    }
                    break;

                case Five:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._5_of_clubs;
                    }
                    break;

                case Six:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._6_of_clubs;
                    }
                    break;

                case Seven:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._7_of_clubs;
                    }
                    break;

                case Eight:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._8_of_clubs;
                    }
                    break;

                case Nine:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._9_of_clubs;
                    }
                    break;

                case Ten:
                    if (secondRandomSuit == 1)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        firstCardPictureBox.Image = Properties.Resources._10_of_clubs;
                    }
                    break;
            }
                       switch (card2)
            {
                case Ace:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources.ace_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources.ace_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources.ace_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources.ace_of_clubs;
                    }
                    break;

                case King:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources.king_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources.king_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources.king_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources.king_of_clubs;
                    }
                    break;

                case Queen:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources.queen_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources.queen_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources.queen_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources.queen_of_clubs;
                    }
                    break;

                case Jack:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources.jack_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources.jack_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources.jack_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources.jack_of_clubs;
                    }
                    break;

                case Two:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._2_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._2_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._2_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._2_of_clubs;
                    }
                    break;

                case Three:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._3_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._3_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._3_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._3_of_clubs;
                    }
                    break;

                case Four:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._4_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._4_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._4_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._4_of_clubs;
                    }
                    break;

                case Five:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._5_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._5_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._5_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._5_of_clubs;
                    }
                    break;

                case Six:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._6_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._6_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._6_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._6_of_clubs;
                    }
                    break;

                case Seven:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._7_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._7_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._7_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._7_of_clubs;
                    }
                    break;

                case Eight:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._8_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._8_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._8_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._8_of_clubs;
                    }
                    break;

                case Nine:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._9_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._9_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._9_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._9_of_clubs;
                    }
                    break;

                case Ten:
                    if (secondRandomSuit == 1)
                    {
                        secondCardPictureBox.Image = Properties.Resources._10_of_hearts;
                    }
                    else if (secondRandomSuit == 2)
                    {
                        secondCardPictureBox.Image = Properties.Resources._10_of_diamonds;
                    }
                    else if (secondRandomSuit == 3)
                    {
                        secondCardPictureBox.Image = Properties.Resources._10_of_spades;
                    }
                    else if (secondRandomSuit == 4)
                    {
                        secondCardPictureBox.Image = Properties.Resources._10_of_clubs;
                    }
                    break;
            }

        }
    }
}
