using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W95_KeyGen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        static Random rd = new Random();
     

        internal static string CreateInterger(int intLength)
        {
            const string allowedChars = "1234567890";
            char[] chars = new char[intLength];

            for (int i = 0; i < intLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }


        int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          

            int l2 = Convert.ToInt32(CreateInterger(5));
            string d = "00195-OEM-0";
            int l = rd.Next(1, 1000000000);
            l = Convert.ToInt32(l.ToString().Remove(6, l.ToString().Length - 6));
            string b = "0" + l.ToString();
            var sum = GetIntArray(l).Aggregate((temp, x) => temp + x);
            if (sum % 7 == 0)
            {
                if (!l.ToString().EndsWith("0"))
                {
                    if(!l.ToString().EndsWith("8"))
                    {
                        if (!l.ToString().EndsWith("9"))
                        {
                            richTextBox1.Text = d + l + "-" + l2;
                        }
                    }
                  
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello user this is made possible by adapting FlyTech's tutorial to c# so please support him. the generate button will not generate on first click as the randomizer might generate numbers that cant be divided by 7 :(");
            
        }
    }
}
