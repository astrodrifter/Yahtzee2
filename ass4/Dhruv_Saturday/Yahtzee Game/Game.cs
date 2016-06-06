using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Yahtzee_Game {

    public enum ScoreType {
        Ones, Twos, Threes, Fours, Fives, Sixes,
        SubTotal, BonusFor63Plus, SectionATotal,
        ThreeOfAKind, FourOfAKind, FullHouse,
        SmallStraight, LargeStraight, Chance, Yahtzee,
        YahtzeeBonus, SectionBTotal, GrandTotal
    }

    class Game {

        //page 2 0f Part D
        //private Player[] players = new Player[2];         // replaced this with next rows
        private BindingList<Player> players;
        private BindingList<Player> Players {
            get {
                return players;
            }
        }



        private int currentPlayerIndex;//whos turn has to loop with amount of players
        private Player currentPlayer;
        private Die[] dice = new Die[5];
        
        
        private int playersFinished; //finished all scores then game is done
        private int numRolls = 0; //finished all rolls turn done
        private Yahtzee_Form form;
        private Label[] dieLabels = new Label[5];//have to put dielabels in
        

        public Game(Yahtzee_Form form)//dont get what to put in here
        {
            //players[0] = new Player("Player 1");  
            //players[1] = new Player("Player 2");
            players = new BindingList<Player>(); // to instatiate players -- page 2 Part D
        }

        public void NextTurn()
        {
            if (currentPlayerIndex == 1)
            {
                       
            }
}

        public void init()
        {
            for (int i = 0; i < 5; i++)
            {
                dieLabels[i] = new Label();
            }


            for (int i = 0; i < 5; i++)
            {
                dice[i] = new Die(dieLabels[i]);

            }

        }

        public void RollDice(out int dies, out int dies1, out int dies2, out int dies3, out int dies4)
        {
               

            if (dice[0].Active)
            {
                dies = dice[0].Roll();

            }else
            {
                dies = dice[0].FaceValue;
            }

            if (dice[1].Active)
            {
                dies1 = dice[1].Roll();
                
            }else
            {
                dies1 = dice[1].FaceValue;
            }

            if (dice[2].Active)
            {
                dies2 = dice[2].Roll();
            }else
            {
                dies2 = dice[2].FaceValue;
            }

            if (dice[3].Active)
            {
                dies3 = dice[3].Roll();
            }else
            {
                dies3 = dice[3].FaceValue;
            }

            if (dice[4].Active)
            {
                dies4 = dice[4].Roll();
            }else
            {
                dies4= dice[4].FaceValue;
            }

            numRolls++;

        }

        public void HoldDie(int dieIndex)
        {
            dice[dieIndex].Active = false;            
            
        }

        public void RealeaseDie(int dieIndex)
        {

            dice[dieIndex].Active = true;
        }

        public bool ScoreCombination(ScoreType scores)//don't know if right input
        {

                playersFinished++;
                currentPlayerIndex++;
                
                //currentPlayer.IsAvailable(scores);
                return true;
                
             
        }

        public static Game Load()//don't get what to put
        {
            return null;
        }

        public void Save()
        {

        }

        

    }
}
