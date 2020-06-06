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


        string a = "95";
        string b2 = "96";
        string c = "97";
        string d2 = "98";
        string el = "99";
        string f = "01";
        string g = "02";
        string h = "03";

        private void button1_Click(object sender, EventArgs e)
        {
            bool running = true;
            richTextBox1.Text = "Running Key Generation Loop...";
            while (running == true)
            {
                int l2 = Convert.ToInt32(CreateInterger(5));
                int imdoingepicgamerint = new Random().Next(001,366);
                string rand = rd.Next(1,8).ToString();
                if(rand == "1")
                {
                    rand = a;
                }
                else if(rand == "2")
                {
                    rand = b2;
                }
                else if (rand == "3")
                {
                    rand = c;
                }
                else if (rand == "4")
                {
                    rand = d2;
                }
                else if (rand == "5")
                {
                    rand = el;
                }
                else if (rand == "6")
                {
                    rand = f;
                }
                else if (rand == "7")
                {
                    rand = g;
                }
                else if (rand == "8")
                {
                    rand = h;
                }
                string d = "-OEM-0";
                int l = rd.Next(1, 1000000000);
                l = Convert.ToInt32(l.ToString().Remove(6, l.ToString().Length - 6));
                string b = "0" + l.ToString();
                var sum = GetIntArray(l).Aggregate((temp, x) => temp + x);
                if (sum % 7 == 0)
                {
                    if (!l.ToString().EndsWith("0"))
                    {
                        if (!l.ToString().EndsWith("8"))
                        {
                            if (!l.ToString().EndsWith("9"))
                            {
                                bool flag = Convert.ToInt32(rand) % 4 == 0;
                                if (!flag && !Convert.ToBoolean(imdoingepicgamerint == 366))
                                {
                                    string flag2 = imdoingepicgamerint + rand;
                                    if (flag2.Length == 5)
                                    {
                                        richTextBox1.Text = imdoingepicgamerint + rand + d + l + "-" + l2;
                                        running = false;
                                    }
                                }
                                else
                                {
                                    imdoingepicgamerint = 366;
                                    string flag2 = imdoingepicgamerint + rand;
                                    if (flag2.Length == 5)
                                    {
                                        richTextBox1.Text = imdoingepicgamerint + rand + d + l + "-" + l2;
                                        running = false;
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello user this is made possible by adapting FlyTech's tutorial to c# so please support him.");

        }
    }
}