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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        MainClass mc = new MainClass();

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            mc.showwindow(st,this,MDI.ActiveForm);

        }

        private void classbtn_Click(object sender, EventArgs e)
        {
            Classes cl = new Classes();
            mc.showwindow(cl,this,MDI.ActiveForm);

        }

        private void sectionbtn_Click(object sender, EventArgs e)
        {
            Sections sc = new Sections();
            mc.showwindow(sc,this,MDI.ActiveForm);

        }

        private void studentsbtn_Click(object sender, EventArgs e)
        {
            Students sd = new Students();
            mc.showwindow(sd,this,MDI.ActiveForm);

        }

        private void feebtn_Click(object sender, EventArgs e)
        {
            FeeVoucher fv = new FeeVoucher();
            mc.showwindow(fv, this, MDI.ActiveForm);

        }

        private void timetablebtn_Click(object sender, EventArgs e)
        {
            TimeTable tb = new TimeTable();
            mc.showwindow(tb, this, MDI.ActiveForm);
        }

        private void notificationbtn_Click(object sender, EventArgs e)
        {
            Notification nf = new Notification();
            mc.showwindow(nf, this, MDI.ActiveForm);

        }

        private void groupbtn_Click(object sender, EventArgs e)
        {

        }

        private void Rolebtn_Click(object sender, EventArgs e)
        {
            Role ro = new Role();
            mc.showwindow(ro, this, MDI.ActiveForm);
        }
    }
}
