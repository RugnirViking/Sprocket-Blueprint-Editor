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
    public partial class TurretForm : Form
    {
        public Form1 parent;
        public TurretForm(Form1 myparent)
        {
            parent = myparent;
            InitializeComponent();

            LoadTurret();
        }
        public void LoadTurret()
        {
            var blueprintFile = parent.TankJsonData;
            if (!((IEnumerable<dynamic>)blueprintFile.blueprints).Any(x => x.id == "TRT"))
            {
                MessageBox.Show("Turret data not present in blueprint. Perhaps its a tank destroyer?");
                return;
            }
            try
            {

                string turretdata = ((IEnumerable<dynamic>)blueprintFile.blueprints).First(x => x.id == "TRT").data;
                dynamic turret = JsonConvert.DeserializeObject(turretdata);
                txtTurretName.Text = turret.name;

                txtMajorVersion.Text = turret.version.Major;
                txtMinorVersion.Text = turret.version.Major; 
                lblVer.Text = String.Format("(Turrets V{0}.{1})", turret.version.Major, turret.version.Minor);

                txtFrontFrontArmour.Text   = turret.armour[0];
                txtRearRearArmour.Text     = turret.armour[1];
                txtSideArmour.Text         = turret.armour[2];
                txtFrontCheekArmour.Text   = turret.armour[3];
                txtRearCheekArmour.Text    = turret.armour[4];
                txtFrontRoofArmour.Text    = turret.armour[5];
                txtRearRoofArmour.Text     = turret.armour[6];
                txtRoofArmour.Text         = turret.armour[7];

                txtRingArmour.Text         = turret.bus[0];

                txtArmourSpaceMod.Text     = turret.armourSpace;
                txtTraverseResistance.Text = turret.traverseResistance;
                txtTraverseRatio.Text      = turret.traverseRatio;

                txtTraverseMotor.Text      = turret.bF[3];
                txtRingHeight.Text         = turret.bF[1];
                txtRingDiameter.Text       = turret.bF[0];
                chkFixedTurret.Checked     = false;
                chkPoweredTraverse.Checked = false;
                int flags = turret.bFlags;
                // there is a better way to unpack enummy flag things but ive been awake all night and I cant be bothered to figure it out for 2 flags.
                if (flags == 1 || flags==3)
                {
                    chkFixedTurret.Checked = true;
                }
                if (flags == 2 || flags == 3)
                {
                    chkPoweredTraverse.Checked = true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading turret data, sorry :(");
                return;
            }
        }
        public void SaveTurret()
        {
            string turretdata = ((IEnumerable<dynamic>)parent.TankJsonData.blueprints).First(x => x.id == "TRT").data;
            dynamic turret = JsonConvert.DeserializeObject(turretdata);

            turret.version.Major = txtMajorVersion.Text;
            turret.version.Minor = txtMinorVersion.Text;

            try
            {
                turret.armour[0] = Int32.Parse(txtFrontFrontArmour.Text);
                turret.armour[1] = Int32.Parse(txtRearRearArmour.Text);
                turret.armour[2] = Int32.Parse(txtSideArmour.Text);
                turret.armour[3] = Int32.Parse(txtFrontCheekArmour.Text);
                turret.armour[4] = Int32.Parse(txtRearCheekArmour.Text);
                turret.armour[5] = Int32.Parse(txtFrontRoofArmour.Text);
                turret.armour[6] = Int32.Parse(txtRearRoofArmour.Text);
                turret.armour[7] = Int32.Parse(txtRoofArmour.Text);

                turret.bus[0] = Int32.Parse(txtRingArmour.Text);

                turret.armourSpace = float.Parse(txtArmourSpaceMod.Text);
                turret.traverseResistance = float.Parse(txtTraverseResistance.Text);
                turret.traverseRatio = float.Parse(txtTraverseRatio.Text);

                turret.bF[3] = float.Parse(txtTraverseMotor.Text);
                turret.bF[1] = float.Parse(txtRingHeight.Text);
                turret.bF[0] = float.Parse(txtRingDiameter.Text);
                int flag = 0;
                if (chkFixedTurret.Checked)
                    flag += 1;
                if (chkPoweredTraverse.Checked)
                    flag += 2;

                turret.bFlags = flag;
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid armour value - Hull not saved");
                return;
            }

            turret.armourSpace = txtArmourSpaceMod.Text;

            ((IEnumerable<dynamic>)parent.TankJsonData.blueprints).First(x => x.id == "TRT").data = JsonConvert.SerializeObject(turret, Formatting.None);
        }
    }
}
