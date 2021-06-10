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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            LOGIN obj = new LOGIN();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }
    }
}
