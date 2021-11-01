
namespace Sprocket_Blueprint_Editor
{
    partial class CrewForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinorVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMajorVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtTurretName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(347, 37);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(0, 15);
            this.lblVer.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(1, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(549, 2);
            this.label5.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Minor";
            // 
            // txtMinorVersion
            // 
            this.txtMinorVersion.Location = new System.Drawing.Point(274, 34);
            this.txtMinorVersion.Name = "txtMinorVersion";
            this.txtMinorVersion.Size = new System.Drawing.Size(67, 23);
            this.txtMinorVersion.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 104;
            this.label2.Text = "Major";
            // 
            // txtMajorVersion
            // 
            this.txtMajorVersion.Location = new System.Drawing.Point(156, 34);
            this.txtMajorVersion.Name = "txtMajorVersion";
            this.txtMajorVersion.Size = new System.Drawing.Size(67, 23);
            this.txtMajorVersion.TabIndex = 103;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(14, 37);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(94, 15);
            this.lblVersion.TabIndex = 102;
            this.lblVersion.Text = "Sprocket Version";
            // 
            // txtTurretName
            // 
            this.txtTurretName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTurretName.Location = new System.Drawing.Point(140, 5);
            this.txtTurretName.Name = "txtTurretName";
            this.txtTurretName.Size = new System.Drawing.Size(399, 23);
            this.txtTurretName.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "Crew Blueprint Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 71);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 142;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(553, 530);
            this.flowLayoutPanel1.TabIndex = 143;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // CrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 630);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinorVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMajorVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtTurretName);
            this.Controls.Add(this.label1);
            this.Name = "CrewForm";
            this.Text = "Rug\'s Crew";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinorVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMajorVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtTurretName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}