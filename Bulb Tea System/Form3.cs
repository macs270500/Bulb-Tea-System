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
    public partial class Form3 : Form
    {
        public string Flavour;
        public string Bas;
        public string fav
        {
            get { return Flavour; }
            set { Flavour = value; }
        }
        public string bas
        {
            get { return Bas; }
            set { Bas = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }
        string choosed;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radAlmond.Checked)
            {
                choosed = "Almond";
            }
            if (radBanana.Checked)
            {
                choosed = "Banana";
            }
            if (radCaramel.Checked)
            {
                choosed = "Caramel";
            }
            if (radChocolate.Checked)
            {
                choosed = "Chocolate";
            }
            if (radCoconut.Checked)
            {
                choosed = "Coconut";
            }
            if (radHazelnut.Checked)
            {
                choosed = "Hazelnut";
            }
            if (radHoneydew.Checked)
            {
                choosed = "Honeydew";
            }
            if (radMatcha.Checked)
            {
                choosed = "Matcha";
            }
            if (radPlainJasmine.Checked)
            {
                choosed = "Plain Jasmine";
            }
            if (radTaro.Checked)
            {
                choosed = "Taro";
            }
            bas = "milk Tea";
            fav = choosed;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
