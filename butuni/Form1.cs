using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butuni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] soroborno = { "অ ", "আ ", "ই ", "ঈ ", "উ ", "ঊ ", "ঋ ", " এ", "ঐ ", " ও"," ঔ" };
            showAllData(soroborno, 11); 
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] benjonborno = { "ক"," খ ","গ ","ঘ"," ঙ","চ"," ছ ","জ","ঝ","ঞ","ট","ঠ","ড","ঢ","ণ","ত","থ","দ","ধ","ন","প","ফ","ব","ভ","ম","য","র","ল","শ","ষ","স","হ","ড়","ঢ়","য়","ৎ"," ং ","ঃ"," ঁ"};
            showAllData(benjonborno, 39);
        }

        public void showAllData(String[] name,int loopTime)
        {
            for(int i =0; i < loopTime; i++)
            {
                MessageBox.Show(name[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] alphabet = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y", "Z" };
            showAllData(alphabet, 25);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                MessageBox.Show((i + 1).ToString());
            }
        }
    }
}
