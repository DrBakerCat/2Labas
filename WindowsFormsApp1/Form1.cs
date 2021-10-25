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
            listBox1.Font = new Font(FontFamily.GenericMonospace, listBox1.Font.Size);
        }

        public string PadBoth(string source, int length, char padChar)
        {
            int spaces = length - source.Length;
            int padLeft = spaces / 2 + source.Length;
            return source.PadLeft(padLeft, padChar).PadRight(length, padChar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int fakt = 0;
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);

                int length = 21;

                listBox1.Items.Clear();
                listBox1.Items.Add(PadBoth("FOR", (length * 2) + 3, '='));
                listBox1.Items.Add("|" + PadBoth("x", length, ' ') + "|" + PadBoth("y", length, ' ') + "|");
                listBox1.Items.Add(PadBoth("", (length * 2) + 3, '='));
                for (int i = x; i <= y; i++)
                {
                    if (i % 2 == 0)
                    {
                        fakt = i;
                        for (int m = i - 1; m >= 1; m--)
                        {
                            fakt = fakt * m;

                        }
                        listBox1.Items.Add("|" + PadBoth(Convert.ToString(i), length, ' ')  + "|" + PadBoth(Convert.ToString(fakt), length, ' ')  + "|");
                    }

                }
                
                listBox1.Items.Add(PadBoth("", (length * 2) + 3, '='));
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

