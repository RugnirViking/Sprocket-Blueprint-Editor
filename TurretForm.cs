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
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading turret data, sorry :(");
                return;
            }
        }
        public void SaveTurret()
        {

        }
    }
}
