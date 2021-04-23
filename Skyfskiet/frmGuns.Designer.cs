namespace Skyfskiet
{
    partial class frmGuns
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
            this.btnMainForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManufactured = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.AllowUserToOrderColumns = true;
            this.dgvDisplay.AllowUserToResizeColumns = false;
            this.dgvDisplay.AllowUserToResizeRows = false;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 58);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(912, 280);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.DgvDisplay_SelectionChanged);
            // 
            // btnMainForm
            // 
            this.btnMainForm.Location = new System.Drawing.Point(641, 566);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(147, 39);
            this.btnMainForm.TabIndex = 14;
            this.btnMainForm.Text = "Back to main form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.BtnMainForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(794, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Exit Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(737, 343);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(181, 35);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(481, 344);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(246, 343);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(181, 35);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(8, 344);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(181, 35);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(141, 424);
            this.txtModel.MaxLength = 50;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(206, 22);
            this.txtModel.TabIndex = 5;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModel_KeyPress);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(141, 452);
            this.txtCondition.MaxLength = 13;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(206, 22);
            this.txtCondition.TabIndex = 6;
            this.txtCondition.TextChanged += new System.EventHandler(this.TxtCondition_TextChanged);
            this.txtCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCondition_KeyPress);
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(141, 396);
            this.txtManufacturer.MaxLength = 50;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(206, 22);
            this.txtManufacturer.TabIndex = 4;
            this.txtManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtManufacturer_KeyPress);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(5, 452);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(67, 17);
            this.lblCondition.TabIndex = 60;
            this.lblCondition.Text = "Condition";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(5, 424);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 59;
            this.lblModel.Text = "Model";
            // 
            // lblManufactured
            // 
            this.lblManufactured.AutoSize = true;
            this.lblManufactured.Location = new System.Drawing.Point(5, 401);
            this.lblManufactured.Name = "lblManufactured";
            this.lblManufactured.Size = new System.Drawing.Size(92, 17);
            this.lblManufactured.TabIndex = 58;
            this.lblManufactured.Text = "Manufacturer";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(141, 480);
            this.txtComments.MaxLength = 100;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(206, 22);
            this.txtComments.TabIndex = 7;
            this.txtComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComments_KeyPress);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(5, 480);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(74, 17);
            this.lblComments.TabIndex = 64;
            this.lblComments.Text = "Comments";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 63);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear textboxes";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 542);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 63);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Remove current gun";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 542);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 63);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update currrent gun";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(131, 542);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(119, 63);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert new gun";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(433, 401);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(181, 35);
            this.btnLend.TabIndex = 13;
            this.btnLend.Text = "Borrowed Gun Info";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.BtnLend_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(141, 508);
            this.txtSerial.MaxLength = 100;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(206, 22);
            this.txtSerial.TabIndex = 8;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(5, 508);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(98, 17);
            this.lblSerial.TabIndex = 71;
            this.lblSerial.Text = "Serial Number";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(433, 32);
            this.lblWelcome.TabIndex = 72;
            this.lblWelcome.Text = "Welcome to the gun\'s overview";
            // 
            // frmGuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 615);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufactured);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "frmGuns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guns";
            this.Load += new System.EventHandler(this.FrmGuns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManufactured;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblWelcome;
    }
}