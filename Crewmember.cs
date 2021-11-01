using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sprocket_Blueprint_Editor
{
    public partial class Crewmember : UserControl
    {
        public Crewmember(string crewstring,double space, bool inTurret,int n)
        {
            InitializeComponent();
            string[] s = crewstring.Split(",");
            foreach (string a in s){
                //commander,radioman/driver/gunner,loader
                switch (a)
                {
                    case "driver":
                        chkIsDriver.Checked = true;
                        break;
                    case "gunner":
                        chkIsGunner.Checked = true;
                        break;
                    case "loader":
                        chkIsLoader.Checked = true;
                        break;
                    case "radioman":
                        chkIsRadioman.Checked = true;
                        break;
                    case "commander":
                        chkIsCommander.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            textBox1.Text = space.ToString();
            if (inTurret)
            {
                rdHull.Checked = false;
                rdTurret.Checked = true;
            } 
            else
            {
                rdHull.Checked = true;
                rdTurret.Checked = false;
            }
            lblCrewName.Text = "Crewman " + n.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
