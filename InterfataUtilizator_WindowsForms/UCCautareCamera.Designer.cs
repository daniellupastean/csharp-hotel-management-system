﻿
namespace InterfataUtilizator_WindowsForms
{
    partial class UCCautareCamera
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
            this.PnlModificareCamera = new System.Windows.Forms.Panel();
            this.PnlAfisareCameraCautata = new System.Windows.Forms.Panel();
            this.LblCameraCautata = new System.Windows.Forms.Label();
            this.LblHeaderInfo = new System.Windows.Forms.Label();
            this.LblCautareAvertisment = new System.Windows.Forms.Label();
            this.LblTitluCautareCamera = new System.Windows.Forms.Label();
            this.TxtIDCamera = new System.Windows.Forms.TextBox();
            this.LblIDCamera = new System.Windows.Forms.Label();
            this.BtnCautaCamera = new System.Windows.Forms.Button();
            this.PnlModificareCamera.SuspendLayout();
            this.PnlAfisareCameraCautata.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlModificareCamera
            // 
            this.PnlModificareCamera.BackColor = System.Drawing.Color.Transparent;
            this.PnlModificareCamera.Controls.Add(this.PnlAfisareCameraCautata);
            this.PnlModificareCamera.Controls.Add(this.LblCautareAvertisment);
            this.PnlModificareCamera.Controls.Add(this.LblTitluCautareCamera);
            this.PnlModificareCamera.Controls.Add(this.TxtIDCamera);
            this.PnlModificareCamera.Controls.Add(this.LblIDCamera);
            this.PnlModificareCamera.Controls.Add(this.BtnCautaCamera);
            this.PnlModificareCamera.Location = new System.Drawing.Point(0, 0);
            this.PnlModificareCamera.Name = "PnlModificareCamera";
            this.PnlModificareCamera.Size = new System.Drawing.Size(824, 515);
            this.PnlModificareCamera.TabIndex = 6;
            // 
            // PnlAfisareCameraCautata
            // 
            this.PnlAfisareCameraCautata.BackColor = System.Drawing.Color.White;
            this.PnlAfisareCameraCautata.Controls.Add(this.LblCameraCautata);
            this.PnlAfisareCameraCautata.Controls.Add(this.LblHeaderInfo);
            this.PnlAfisareCameraCautata.Location = new System.Drawing.Point(44, 261);
            this.PnlAfisareCameraCautata.Name = "PnlAfisareCameraCautata";
            this.PnlAfisareCameraCautata.Size = new System.Drawing.Size(726, 92);
            this.PnlAfisareCameraCautata.TabIndex = 25;
            this.PnlAfisareCameraCautata.Visible = false;
            // 
            // LblCameraCautata
            // 
            this.LblCameraCautata.AutoSize = true;
            this.LblCameraCautata.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCameraCautata.Location = new System.Drawing.Point(10, 50);
            this.LblCameraCautata.Name = "LblCameraCautata";
            this.LblCameraCautata.Size = new System.Drawing.Size(0, 16);
            this.LblCameraCautata.TabIndex = 1;
            // 
            // LblHeaderInfo
            // 
            this.LblHeaderInfo.AutoSize = true;
            this.LblHeaderInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.LblHeaderInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderInfo.Location = new System.Drawing.Point(10, 14);
            this.LblHeaderInfo.Name = "LblHeaderInfo";
            this.LblHeaderInfo.Size = new System.Drawing.Size(0, 16);
            this.LblHeaderInfo.TabIndex = 0;
            // 
            // LblCautareAvertisment
            // 
            this.LblCautareAvertisment.AutoSize = true;
            this.LblCautareAvertisment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCautareAvertisment.ForeColor = System.Drawing.Color.Firebrick;
            this.LblCautareAvertisment.Location = new System.Drawing.Point(236, 220);
            this.LblCautareAvertisment.Name = "LblCautareAvertisment";
            this.LblCautareAvertisment.Size = new System.Drawing.Size(0, 20);
            this.LblCautareAvertisment.TabIndex = 24;
            // 
            // LblTitluCautareCamera
            // 
            this.LblTitluCautareCamera.AutoSize = true;
            this.LblTitluCautareCamera.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluCautareCamera.Location = new System.Drawing.Point(283, 34);
            this.LblTitluCautareCamera.Name = "LblTitluCautareCamera";
            this.LblTitluCautareCamera.Size = new System.Drawing.Size(242, 33);
            this.LblTitluCautareCamera.TabIndex = 23;
            this.LblTitluCautareCamera.Text = "Cautare Camera";
            // 
            // TxtIDCamera
            // 
            this.TxtIDCamera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDCamera.Location = new System.Drawing.Point(305, 170);
            this.TxtIDCamera.Name = "TxtIDCamera";
            this.TxtIDCamera.Size = new System.Drawing.Size(139, 26);
            this.TxtIDCamera.TabIndex = 2;
            // 
            // LblIDCamera
            // 
            this.LblIDCamera.AutoSize = true;
            this.LblIDCamera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDCamera.Location = new System.Drawing.Point(257, 170);
            this.LblIDCamera.Name = "LblIDCamera";
            this.LblIDCamera.Size = new System.Drawing.Size(25, 20);
            this.LblIDCamera.TabIndex = 1;
            this.LblIDCamera.Text = "ID";
            // 
            // BtnCautaCamera
            // 
            this.BtnCautaCamera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCautaCamera.FlatAppearance.BorderSize = 0;
            this.BtnCautaCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCautaCamera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCautaCamera.Location = new System.Drawing.Point(468, 171);
            this.BtnCautaCamera.Name = "BtnCautaCamera";
            this.BtnCautaCamera.Size = new System.Drawing.Size(74, 26);
            this.BtnCautaCamera.TabIndex = 0;
            this.BtnCautaCamera.Text = "Cauta";
            this.BtnCautaCamera.UseVisualStyleBackColor = false;
            this.BtnCautaCamera.Click += new System.EventHandler(this.BtnCautaCamera_Click);
            // 
            // UCCautareCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlModificareCamera);
            this.Name = "UCCautareCamera";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCCautareCamera_Load);
            this.PnlModificareCamera.ResumeLayout(false);
            this.PnlModificareCamera.PerformLayout();
            this.PnlAfisareCameraCautata.ResumeLayout(false);
            this.PnlAfisareCameraCautata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlModificareCamera;
        private System.Windows.Forms.Label LblTitluCautareCamera;
        private System.Windows.Forms.TextBox TxtIDCamera;
        private System.Windows.Forms.Label LblIDCamera;
        private System.Windows.Forms.Button BtnCautaCamera;
        private System.Windows.Forms.Panel PnlAfisareCameraCautata;
        private System.Windows.Forms.Label LblCameraCautata;
        private System.Windows.Forms.Label LblHeaderInfo;
        private System.Windows.Forms.Label LblCautareAvertisment;
    }
}
