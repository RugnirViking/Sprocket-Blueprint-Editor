using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sprocket_Blueprint_Editor
{
    public partial class HullForm : Form
    {
        public Form1 parent;
        public HullForm(Form1 myparent)
        {
            parent = myparent;
            InitializeComponent();

            LoadHull();
        }
        public void LoadHull()
        {
            var blueprintFile = parent.TankJsonData;
            if (!((IEnumerable<dynamic>)blueprintFile.blueprints).Any(x => x.id == "HUL"))
            {
                MessageBox.Show("Hull data not present in blueprint. Goodness knows how you have a tank with no hull, well done thats impressive?");
                return;
            }
            try
            {
                string hulldata = ((IEnumerable<dynamic>)blueprintFile.blueprints).First(x => x.id == "HUL").data;
                dynamic hull = JsonConvert.DeserializeObject(hulldata);
                txtHullName.Text = hull.name;
                //[7,12,14,6,8,15,10,13,17,5,11,18,9,16,0]
                txtMajorVersion.Text = hull.version.Major;
                txtMinorVersion.Text = hull.version.Minor;
                lblVer.Text = String.Format("(Hulls V{0}.{1})", hull.version.Major, hull.version.Minor);

                txtFrontUpperArmour.Text = hull.armour[0];
                txtSideUpperArmour.Text = hull.armour[1];
                txtRearUpperArmour.Text = hull.armour[2];
                txtRoofArmour.Text = hull.armour[3];
                txtFrontMidArmour.Text = hull.armour[4];
                txtRearMidArmour.Text = hull.armour[5];
                txtFrontLowerArmour.Text = hull.armour[6];
                txtSideLowerArmour.Text = hull.armour[7];
                txtRearLowerArmour.Text = hull.armour[8];
                txtBellyArmour.Text = hull.armour[9];
                txtFrontSponsonArmour.Text = hull.armour[10];
                txtRearSponsonArmour.Text = hull.armour[11];
                txtFrontStripArmour.Text = hull.armour[12];
                txtRearStripArmour.Text = hull.armour[13];
                txtUnknownArmour.Text = hull.armour[14];

                txtArmourSpaceMod.Text = hull.armourSpace;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading hull data, sorry :(");
                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        internal void SaveHull()
        {
            string hulldata = ((IEnumerable<dynamic>)parent.TankJsonData.blueprints).First(x => x.id == "HUL").data;
            dynamic hull = JsonConvert.DeserializeObject(hulldata);

            hull.version.Major = txtMajorVersion.Text;
            hull.version.Minor = txtMinorVersion.Text;

            try
            {
                hull.armour[0] = Int32.Parse(txtFrontUpperArmour.Text);
                hull.armour[1] = Int32.Parse(txtSideUpperArmour.Text);
                hull.armour[2] = Int32.Parse(txtRearUpperArmour.Text);
                hull.armour[3] = Int32.Parse(txtRoofArmour.Text);
                hull.armour[4] = Int32.Parse(txtFrontMidArmour.Text);
                hull.armour[5] = Int32.Parse(txtRearMidArmour.Text);
                hull.armour[6] = Int32.Parse(txtFrontLowerArmour.Text);
                hull.armour[7] = Int32.Parse(txtSideLowerArmour.Text);
                hull.armour[8] = Int32.Parse(txtRearLowerArmour.Text);
                hull.armour[9] = Int32.Parse(txtBellyArmour.Text);
                hull.armour[10] = Int32.Parse(txtFrontSponsonArmour.Text);
                hull.armour[11] = Int32.Parse(txtRearSponsonArmour.Text);
                hull.armour[12] = Int32.Parse(txtFrontStripArmour.Text);
                hull.armour[13] = Int32.Parse(txtRearStripArmour.Text);
                hull.armour[14] = Int32.Parse(txtUnknownArmour.Text);
            } 
            catch (Exception e)
            {
                MessageBox.Show("Invalid armour value - Hull not saved");
                return;
            }

            hull.armourSpace = txtArmourSpaceMod.Text;

            ((IEnumerable<dynamic>)parent.TankJsonData.blueprints).First(x => x.id == "HUL").data = JsonConvert.SerializeObject(hull, Formatting.None);

        }
    }
}
