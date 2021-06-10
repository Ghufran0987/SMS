using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementsSystem
{
    public partial class LOGIN : Sample
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        MainClass main = new MainClass();
        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            main.showwindow(hs,this,MDI.ActiveForm);

        }
    }
}
