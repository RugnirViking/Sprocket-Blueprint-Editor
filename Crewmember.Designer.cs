
namespace Sprocket_Blueprint_Editor
{
    partial class Crewmember
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCrewName = new System.Windows.Forms.Label();
            this.chkIsDriver = new System.Windows.Forms.CheckBox();
            this.chkIsGunner = new System.Windows.Forms.CheckBox();
            this.chkIsLoader = new System.Windows.Forms.CheckBox();
            this.chkIsRadioman = new System.Windows.Forms.CheckBox();
            this.chkIsCommander = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdHull = new System.Windows.Forms.RadioButton();
            this.rdTurret = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCrewName
            // 
            this.lblCrewName.AutoSize = true;
            this.lblCrewName.Location = new System.Drawing.Point(3, 4);
            this.lblCrewName.Name = "lblCrewName";
            this.lblCrewName.Size = new System.Drawing.Size(68, 15);
            this.lblCrewName.TabIndex = 0;
            this.lblCrewName.Text = "Crewman X";
            // 
            // chkIsDriver
            // 
            this.chkIsDriver.AutoSize = true;
            this.chkIsDriver.Location = new System.Drawing.Point(77, 3);
            this.chkIsDriver.Name = "chkIsDriver";
            this.chkIsDriver.Size = new System.Drawing.Size(57, 19);
            this.chkIsDriver.TabIndex = 1;
            this.chkIsDriver.Text = "Driver";
            this.chkIsDriver.UseVisualStyleBackColor = true;
            // 
            // chkIsGunner
            // 
            this.chkIsGunner.AutoSize = true;
            this.chkIsGunner.Location = new System.Drawing.Point(166, 3);
            this.chkIsGunner.Name = "chkIsGunner";
            this.chkIsGunner.Size = new System.Drawing.Size(65, 19);
            this.chkIsGunner.TabIndex = 2;
            this.chkIsGunner.Text = "Gunner";
            this.chkIsGunner.UseVisualStyleBackColor = true;
            // 
            // chkIsLoader
            // 
            this.chkIsLoader.AutoSize = true;
            this.chkIsLoader.Location = new System.Drawing.Point(255, 3);
            this.chkIsLoader.Name = "chkIsLoader";
            this.chkIsLoader.Size = new System.Drawing.Size(62, 19);
            this.chkIsLoader.TabIndex = 3;
            this.chkIsLoader.Text = "Loader";
            this.chkIsLoader.UseVisualStyleBackColor = true;
            // 
            // chkIsRadioman
            // 
            this.chkIsRadioman.AutoSize = true;
            this.chkIsRadioman.Location = new System.Drawing.Point(344, 3);
            this.chkIsRadioman.Name = "chkIsRadioman";
            this.chkIsRadioman.Size = new System.Drawing.Size(80, 19);
            this.chkIsRadioman.TabIndex = 4;
            this.chkIsRadioman.Text = "Radioman";
            this.chkIsRadioman.UseVisualStyleBackColor = true;
            // 
            // chkIsCommander
            // 
            this.chkIsCommander.AutoSize = true;
            this.chkIsCommander.Location = new System.Drawing.Point(433, 3);
            this.chkIsCommander.Name = "chkIsCommander";
            this.chkIsCommander.Size = new System.Drawing.Size(93, 19);
            this.chkIsCommander.TabIndex = 5;
            this.chkIsCommander.Text = "Commander";
            this.chkIsCommander.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(218, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Space Allocated:";
            // 
            // rdHull
            // 
            this.rdHull.AutoSize = true;
            this.rdHull.Location = new System.Drawing.Point(3, 29);
            this.rdHull.Name = "rdHull";
            this.rdHull.Size = new System.Drawing.Size(47, 19);
            this.rdHull.TabIndex = 8;
            this.rdHull.TabStop = true;
            this.rdHull.Text = "Hull";
            this.rdHull.UseVisualStyleBackColor = true;
            // 
            // rdTurret
            // 
            this.rdTurret.AutoSize = true;
            this.rdTurret.Location = new System.Drawing.Point(56, 29);
            this.rdTurret.Name = "rdTurret";
            this.rdTurret.Size = new System.Drawing.Size(56, 19);
            this.rdTurret.TabIndex = 9;
            this.rdTurret.TabStop = true;
            this.rdTurret.Text = "Turret";
            this.rdTurret.UseVisualStyleBackColor = true;
            this.rdTurret.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Crewmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rdTurret);
            this.Controls.Add(this.rdHull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkIsCommander);
            this.Controls.Add(this.chkIsRadioman);
            this.Controls.Add(this.chkIsLoader);
            this.Controls.Add(this.chkIsGunner);
            this.Controls.Add(this.chkIsDriver);
            this.Controls.Add(this.lblCrewName);
            this.Name = "Crewmember";
            this.Size = new System.Drawing.Size(530, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrewName;
        private System.Windows.Forms.CheckBox chkIsDriver;
        private System.Windows.Forms.CheckBox chkIsGunner;
        private System.Windows.Forms.CheckBox chkIsLoader;
        private System.Windows.Forms.CheckBox chkIsRadioman;
        private System.Windows.Forms.CheckBox chkIsCommander;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdHull;
        private System.Windows.Forms.RadioButton rdTurret;
    }
}
