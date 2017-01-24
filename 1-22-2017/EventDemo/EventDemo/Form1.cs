using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class PlaygroundForm : Form
    {
        public PlaygroundForm()
        {
            InitializeComponent();
            //button1.Click += button1_Click;
           
        }

        private void Button1_Click_ChangeSize(object sender, EventArgs e)
        {
            button1.Size = new Size(100, 100);
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Text = "I'm alive";
        }

        private void TextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = button1.BackColor;
        }

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void Button1_Click_ChangeColor(object sender, EventArgs e)
        {
            button1.BackColor = Color.Pink;
            button1.Text += "Click me again";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helloLbl.Text = "hello ware hello world";
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "Monday";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "Tuesday";
            }
        }
    }
}
