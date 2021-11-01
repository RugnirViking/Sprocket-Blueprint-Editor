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
    public partial class CrewForm : Form
    {
        public Form1 parent;
        private List<Crewmember> curCrew;

        public CrewForm(Form1 myparent)
        {
            parent = myparent;
            InitializeComponent();
            curCrew = new List<Crewmember>();

            LoadCrew();
        }
        public void LoadCrew()
        {
            var blueprintFile = parent.TankJsonData;
            if (!((IEnumerable<dynamic>)blueprintFile.blueprints).Any(x => x.id == "CRW"))
            {
                MessageBox.Show("Turret data not present in blueprint. Perhaps its a tank destroyer?");
                return;
            }
            try
            {
                flowLayoutPanel1.Controls.Clear();
                curCrew.Clear();
                string turretdata = ((IEnumerable<dynamic>)blueprintFile.blueprints).First(x => x.id == "CRW").data;
                dynamic crew = JsonConvert.DeserializeObject(turretdata);
                txtTurretName.Text = crew.name;

                txtMajorVersion.Text = crew.version.Major;
                txtMinorVersion.Text = crew.version.Major;
                lblVer.Text = String.Format("(Crew V{0}.{1})", crew.version.Major, crew.version.Minor);

                string crewString = crew.r;
                string[] crewStrings = crewString.Split("/");
                for (int i = 0; i < crewStrings.Count(); i++)
                {
                    double spaceAlloc = crew.alloc[i];
                    bool inTurret = crew.sid[i];
                    Crewmember c = new Crewmember(crewStrings[i], spaceAlloc, inTurret,i+1);
                    curCrew.Add(c);
                    flowLayoutPanel1.Controls.Add(c);

                }
                numericUpDown1.Value = crewStrings.Count();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading turret data, sorry :(");
                return;
            }
        }
        public void SaveCrew()
        {
            string crewdata = ((IEnumerable<dynamic>)parent.TankJsonData.blueprints).First(x => x.id == "CRW").data;
            dynamic crew = JsonConvert.DeserializeObject(crewdata);

            crew.version.Major = txtMajorVersion.Text;
            crew.version.Minor = txtMinorVersion.Text;

            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid value - Crew not saved");
                return;
            }


            ((IEnumerable<dynamic>)parent.TankJsonData.blueprints).First(x => x.id == "CRW").data = JsonConvert.SerializeObject(crew, Formatting.None);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int val = (int)numericUpDown1.Value;


            if (val>1 && val<99){
                if (val > curCrew.Count)
                {
                    while (val > curCrew.Count)
                    {
                        Crewmember c = new Crewmember("", 1.0, false, curCrew.Count+1);
                        curCrew.Add(c);
                        flowLayoutPanel1.Controls.Add(c);
                    }
                }
                else if (val < curCrew.Count)
                {
                    while (val < curCrew.Count)
                    {
                        flowLayoutPanel1.Controls.Remove(curCrew.Last());
                        curCrew.Remove(curCrew.Last());
                    }
                }
            }
        }
    }
}
