using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //Reiksmes
            int x; //intervalo pradzia
            int y; //intervalo pabaiga
            int fakt = 0;
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                resultbox.Text = "Skaiciai";
            }
            else
            {
                x = Convert.ToInt32(textBox1.Text); //reiksmiu priskyrimas
                y = Convert.ToInt32(textBox2.Text); 
                //Kaip bus viskas vaizduojama Darau su FOR 
                listBox1.Items.Clear();
                listBox1.Items.Add("=======FOR=======");
                listBox1.Items.Add("|   x   |   y   |");
                listBox1.Items.Add("=================");
                for (int i = x; i <= y; i++)
                {
                    //Faktorialas
                    if (i % 2 == 0)
                    {
                        fakt = i;
                        for (int m = i - 1; m >= 1; m--)
                        {
                            fakt = fakt * m;

                        }
                        listBox1.Items.Add("|   " + Convert.ToString(i) + "   |   " + Convert.ToString(fakt) + "   |");
                    }

                }
                
                listBox1.Items.Add("=================");
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

