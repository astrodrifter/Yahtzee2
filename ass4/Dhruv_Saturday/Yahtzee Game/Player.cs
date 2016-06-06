using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game
{
    class Player
    {
        private string name;
        private int combinationToDo;
        private Score[] scores;//array of scores of Score objects
        private int grandTotal;

        
        public Player(string name)//also array of labels?? Label[] label
        {
            this.name = name;

        }

        public string Name //keep upper case
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        } //end name property

        public void ScoreCombinations(ScoreType score, int[] array)//don't know if right input
        {

        }//dunno

        public int GrandTotal
        {
            set
            {
                grandTotal = value;
            }
            get
            {
                return grandTotal;
            }
        }
        
        public bool IsAvailable(ScoreType score)//don't know if right input
        {
            combinationToDo++;

            return false;
        }

        public void ShowScores()
        {

        }

        public bool IsFinished()
        {
            if(combinationToDo <= 13)
            {
                return false;
            } else { return true; }
        }

        public void Load()//array of labels??
        {

        }
    }
}
