using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game
{
    class Score
    {
        private int points;//point for that scoring combination
        private Label label;//label for that score
        protected bool done;// whether or not the score has been selected

        public Score(Label l)//don't know if right input, IT IS BUT NO DEFINITION LOOK BELOW
        {
            // APPLY l to label
            this.label = l;
        }

        public int Points
        {
            set
            {
                points = value;
            }
            get
            {
                return points;
            }
        }
        
        public bool Done
        {
           
            get
            {
                return done;
            }
        }

        public void ShowScore()//??
        {

            // Display score on GUI object (label), and if score is < 0 display nothing
            if (points > 0)
            {
                label.Text = points.ToString();
            } else
            {
                label.Text = "";
            }
        }

        public void Load(Label [] Labels)//don't know if right input
        {

        }
    }
}
