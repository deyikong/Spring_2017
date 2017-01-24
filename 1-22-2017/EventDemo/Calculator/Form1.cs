using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        None
    }
    public partial class Form1 : Form
    {
        private Operator myOperator = Operator.None;
        private bool doneInputingNum = false;
        public Form1()
        {
            InitializeComponent(); //+-*/
            button16.Click += AddBtn_Click;//+
            button15.Click += SubtractBtn_Click;//-
            button14.Click += MultiplyBtn_Click;// /
            button13.Click += DivideBtn_Click;// *
        }
        // /
        private void DivideBtn_Click(object sender, EventArgs e)
        {
            myOperator = Operator.Divide;
        }
        // *
        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            myOperator = Operator.Multiply;
        }
        // -
        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            myOperator = Operator.Subtract;
        }
        //+
        private void AddBtn_Click(object sender, EventArgs e)
        {
            myOperator = Operator.Add;
        }

        //1, 2, 3...
        private void Number_Click(object sender, EventArgs e)
        {
            if (doneInputingNum)
                textBox1.Clear();
            Button tempBtn = (Button)sender;
            textBox1.Text += tempBtn.Text;
            doneInputingNum = false;
        }
        //+-*/
        private void AllOperator_Click(object sender, EventArgs e)
        {
            if (myOperator==Operator.None)
            {
                Calculator.FirstNum = Double.Parse(textBox1.Text);
               // firstNumThere = true;
            }
            else
            {
                Calculator.SecondNum = Double.Parse(textBox1.Text);
                switch (myOperator)
                {
                    case Operator.Add:
                        Calculator.FirstNum = Calculator.Add();
                        break;
                    case Operator.Subtract:
                        Calculator.FirstNum = Calculator.Subtract();
                        break;
                    case Operator.Multiply:
                        Calculator.FirstNum = Calculator.Multiply();
                        break;
                    case Operator.Divide:
                        Calculator.FirstNum = Calculator.Divide();
                        break;
                }
            }
            textBox1.Text = Calculator.FirstNum.ToString() ;
            doneInputingNum = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            myOperator = Operator.None;
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myOperator = Operator.None;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != ""&& textBox1.Text != ".")
                {
                    double tempNum = Double.Parse(textBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show("Input Number Only");
                textBox1.Clear();
            }
        }
    }
}
