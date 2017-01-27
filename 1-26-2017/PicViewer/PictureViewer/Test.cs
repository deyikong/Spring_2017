using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked New");
        }

        private void TestMethod(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Project");
        }
  
    }
}
