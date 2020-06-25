using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ameenaMid2
{
    public class MyNumbers
    {
        private Random rand;

        public Random Rand
        {
            get
            {
                return rand;
            }
            set
            {
                rand = value;
            }
        }

        //constructor
        public MyNumbers()
        {
            this.Rand = new Random();
        }


        //get a random number from 1 to 48
        public int getRandomNumber()
        {
            return Rand.Next(1, 49);
        }

        //get another random number that is different from others
        public int getNumbers(int x)
        {
            int y = getRandomNumber();

            while (y == x)
            {
                y = getRandomNumber();
            }

            return y;
        }

    }//end of class
}//end of spacename
