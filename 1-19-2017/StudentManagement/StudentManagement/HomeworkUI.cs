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
    public partial class HomeworkUI : Form
    {
        Homework newHomework;
        Form1 form;
        public HomeworkUI(Form1 parentForm)
        {
            InitializeComponent();
            form = parentForm;
        }

        internal Homework NewHomework
        {
            get
            {
                return newHomework;
            }

            set
            {
                newHomework = value;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            newHomework = new Homework(0) { Topic = topicBox.Text };
            form.Homework.Add(NewHomework);
            form.RefreshList();
            this.Close();
        }
    }
}
