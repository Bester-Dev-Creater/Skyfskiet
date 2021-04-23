namespace Skyfskiet
{
    partial class frmShooters
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.lblParentEmail = new System.Windows.Forms.Label();
            this.lblParentNotes = new System.Windows.Forms.Label();
            this.txtShootername = new System.Windows.Forms.TextBox();
            this.txtShooterEmail = new System.Windows.Forms.TextBox();
            this.txtShooterID = new System.Windows.Forms.TextBox();
            this.txtShooterSurname = new System.Windows.Forms.TextBox();
            this.txtShooterNotes = new System.Windows.Forms.TextBox();
            this.txtParentName1 = new System.Windows.Forms.TextBox();
            this.txtParentEmail1 = new System.Windows.Forms.TextBox();
            this.txtParentPhone = new System.Windows.Forms.TextBox();
            this.cbxTripod = new System.Windows.Forms.CheckBox();
            this.cbxKneeRoll = new System.Windows.Forms.CheckBox();
            this.cbxMat = new System.Windows.Forms.CheckBox();
            this.cbxScope = new System.Windows.Forms.CheckBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.AllowUserToResizeColumns = false;
            this.dgvDisplay.AllowUserToResizeRows = false;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(8, 54);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(915, 310);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.DgvDisplay_SelectionChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(9, 371);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(181, 35);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(247, 370);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(181, 35);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(482, 371);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(738, 370);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(181, 35);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(273, 640);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(119, 63);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert new shooter";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(398, 640);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 63);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update currrent shooter";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(523, 640);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 63);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Remove current shooter";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(798, 714);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Exit Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMainForm
            // 
            this.btnMainForm.Location = new System.Drawing.Point(645, 714);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(147, 39);
            this.btnMainForm.TabIndex = 22;
            this.btnMainForm.Text = "Back to main form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.BtnMainForm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(148, 640);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 63);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear textboxes";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 416);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 444);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 12;
            this.lblSurname.Text = "Surname";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Location = new System.Drawing.Point(8, 472);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(75, 17);
            this.lblIDNum.TabIndex = 13;
            this.lblIDNum.Text = "ID Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 530);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(8, 558);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 17);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(392, 416);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(89, 17);
            this.lblParentName.TabIndex = 16;
            this.lblParentName.Text = "Parent name";
            // 
            // lblParentEmail
            // 
            this.lblParentEmail.AutoSize = true;
            this.lblParentEmail.Location = new System.Drawing.Point(392, 444);
            this.lblParentEmail.Name = "lblParentEmail";
            this.lblParentEmail.Size = new System.Drawing.Size(87, 17);
            this.lblParentEmail.TabIndex = 19;
            this.lblParentEmail.Text = "Parent email";
            // 
            // lblParentNotes
            // 
            this.lblParentNotes.AutoSize = true;
            this.lblParentNotes.Location = new System.Drawing.Point(392, 472);
            this.lblParentNotes.Name = "lblParentNotes";
            this.lblParentNotes.Size = new System.Drawing.Size(94, 17);
            this.lblParentNotes.TabIndex = 20;
            this.lblParentNotes.Text = "Parent phone";
            // 
            // txtShootername
            // 
            this.txtShootername.Location = new System.Drawing.Point(111, 418);
            this.txtShootername.MaxLength = 50;
            this.txtShootername.Name = "txtShootername";
            this.txtShootername.Size = new System.Drawing.Size(206, 22);
            this.txtShootername.TabIndex = 5;
            this.txtShootername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShootername_KeyPress);
            // 
            // txtShooterEmail
            // 
            this.txtShooterEmail.Location = new System.Drawing.Point(111, 530);
            this.txtShooterEmail.MaxLength = 50;
            this.txtShooterEmail.Name = "txtShooterEmail";
            this.txtShooterEmail.Size = new System.Drawing.Size(206, 22);
            this.txtShooterEmail.TabIndex = 9;
            this.txtShooterEmail.TextChanged += new System.EventHandler(this.TxtShooterEmail_TextChanged);
            this.txtShooterEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShooterEmail_KeyPress);
            // 
            // txtShooterID
            // 
            this.txtShooterID.Location = new System.Drawing.Point(111, 474);
            this.txtShooterID.MaxLength = 13;
            this.txtShooterID.Name = "txtShooterID";
            this.txtShooterID.Size = new System.Drawing.Size(206, 22);
            this.txtShooterID.TabIndex = 7;
            this.txtShooterID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShooterID_KeyPress);
            // 
            // txtShooterSurname
            // 
            this.txtShooterSurname.Location = new System.Drawing.Point(111, 446);
            this.txtShooterSurname.MaxLength = 50;
            this.txtShooterSurname.Name = "txtShooterSurname";
            this.txtShooterSurname.Size = new System.Drawing.Size(206, 22);
            this.txtShooterSurname.TabIndex = 6;
            this.txtShooterSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShooterSurname_KeyPress);
            // 
            // txtShooterNotes
            // 
            this.txtShooterNotes.Location = new System.Drawing.Point(111, 558);
            this.txtShooterNotes.MaxLength = 100;
            this.txtShooterNotes.Name = "txtShooterNotes";
            this.txtShooterNotes.Size = new System.Drawing.Size(206, 22);
            this.txtShooterNotes.TabIndex = 10;
            this.txtShooterNotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShooterNotes_KeyPress);
            // 
            // txtParentName1
            // 
            this.txtParentName1.Location = new System.Drawing.Point(523, 418);
            this.txtParentName1.MaxLength = 50;
            this.txtParentName1.Name = "txtParentName1";
            this.txtParentName1.Size = new System.Drawing.Size(213, 22);
            this.txtParentName1.TabIndex = 15;
            this.txtParentName1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtParentName_KeyPress);
            // 
            // txtParentEmail1
            // 
            this.txtParentEmail1.Location = new System.Drawing.Point(523, 446);
            this.txtParentEmail1.MaxLength = 50;
            this.txtParentEmail1.Name = "txtParentEmail1";
            this.txtParentEmail1.Size = new System.Drawing.Size(213, 22);
            this.txtParentEmail1.TabIndex = 16;
            // 
            // txtParentPhone
            // 
            this.txtParentPhone.Location = new System.Drawing.Point(523, 474);
            this.txtParentPhone.MaxLength = 100;
            this.txtParentPhone.Name = "txtParentPhone";
            this.txtParentPhone.Size = new System.Drawing.Size(213, 22);
            this.txtParentPhone.TabIndex = 17;
            this.txtParentPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtParentNotes_KeyPress);
            // 
            // cbxTripod
            // 
            this.cbxTripod.AutoSize = true;
            this.cbxTripod.Location = new System.Drawing.Point(111, 586);
            this.cbxTripod.Name = "cbxTripod";
            this.cbxTripod.Size = new System.Drawing.Size(71, 21);
            this.cbxTripod.TabIndex = 11;
            this.cbxTripod.Text = "Tripod";
            this.cbxTripod.UseVisualStyleBackColor = true;
            // 
            // cbxKneeRoll
            // 
            this.cbxKneeRoll.AutoSize = true;
            this.cbxKneeRoll.Location = new System.Drawing.Point(188, 586);
            this.cbxKneeRoll.Name = "cbxKneeRoll";
            this.cbxKneeRoll.Size = new System.Drawing.Size(91, 21);
            this.cbxKneeRoll.TabIndex = 12;
            this.cbxKneeRoll.Text = "Knee Roll";
            this.cbxKneeRoll.UseVisualStyleBackColor = true;
            // 
            // cbxMat
            // 
            this.cbxMat.AutoSize = true;
            this.cbxMat.Location = new System.Drawing.Point(111, 613);
            this.cbxMat.Name = "cbxMat";
            this.cbxMat.Size = new System.Drawing.Size(53, 21);
            this.cbxMat.TabIndex = 13;
            this.cbxMat.Text = "Mat";
            this.cbxMat.UseVisualStyleBackColor = true;
            // 
            // cbxScope
            // 
            this.cbxScope.AutoSize = true;
            this.cbxScope.Location = new System.Drawing.Point(188, 613);
            this.cbxScope.Name = "cbxScope";
            this.cbxScope.Size = new System.Drawing.Size(70, 21);
            this.cbxScope.TabIndex = 14;
            this.cbxScope.Text = "Scope";
            this.cbxScope.UseVisualStyleBackColor = true;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(111, 502);
            this.txtphone.MaxLength = 50;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(206, 22);
            this.txtphone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 502);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 38;
            this.lblPhone.Text = "Phone";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(9, 586);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(50, 17);
            this.lblExtra.TabIndex = 39;
            this.lblExtra.Text = "Extra\'s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Welcome to the shooter\'s overview";
            // 
            // frmShooters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 762);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.cbxScope);
            this.Controls.Add(this.cbxMat);
            this.Controls.Add(this.cbxKneeRoll);
            this.Controls.Add(this.cbxTripod);
            this.Controls.Add(this.txtParentPhone);
            this.Controls.Add(this.txtParentEmail1);
            this.Controls.Add(this.txtParentName1);
            this.Controls.Add(this.txtShooterNotes);
            this.Controls.Add(this.txtShooterSurname);
            this.Controls.Add(this.txtShooterID);
            this.Controls.Add(this.txtShooterEmail);
            this.Controls.Add(this.txtShootername);
            this.Controls.Add(this.lblParentNotes);
            this.Controls.Add(this.lblParentEmail);
            this.Controls.Add(this.lblParentName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblIDNum);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "frmShooters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooters";
            this.Load += new System.EventHandler(this.Shooters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblParentEmail;
        private System.Windows.Forms.Label lblParentNotes;
        private System.Windows.Forms.TextBox txtShootername;
        private System.Windows.Forms.TextBox txtShooterEmail;
        private System.Windows.Forms.TextBox txtShooterID;
        private System.Windows.Forms.TextBox txtShooterSurname;
        private System.Windows.Forms.TextBox txtShooterNotes;
        private System.Windows.Forms.TextBox txtParentName1;
        private System.Windows.Forms.TextBox txtParentEmail1;
        private System.Windows.Forms.TextBox txtParentPhone;
        private System.Windows.Forms.CheckBox cbxTripod;
        private System.Windows.Forms.CheckBox cbxKneeRoll;
        private System.Windows.Forms.CheckBox cbxMat;
        private System.Windows.Forms.CheckBox cbxScope;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Label label1;
    }
}