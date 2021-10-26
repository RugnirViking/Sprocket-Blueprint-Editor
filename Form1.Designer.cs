
namespace Sprocket_Blueprint_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTankName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTankName = new System.Windows.Forms.Label();
            this.lblHullVolume = new System.Windows.Forms.Label();
            this.txtHullVolume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurretVolume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullMass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmptyMass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkbxHasTurret = new System.Windows.Forms.CheckBox();
            this.btnHullData = new System.Windows.Forms.Button();
            this.btnTurretData = new System.Windows.Forms.Button();
            this.btnCrewData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(555, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Blueprint File (.blueprint)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(26, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(555, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save Blueprint File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTankName
            // 
            this.txtTankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTankName.Enabled = false;
            this.txtTankName.Location = new System.Drawing.Point(160, 98);
            this.txtTankName.Name = "txtTankName";
            this.txtTankName.Size = new System.Drawing.Size(389, 23);
            this.txtTankName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 2);
            this.label1.TabIndex = 4;
            // 
            // lblTankName
            // 
            this.lblTankName.AutoSize = true;
            this.lblTankName.Location = new System.Drawing.Point(26, 101);
            this.lblTankName.Name = "lblTankName";
            this.lblTankName.Size = new System.Drawing.Size(66, 15);
            this.lblTankName.TabIndex = 5;
            this.lblTankName.Text = "Tank Name";
            // 
            // lblHullVolume
            // 
            this.lblHullVolume.AutoSize = true;
            this.lblHullVolume.Location = new System.Drawing.Point(26, 130);
            this.lblHullVolume.Name = "lblHullVolume";
            this.lblHullVolume.Size = new System.Drawing.Size(72, 15);
            this.lblHullVolume.TabIndex = 7;
            this.lblHullVolume.Text = "Hull Volume";
            // 
            // txtHullVolume
            // 
            this.txtHullVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHullVolume.Enabled = false;
            this.txtHullVolume.Location = new System.Drawing.Point(160, 127);
            this.txtHullVolume.Name = "txtHullVolume";
            this.txtHullVolume.Size = new System.Drawing.Size(389, 23);
            this.txtHullVolume.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Turret Volume";
            // 
            // txtTurretVolume
            // 
            this.txtTurretVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTurretVolume.Enabled = false;
            this.txtTurretVolume.Location = new System.Drawing.Point(160, 156);
            this.txtTurretVolume.Name = "txtTurretVolume";
            this.txtTurretVolume.Size = new System.Drawing.Size(389, 23);
            this.txtTurretVolume.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Full Mass";
            // 
            // txtFullMass
            // 
            this.txtFullMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullMass.Enabled = false;
            this.txtFullMass.Location = new System.Drawing.Point(160, 185);
            this.txtFullMass.Name = "txtFullMass";
            this.txtFullMass.Size = new System.Drawing.Size(389, 23);
            this.txtFullMass.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Era";
            // 
            // txtEmptyMass
            // 
            this.txtEmptyMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmptyMass.Enabled = false;
            this.txtEmptyMass.Location = new System.Drawing.Point(160, 214);
            this.txtEmptyMass.Name = "txtEmptyMass";
            this.txtEmptyMass.Size = new System.Drawing.Size(389, 23);
            this.txtEmptyMass.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Remember to back up important blueprints before editing <3";
            // 
            // chkbxHasTurret
            // 
            this.chkbxHasTurret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxHasTurret.AutoSize = true;
            this.chkbxHasTurret.Enabled = false;
            this.chkbxHasTurret.Location = new System.Drawing.Point(555, 100);
            this.chkbxHasTurret.Name = "chkbxHasTurret";
            this.chkbxHasTurret.Size = new System.Drawing.Size(80, 19);
            this.chkbxHasTurret.TabIndex = 16;
            this.chkbxHasTurret.Text = "Has Turret";
            this.chkbxHasTurret.UseVisualStyleBackColor = true;
            // 
            // btnHullData
            // 
            this.btnHullData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHullData.Enabled = false;
            this.btnHullData.Location = new System.Drawing.Point(3, 3);
            this.btnHullData.Name = "btnHullData";
            this.btnHullData.Size = new System.Drawing.Size(261, 75);
            this.btnHullData.TabIndex = 17;
            this.btnHullData.Text = "Hull Data";
            this.btnHullData.UseVisualStyleBackColor = true;
            this.btnHullData.Click += new System.EventHandler(this.btnHullData_Click);
            // 
            // btnTurretData
            // 
            this.btnTurretData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTurretData.Enabled = false;
            this.btnTurretData.Location = new System.Drawing.Point(270, 3);
            this.btnTurretData.Name = "btnTurretData";
            this.btnTurretData.Size = new System.Drawing.Size(261, 75);
            this.btnTurretData.TabIndex = 18;
            this.btnTurretData.Text = "Turret Data";
            this.btnTurretData.UseVisualStyleBackColor = true;
            this.btnTurretData.Click += new System.EventHandler(this.btnTurretData_Click);
            // 
            // btnCrewData
            // 
            this.btnCrewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrewData.Enabled = false;
            this.btnCrewData.Location = new System.Drawing.Point(537, 3);
            this.btnCrewData.Name = "btnCrewData";
            this.btnCrewData.Size = new System.Drawing.Size(262, 75);
            this.btnCrewData.TabIndex = 19;
            this.btnCrewData.Text = "Crew Data";
            this.btnCrewData.UseVisualStyleBackColor = true;
            this.btnCrewData.Click += new System.EventHandler(this.btnCrewData_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnHullData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCrewData, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTurretData, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 287);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 162);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(677, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Reload File ♻";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chkbxHasTurret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmptyMass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullMass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurretVolume);
            this.Controls.Add(this.lblHullVolume);
            this.Controls.Add(this.txtHullVolume);
            this.Controls.Add(this.lblTankName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTankName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rug\'s Sprocket Blueprint Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTankName;
        private System.Windows.Forms.Label lblHullVolume;
        private System.Windows.Forms.TextBox txtHullVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTurretVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullMass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmptyMass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkbxHasTurret;
        private System.Windows.Forms.Button btnHullData;
        private System.Windows.Forms.Button btnTurretData;
        private System.Windows.Forms.Button btnCrewData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
    }
}

