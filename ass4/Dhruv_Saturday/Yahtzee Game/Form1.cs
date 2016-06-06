using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {

    public partial class Yahtzee_Form : Form {

        static Game game;//= new Game()
        Label[] die = new Label[5];
        Button[] scoreButtons = new Button[16];
        Label[] scoreTotals = new Label[19];
        CheckBox[] checkBoxes = new CheckBox[5];
        ScoreType[] full = new ScoreType[19];
        int numRolls = 0;
        int initial = 1;
        bool play = true;
        int dies;
        int dies1;
        int dies2;
        int dies3;
        int dies4;



        public Yahtzee_Form() {
            InitializeComponent();
            DisableRollButton();
            DisableAndClearCheckBoxes();
            //ScoreType[] empty = new ScoreType[19];
            //for(int i = 0 ; i < 19;  i++)
            //{
            //    empty[i] = 0;
            //}
            //empty[0] = (ScoreType)1;            
            // //

            // **FIXED ALTERNATIVE CODE BELOW

            for (int i = 0; i < 19; i++)
            {
                this.DisableScoreButton((ScoreType)i);
            }

            //button1.Enabled = false;
            //button8.Enabled = false;//without this 4 of a kind is still enabled for some reason;


        }

        private void InitializeLabelsAndButtons()
        {
            die[0] = die1;
            die[1] = die2;
            die[2] = die3;
            die[3] = die4;
            die[5] = die5;

            scoreButtons[0] = button1;
            scoreButtons[1] = button2;
            scoreButtons[2] = button3;
            scoreButtons[3] = button4;
            scoreButtons[4] = button5;
            scoreButtons[5] = button6;
            scoreButtons[6] = button7;
            scoreButtons[7] = button8;
            scoreButtons[8] = button9;
            scoreButtons[9] = button10;
            scoreButtons[10] = button11;
            scoreButtons[11] = button12;
            scoreButtons[12] = button13;

            scoreTotals[0] = scoreLabel1;
            scoreTotals[1] = scoreLabel2;
            scoreTotals[2] = scoreLabel3;
            scoreTotals[3] = scoreLabel4;
            scoreTotals[4] = scoreLabel5;
            scoreTotals[5] = scoreLabel6;
            scoreTotals[6] = scoreLabel7;
            scoreTotals[7] = scoreLabel8;
            scoreTotals[8] = scoreLabel9;
            scoreTotals[9] = scoreLabel10;
            scoreTotals[10] = scoreLabel11;
            scoreTotals[11] = scoreLabel12;
            scoreTotals[12] = scoreLabel13;
            scoreTotals[13] = subTotal;
            scoreTotals[14] = bonusPoints;
            scoreTotals[15] = upperTotal;
            scoreTotals[16] = yahtzeeBonus;
            scoreTotals[17] = lowerTotal;
            scoreTotals[18] = grandTotal;

            checkBoxes[0] = checkDie1;
            checkBoxes[1] = checkDie2;
            checkBoxes[2] = checkDie3;
            checkBoxes[3] = checkDie4;
            checkBoxes[4] = checkDie5;



        }
       
        public Label[] GetDice()// return array of label FIX: NO NEED FOR PARAMETERS
        {
            return die;
        }

        public Label[] GetScoreLabels()// return array of label Correct
        {
            return scoreTotals;
        }

        public void ShowPlayerName(string name)// string name Correct
        {
            playerName.Text = name;
        }

        void EnableRollButton() // Correct
        {
            rollButton.Enabled = true;
        }

        void DisableRollButton() // Correct
        {
            rollButton.Enabled = false;
        }

        void EnableCheckBoxes() // Correct
        {
            checkDie1.Enabled = true;
            checkDie2.Enabled = true;
            checkDie3.Enabled = true;
            checkDie4.Enabled = true;
            checkDie5.Enabled = true;
        }

        void DisableAndClearCheckBoxes() // Correct
        {
            checkDie1.Enabled = false;
            checkDie1.Checked = false;

            checkDie2.Enabled = false;
            checkDie2.Checked = false;

            checkDie3.Enabled = false;
            checkDie3.Checked = false;

            checkDie4.Enabled = false;
            checkDie4.Checked = false;

            checkDie5.Enabled = false;
            checkDie5.Checked = false;
        }

        void EnableScoreButton(ScoreType combo)//ScoreType combo FIXED: DID NOT NEED AN ARRAY OF ScoreType
        {
            //Temperature[] combo = new Temperature[] { Temperature.Cold, 0 };
            //enablescorebutton(combo)


            if (ScoreType.Ones == combo) //may run no matter what
            {
                button1.Enabled = true;
            }

            if (ScoreType.Twos == combo)
            {
                button2.Enabled = true;
            }

            if (ScoreType.Threes == combo)
            {
                button3.Enabled = true;
            }

            if (ScoreType.Fours == combo)
            {
                button4.Enabled = true;
            }

            if (ScoreType.Fives == combo)
            {
                button5.Enabled = true;
            }

            if (ScoreType.Sixes == combo)
            {
                button6.Enabled = true;
            }

            if (ScoreType.ThreeOfAKind == combo)
            {
                button7.Enabled = true;
            }

            if (ScoreType.FourOfAKind == combo)
            {
                button8.Enabled = true;
            }

            if (ScoreType.FullHouse == combo)
            {
                button9.Enabled = true;
            }

            if (ScoreType.SmallStraight == combo)
            {
                button10.Enabled = true;
            }

            if (ScoreType.LargeStraight == combo)
            {
                button11.Enabled = true;
            }

            if (ScoreType.Chance == combo)
            {
                button12.Enabled = true;
            }

            if (ScoreType.Yahtzee == combo)
            {
                button13.Enabled = true;
            }

            if (ScoreType.SubTotal == combo)
            {
                subTotal.Enabled = true;
            }

            if (ScoreType.BonusFor63Plus == combo)
            {
                bonusPoints.Enabled = true;
            }

            if (ScoreType.YahtzeeBonus == combo)
            {
                yahtzeeBonus.Enabled = true;
            }

            if (ScoreType.SectionATotal == combo)
            {
                upperTotal.Enabled = true;
            }

            if (ScoreType.SectionBTotal == combo)
            {
                lowerTotal.Enabled = true;
            }

            if (ScoreType.GrandTotal == combo)
            {
                grandTotal.Enabled = true;
            }

        }

        void DisableScoreButton(ScoreType combo)//ScoreType combo FIXED: DID NOT NEED AN ARRAY OF ScoreType
        {
            //Temperature[] combo = new Temperature[] { Temperature.Cold, 0 };
            //enablescorebutton(combo)


            if (ScoreType.Ones == combo) //may run no matter what
            {
                button1.Enabled = false;
            }

            if (ScoreType.Twos == combo)
            {
                button2.Enabled = false;
            }

            if (ScoreType.Threes == combo)
            {
                button3.Enabled = false;
            }

            if (ScoreType.Fours == combo)
            {
                button4.Enabled = false;
            }

            if (ScoreType.Fives == combo)
            {
                button5.Enabled = false;
            }

            if (ScoreType.Sixes == combo)
            {
                button6.Enabled = false;
            }

            if (ScoreType.ThreeOfAKind == combo)
            {
                button7.Enabled = false;
            }

            if (ScoreType.FourOfAKind == combo)
            {
                button8.Enabled = false;
            }

            if (ScoreType.FullHouse == combo)
            {
                button9.Enabled = false;
            }

            if (ScoreType.SmallStraight == combo)
            {
                button10.Enabled = false;
            }

            if (ScoreType.LargeStraight == combo)
            {
                button11.Enabled = false;
            }

            if (ScoreType.Chance == combo)
            {
                button12.Enabled = false;
            }

            if (ScoreType.Yahtzee == combo)
            {
                button13.Enabled = false;
            }

            if (ScoreType.SubTotal == combo)
            {
                subTotal.Enabled = false;
            }

            if (ScoreType.BonusFor63Plus == combo)
            {
                bonusPoints.Enabled = false;
            }

            if (ScoreType.YahtzeeBonus == combo)
            {
                yahtzeeBonus.Enabled = false;
            }

            if (ScoreType.SectionATotal == combo)
            {
                upperTotal.Enabled = false;
            }

            if (ScoreType.SectionBTotal == combo)
            {
                lowerTotal.Enabled = false;
            }

            if (ScoreType.GrandTotal == combo)
            {
                grandTotal.Enabled = false;
            }

        }

        void CheckCheckBox(int index)//int index
        {
            checkBoxes[index].Checked = true;

        }

        void ShowMessage(string message)//string message
        {
            messageLabel.Text = message;
        }

        void ShowOkButton()
        {

        }

        void StartNewGame()
        {
            game = new Game(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAndClearCheckBoxes();
            StartNewGame();
            messageLabel.Text = "Roll 1";
            playerName.Text = "Player 1";            
            EnableRollButton();
            numRolls = 1;
            game.init();

            for (int i = 0; i < 19; i++)
            {
                this.DisableScoreButton((ScoreType)i);
            }

            button8.Enabled = false;//without this 4 of a kind is still enabled for some reason;

        }
        private void initi()
        {
            for (int i = 0; i < 19; i++)
            {
                full[i] = (ScoreType)i;
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            
            if (initial == 1)
            {               
                initi();
                for (int i = 0; i < 19; i++)
                {
                    this.EnableScoreButton((ScoreType)i);
                }
                initial++;
            }

            game.RollDice(out dies, out dies1, out dies2,out dies3, out dies4);
            
            die1.Text = dies.ToString();
            die2.Text = dies1.ToString();
            die3.Text = dies2.ToString();
            die4.Text = dies3.ToString();
            die5.Text = dies4.ToString();

            
            EnableCheckBoxes();

            if (numRolls == 1 || numRolls == 2)
            {
                int roll = numRolls + 1;
                messageLabel.Text = "Roll " + roll + " or choose a combination to score";
                
            }else if(numRolls == 3)
            {
                messageLabel.Text = "Choose a combination to score";
                rollButton.Enabled = false;
            }
            numRolls++;
        }

        private void checkDie1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDie1.Checked)
            {
                game.HoldDie(0);
            }
            if(!checkDie1.Checked)
            {
                game.RealeaseDie(0);
            }
        }

        private void checkDie2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDie2.Checked)
            {
                game.HoldDie(1);
            }
            if (!checkDie2.Checked)
            {
                game.RealeaseDie(1);
            }
        }

        private void checkDie3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDie3.Checked)
            {
                game.HoldDie(2);
            }
            if (!checkDie3.Checked)
            {
                game.RealeaseDie(2);
            }
        }

        private void checkDie4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDie4.Checked)
            {
                game.HoldDie(3);
                //disable dice
            }
            if (!checkDie4.Checked)
            {
                game.RealeaseDie(3);
            }
        }

        private void checkDie5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDie5.Checked)
            {
                game.HoldDie(4);
            }
            if (!checkDie5.Checked)
            {
                game.RealeaseDie(4);
            }
        }

        private void next(bool on)
        {
            play = !play;
            if (on)
            {
                System.Windows.Forms.MessageBox.Show("Next Turn");
                initial = 1;
                numRolls = 1;
                on = false;
                DisableAndClearCheckBoxes();
                messageLabel.Text = "Roll 1";
               /* if (!play)
                {
                    playerName.Text = "Player 2";
                }
                else
                {
                    playerName.Text = "Player 1";
                }*/
                
                EnableRollButton();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // game.ScoreCombination();
                               
            DisableScoreButton((ScoreType)1);
            bool on = game.ScoreCombination(full[0]);
            next(on);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)2);

            bool on = game.ScoreCombination(full[1]);
            next(on);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)3);
            bool on = game.ScoreCombination(full[2]);
            next(on);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)4);
            bool on = game.ScoreCombination(full[3]);
            next(on);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)5);
            bool on = game.ScoreCombination(full[4]);
            next(on);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)6);
            bool on = game.ScoreCombination(full[5]);
            next(on);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)7);
            bool on = game.ScoreCombination(full[9]);
            next(on);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)8);
            bool on = game.ScoreCombination(full[10]);
            next(on);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)9);
            bool on = game.ScoreCombination(full[11]);
            next(on);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)10);
            bool on = game.ScoreCombination(full[12]);
            next(on);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)11);
            bool on = game.ScoreCombination(full[13]);
            next(on);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)12);
            bool on = game.ScoreCombination(full[14]);
            next(on);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DisableScoreButton((ScoreType)13);
            bool on = game.ScoreCombination(full[15]);
            next(on);
        }
    }

}



