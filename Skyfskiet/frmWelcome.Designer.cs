namespace Skyfskiet
{
    partial class frmWelcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.gbxShooters = new System.Windows.Forms.GroupBox();
            this.btnAddShooter = new System.Windows.Forms.Button();
            this.gbxGuns = new System.Windows.Forms.GroupBox();
            this.btnAddNewGun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxShooters.SuspendLayout();
            this.gbxGuns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(595, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Eldoraigne\'s gun database\r\n";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(19, 75);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(277, 17);
            this.lblChoice.TabIndex = 1;
            this.lblChoice.Text = "Please choose one of the following options";
            // 
            // gbxShooters
            // 
            this.gbxShooters.Controls.Add(this.btnAddShooter);
            this.gbxShooters.Location = new System.Drawing.Point(22, 111);
            this.gbxShooters.Name = "gbxShooters";
            this.gbxShooters.Size = new System.Drawing.Size(200, 120);
            this.gbxShooters.TabIndex = 2;
            this.gbxShooters.TabStop = false;
            this.gbxShooters.Text = "Shooters";
            // 
            // btnAddShooter
            // 
            this.btnAddShooter.FlatAppearance.BorderSize = 3;
            this.btnAddShooter.Location = new System.Drawing.Point(7, 47);
            this.btnAddShooter.Name = "btnAddShooter";
            this.btnAddShooter.Size = new System.Drawing.Size(187, 44);
            this.btnAddShooter.TabIndex = 0;
            this.btnAddShooter.Text = "Go to shooters overview";
            this.btnAddShooter.UseVisualStyleBackColor = true;
            this.btnAddShooter.Click += new System.EventHandler(this.BtnAddShooter_Click);
            // 
            // gbxGuns
            // 
            this.gbxGuns.Controls.Add(this.btnAddNewGun);
            this.gbxGuns.Location = new System.Drawing.Point(286, 111);
            this.gbxGuns.Name = "gbxGuns";
            this.gbxGuns.Size = new System.Drawing.Size(200, 120);
            this.gbxGuns.TabIndex = 3;
            this.gbxGuns.TabStop = false;
            this.gbxGuns.Text = "Guns";
            // 
            // btnAddNewGun
            // 
            this.btnAddNewGun.Location = new System.Drawing.Point(6, 47);
            this.btnAddNewGun.Name = "btnAddNewGun";
            this.btnAddNewGun.Size = new System.Drawing.Size(187, 44);
            this.btnAddNewGun.TabIndex = 1;
            this.btnAddNewGun.Text = "Go to gun overview";
            this.btnAddNewGun.UseVisualStyleBackColor = true;
            this.btnAddNewGun.Click += new System.EventHandler(this.BtnAddNewGun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Exit Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 278);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxGuns);
            this.Controls.Add(this.gbxShooters);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.gbxShooters.ResumeLayout(false);
            this.gbxGuns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.GroupBox gbxShooters;
        private System.Windows.Forms.GroupBox gbxGuns;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddShooter;
        private System.Windows.Forms.Button btnAddNewGun;
    }
}