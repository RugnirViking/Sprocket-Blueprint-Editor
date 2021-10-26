
namespace Sprocket_Blueprint_Editor
{
    partial class TurretForm
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
            this.txtTurretName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinorVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMajorVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTurretName
            // 
            this.txtTurretName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTurretName.Location = new System.Drawing.Point(92, 12);
            this.txtTurretName.Name = "txtTurretName";
            this.txtTurretName.Size = new System.Drawing.Size(696, 23);
            this.txtTurretName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turret Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Minor";
            // 
            // txtMinorVersion
            // 
            this.txtMinorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinorVersion.Location = new System.Drawing.Point(273, 41);
            this.txtMinorVersion.Name = "txtMinorVersion";
            this.txtMinorVersion.Size = new System.Drawing.Size(67, 23);
            this.txtMinorVersion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Major";
            // 
            // txtMajorVersion
            // 
            this.txtMajorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMajorVersion.Location = new System.Drawing.Point(155, 41);
            this.txtMajorVersion.Name = "txtMajorVersion";
            this.txtMajorVersion.Size = new System.Drawing.Size(67, 23);
            this.txtMajorVersion.TabIndex = 8;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(13, 44);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(94, 15);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Sprocket Version";
            // 
            // TurretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinorVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMajorVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtTurretName);
            this.Controls.Add(this.label1);
            this.Name = "TurretForm";
            this.Text = "Rug\'s Turrets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurretName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinorVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMajorVersion;
        private System.Windows.Forms.Label lblVersion;
    }
}