using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = textBox1.Text.Split(',');
            foreach (string b in a)
            {
                int i = 0;
                while (i < richTextBox1.TextLength)
                {
                    int o = richTextBox1.Find(b, i, RichTextBoxFinds.None);
                    if (o != -1)
                    {
                        richTextBox1.SelectionStart = o;
                        richTextBox1.SelectionLength = b.Length;
                        richTextBox1.SelectionBackColor = Color.Red;
                    }
                    else
                    break;
                    i += o + b.Length;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
