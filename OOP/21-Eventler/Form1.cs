using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Eventler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Button Click");
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("ListBox1 Mouse Enter");
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("ListBox1 Mouse Leave");

        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Items.Add("ListBox1 Mouse Hover");

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("ListBox1 Mouse Click");

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("ListBox1 Mouse Downn");
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("ListBox1 Mouse Up");
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"ListBox1 Mouse Move X:{e.X.ToString()} Y:{e.Y.ToString()}");
        }
    }
}