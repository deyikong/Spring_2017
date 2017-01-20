using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        List<Homework> homework;

        internal List<Homework> Homework
        {
            get
            {
                return homework;
            }

            set
            {
                homework = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Homework = GenerateHomework();
            RefreshList();
        }

        public void RefreshList()
        {
            homeworkList.Items.Clear();
            foreach (Homework eachHomework in Homework)
            {
                homeworkList.Items.Add(eachHomework.Topic);
            }
        }

        private List<Homework> GenerateHomework()
        {
            return new List<Homework>
            {
                new Homework(0) { Topic = "Class"},
                new Homework(1) { Topic  = "Method"}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeworkUI hUI = new HomeworkUI(this);
            hUI.Show();
           
        }
    }
}
