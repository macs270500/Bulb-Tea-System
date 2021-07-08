using System;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        Main_Menu frmMainMenu = new Main_Menu();
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 708)
            {
                timer1.Stop();

                frmMainMenu.Show();
                Close();
            }
        }
        public void btnSelection(string department)
        {
            frmMainMenu.ButtonSelection(department);
        }




    }
}
