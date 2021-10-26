using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprocket_Blueprint_Editor
{
    public partial class Form1 : Form
    {

        public string _file;
        public string file
        {
            get
            {
                return _file;
            }
            set
            {
                _file = value;
                textBox1.Text = _file;
                textBox1.SelectionLength = 0;
                textBox1.SelectionStart = txtTankName.Text.Length;
                textBox1.Focus();
                textBox1.ScrollToCaret();
                textBox1.AppendText("");
            }
        }

        public dynamic TankJsonData;
        private HullForm hullForm;
        private TurretForm turretForm;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Tank Blueprint (*.blueprint)|*.blueprint";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents\My Games\Sprocket\Factions");
            openFileDialog1.InitialDirectory = filePath;
            openFileDialog1.FileName = "";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                if (File.Exists(file))
                {
                    LoadFile(file);
                }
                else
                {
                    MessageBox.Show("Could not find file, sorry");
                }
            }
        }

        private void LoadFile(string filePath)
        {
            dynamic blueprintFile;
            try
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    blueprintFile = JsonConvert.DeserializeObject(json);
                }
                txtTankName.Enabled = true;
                txtHullVolume.Enabled = true;
                if (((IEnumerable<dynamic>)blueprintFile.blueprints).Any(x => x.id == "TRT"))
                {
                    txtTurretVolume.Enabled = true;
                    chkbxHasTurret.Checked = true;
                    btnTurretData.Enabled = true;
                }
                else
                {
                    txtTurretVolume.Enabled = false;
                    chkbxHasTurret.Checked = false;
                    btnTurretData.Enabled = false;
                }
                txtFullMass.Enabled = true;
                txtEmptyMass.Enabled = true;

                btnHullData.Enabled = true;
                btnCrewData.Enabled = true;

                txtTankName.Text = blueprintFile.Name;


                txtHullVolume.Text = blueprintFile.hullInternalSpace;
                txtTurretVolume.Text = blueprintFile.turretInternalSpace;
                txtFullMass.Text = blueprintFile.fullMass;
                txtEmptyMass.Text = blueprintFile.Era;

                TankJsonData = blueprintFile;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading file. Are you sure it's a tank .blueprint file?");
                return;
            }
        }

        private void btnHullData_Click(object sender, EventArgs e)
        {
            if (hullForm != null)
            {
                hullForm.Close();
            }
            hullForm = new HullForm(this);

            hullForm.Show();
        }

        private void btnTurretData_Click(object sender, EventArgs e)
        {
            if (turretForm != null)
            {
                turretForm.Close();
            }
            turretForm = new TurretForm(this);

            turretForm.Show();
        }

        private void btnCrewData_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFile(textBox1.Text);
            if (hullForm != null)
            {
                hullForm.LoadHull();
            }
            if (turretForm != null)
            {
                turretForm.LoadTurret();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFile(textBox1.Text);
        }

        private void SaveFile(string filePath)
        {

            dynamic json = TankJsonData;

            json.Name = txtTankName.Text;
            json.hullInternalSpace = txtHullVolume.Text;
            json.turretInternalSpace = txtTurretVolume.Text;
            json.fullMass = txtFullMass.Text;
            json.Era = txtEmptyMass.Text;

            if (hullForm != null)
            {
                hullForm.SaveHull();
            }
            if (turretForm != null)
            {
                turretForm.SaveTurret();
            }

            using (StreamWriter w = new StreamWriter(filePath))
            {
                string blueprintFile = JsonConvert.SerializeObject(json, Formatting.Indented);
                w.Write(blueprintFile);
            }
        }
    }
}
