using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulb_Tea_System
{
    public partial class Form2 : Form
    {
        private string FlavourChoosed;
        private string Based;
        public string flavour
        {
            get { return FlavourChoosed; }
            set { FlavourChoosed = value; }
        }
        public string based
        {
            get { return Based; }
            set { Based = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        string choose;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radGreenApple.Checked)
            {
                choose = "Green Apple";
            }
            if (radGreenMelon.Checked)
            {
                choose = "Green Melon";
            }
            if (radKiwi.Checked)
            {
                choose = "Kiwi";
            }
            if (radLychee.Checked)
            {
                choose = "Lychee";
            }
            if (radMango.Checked)
            {
                choose = "Mango";
            }
            if (radPassion.Checked)
            {
                choose = "Passion";
            }
            if (radPeach.Checked)
            {
                choose = "Peach";
            }
            if (radPepperMint.Checked)
            {
                choose = "Pepper Mint";
            }
            if (radPomegranate.Checked)
            {
                choose = "Pomegranate";
            }
            if (radStrawberry.Checked)
            {
                choose = "Strawberry";
            }
            based = "Fruit Tea";
            flavour = choose;


        }
    }
}
