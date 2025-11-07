using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnnumberofword_Click(object sender, EventArgs e)
        {
            string[] word = txtstring.Text.Split(' ');
            char key = Convert.ToChar(txtchar.Text);
            int contor = 0;
            foreach (string item in word)
            {
                foreach (char Char in item)
                {
                    if (Char == key)
                    {
                        contor++;
                        break;
                    }
                }
            }
            MessageBox.Show($"number of word {contor}");
        }

        private void btnchar_Click(object sender, EventArgs e)
        {
            string[] word = txtstring.Text.Split(' ');
            char key = Convert.ToChar(txtchar.Text);
            int contor = 0;
            foreach (string item in word)
            {
                foreach (char Char in item)
                {
                    if (Char == key)
                    {
                        contor++;

                    }
                }
            }
            MessageBox.Show($"number of char {contor}");
        }

        private void btnlistofword_Click(object sender, EventArgs e)
        {
            string[] word = txtstring.Text.Split(' ');
            char key = Convert.ToChar(txtchar.Text);
            bool check = false;
            for (int i = 0; i < word.Length; i++)
            {
                foreach (char Char in word[i])
                {
                    if (Char == key)
                    {
                        check = true;
                    }
                }
                if (check == false)
                    word[i] = "";
                check = false;
            }
            string temp = "";
            foreach (var item in word)
            {

                temp += " " + item;
            }
            MessageBox.Show(temp);

        }
        
    }
}
