using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Yahtzee_Game
{
    public class Die
    {
        private int faceValue; // which side is showing
        private bool active = true;
        private Label label;
        private static Random random = new Random();
        private StreamReader rollFile;
        private static bool DEBUG;
        private int numFaces; //number of sides on die
        private const int SIX_SIDED = 6;
        private const int DEFAULT_FACE_VALUE = 1;


        public Die(Label label)
        {
            numFaces = 6;       
            
        }

        public int FaceValue
        {
            get
            {
                return faceValue;
            }
        }

        public bool Active //keep upper case
        {
            set
            {
                active = value;
            }
            get
            {
                return active;
            }
        }

        public int Roll()
        {
            faceValue = random.Next(numFaces) + 1;
            
            return faceValue;


        } // end Roll

        private void Load(Label label)
        {

        }
        

        
        
        

        


    }// end Class Die
}


   