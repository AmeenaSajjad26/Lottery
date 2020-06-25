using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ameenaMid2
{
    public partial class Form1 : Form
    {
        //array of lottery random numbers
        public int[] numbersArray = new int[6];

        //object of class MyNumbers
        MyNumbers number = new MyNumbers();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //if (e.key == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //this.Close();
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (e.key == Keys.Enter)
            {
                numbersArray[0] = number.getRandomNumber();
                numbersArray[1] = number.getRandomNumber();
                numbersArray[2] = number.getRandomNumber();
                numbersArray[3] = number.getRandomNumber();
                numbersArray[4] = number.getRandomNumber();
                numbersArray[5] = number.getRandomNumber();

                //sort this array 
                Array.Sort(numbersArray);

                //call function to avoid duplications
                noDuplicate();

                //sort this array 
                Array.Sort(numbersArray);

                textBox2.Text = concatenation();
            }
        }

        public void noDuplicate()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbersArray[i] == numbersArray[j])
                        numbersArray[i] = number.getNumbers(j);//make a new one
                }
            }
        }
        public string concatenation()
        {
            return Convert.ToString(numbersArray[0]) + "  " + Convert.ToString(numbersArray[1]) + "  " + Convert.ToString(numbersArray[2]) + "  " +
                Convert.ToString(numbersArray[3]) + "  " + Convert.ToString(numbersArray[4]) + "  " + Convert.ToString(numbersArray[5]);

        }


    }//end of class
}//end of spacename
