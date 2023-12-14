using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Form1 : Form
    {
        bool czyjRuch = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button milkiLej = (Button)sender;
            milkiLej.Enabled = false;
            if (czyjRuch)
            {
                milkiLej.Text = "X";
            }
            else
            {
                milkiLej.Text = "O";
            }
            czyjRuch = !czyjRuch;
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "-")
            {
                MessageBox.Show("Wygrał " + button1.Text);
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "-")
            {
                MessageBox.Show("Wygrał " + button4.Text);
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "-")
            {
                MessageBox.Show("Wygrał " + button7.Text);
            }
        }
    }
}
