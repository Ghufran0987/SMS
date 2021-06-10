using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SchoolManagementsSystem
{
    public class MainClass
    {
        

        public void showwindow(Form showwin,Form closewin,Form MDI) {

            showwin.Show();
            showwin.WindowState = FormWindowState.Maximized;
            showwin.MdiParent = MDI;
            closewin.Close();

           





        }
    }
}
