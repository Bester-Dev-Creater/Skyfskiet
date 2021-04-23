namespace Skyfskiet
{
    partial class frmBorrowedGuns
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
            this.btnMainForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxAvailableGuns = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxOut = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnGunOut = new System.Windows.Forms.Button();
            this.btnGunBack = new System.Windows.Forms.Button();
            this.cbxShooters = new System.Windows.Forms.ComboBox();
            this.cbxBand = new System.Windows.Forms.CheckBox();
            this.cbxRaiserBlock = new System.Windows.Forms.CheckBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblChoices = new System.Windows.Forms.Label();
            this.gbxAvailableGuns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainForm
            // 
            this.btnMainForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMainForm.Location = new System.Drawing.Point(938, 604);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(147, 39);
            this.btnMainForm.TabIndex = 49;
            this.btnMainForm.Text = "Back to main form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.BtnMainForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(1091, 604);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Exit Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // gbxAvailableGuns
            // 
            this.gbxAvailableGuns.Controls.Add(this.dataGridView1);
            this.gbxAvailableGuns.Location = new System.Drawing.Point(12, 60);
            this.gbxAvailableGuns.Name = "gbxAvailableGuns";
            this.gbxAvailableGuns.Size = new System.Drawing.Size(942, 274);
            this.gbxAvailableGuns.TabIndex = 51;
            this.gbxAvailableGuns.TabStop = false;
            this.gbxAvailableGuns.Text = "Available Guns";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // gbxOut
            // 
            this.gbxOut.Controls.Add(this.dataGridView2);
            this.gbxOut.Location = new System.Drawing.Point(13, 347);
            this.gbxOut.Name = "gbxOut";
            this.gbxOut.Size = new System.Drawing.Size(942, 238);
            this.gbxOut.TabIndex = 52;
            this.gbxOut.TabStop = false;
            this.gbxOut.Text = "Guns currently out";
            this.gbxOut.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(907, 164);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnGunOut
            // 
            this.btnGunOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGunOut.Location = new System.Drawing.Point(961, 158);
            this.btnGunOut.Name = "btnGunOut";
            this.btnGunOut.Size = new System.Drawing.Size(257, 56);
            this.btnGunOut.TabIndex = 53;
            this.btnGunOut.Text = "Borrow current gun";
            this.btnGunOut.UseVisualStyleBackColor = true;
            this.btnGunOut.Click += new System.EventHandler(this.BtnGunOut_Click);
            // 
            // btnGunBack
            // 
            this.btnGunBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGunBack.Location = new System.Drawing.Point(959, 388);
            this.btnGunBack.Name = "btnGunBack";
            this.btnGunBack.Size = new System.Drawing.Size(257, 61);
            this.btnGunBack.TabIndex = 54;
            this.btnGunBack.Text = "Recieve current gun back";
            this.btnGunBack.UseVisualStyleBackColor = true;
            this.btnGunBack.Click += new System.EventHandler(this.BtnGunBack_Click);
            // 
            // cbxShooters
            // 
            this.cbxShooters.FormattingEnabled = true;
            this.cbxShooters.Location = new System.Drawing.Point(961, 101);
            this.cbxShooters.Name = "cbxShooters";
            this.cbxShooters.Size = new System.Drawing.Size(257, 24);
            this.cbxShooters.TabIndex = 55;
            // 
            // cbxBand
            // 
            this.cbxBand.AutoSize = true;
            this.cbxBand.Location = new System.Drawing.Point(963, 131);
            this.cbxBand.Name = "cbxBand";
            this.cbxBand.Size = new System.Drawing.Size(63, 21);
            this.cbxBand.TabIndex = 56;
            this.cbxBand.Text = "Band";
            this.cbxBand.UseVisualStyleBackColor = true;
            // 
            // cbxRaiserBlock
            // 
            this.cbxRaiserBlock.AutoSize = true;
            this.cbxRaiserBlock.Location = new System.Drawing.Point(1032, 131);
            this.cbxRaiserBlock.Name = "cbxRaiserBlock";
            this.cbxRaiserBlock.Size = new System.Drawing.Size(98, 21);
            this.cbxRaiserBlock.TabIndex = 57;
            this.cbxRaiserBlock.Text = "RaiserBlok";
            this.cbxRaiserBlock.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(19, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(411, 29);
            this.lblWelcome.TabIndex = 58;
            this.lblWelcome.Text = "Welcome to the borrowing of guns";
            // 
            // lblChoices
            // 
            this.lblChoices.AutoSize = true;
            this.lblChoices.Location = new System.Drawing.Point(960, 81);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(229, 17);
            this.lblChoices.TabIndex = 59;
            this.lblChoices.Text = "Please make the appriote selection";
            // 
            // frmBorrowedGuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 649);
            this.Controls.Add(this.lblChoices);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cbxRaiserBlock);
            this.Controls.Add(this.cbxBand);
            this.Controls.Add(this.cbxShooters);
            this.Controls.Add(this.btnGunBack);
            this.Controls.Add(this.btnGunOut);
            this.Controls.Add(this.gbxOut);
            this.Controls.Add(this.gbxAvailableGuns);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.btnClose);
            this.Name = "frmBorrowedGuns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowed Guns";
            this.Load += new System.EventHandler(this.FrmBorrowedGuns_Load);
            this.gbxAvailableGuns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxAvailableGuns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxOut;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGunOut;
        private System.Windows.Forms.Button btnGunBack;
        private System.Windows.Forms.ComboBox cbxShooters;
        private System.Windows.Forms.CheckBox cbxBand;
        private System.Windows.Forms.CheckBox cbxRaiserBlock;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblChoices;
    }
}