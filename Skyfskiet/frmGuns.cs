using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Skyfskiet
{
    public partial class frmGuns : Form
    {
        public frmGuns()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();
        List<Guns> GunList = new List<Guns>();

        public void Stuff()
        {
            GunList = new Guns().ReadData();
            bs.DataSource = GunList;
            dgvDisplay.DataSource = bs;
        }

        private void FrmGuns_Load(object sender, EventArgs e)
        {
            Stuff();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //txtShootername.Clear();
            //txtDay.Clear();
            //txtMonth.Clear();
            //txtYear.Clear();
            //cbxBand.Checked = false;
            //cbxRaiserBlok.Checked = false;
        }

        private void BtnMainForm_Click(object sender, EventArgs e)
        {
            new frmWelcome().Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            txtComments.Clear();
            txtSerial.Clear();
            txtCondition.Clear();
            //txtDateAdded.Clear();
            txtManufacturer.Clear();
            txtModel.Clear();
            //txtRetired.Clear();
        }

        private void TxtManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtComments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            new Guns().InsertGunData(txtManufacturer.Text, txtModel.Text, txtCondition.Text, txtComments.Text,txtSerial.Text);
            bs.MoveLast();
            Stuff();
        }

        private void DgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            Guns current = (Guns)bs.Current;
            txtManufacturer.Text = current.Manufacturer;
            txtModel.Text = current.Model;
           // txtDateAdded.Text = current.DayAdded;
           // txtRetired.Text = current.DayRetired;
            txtComments.Text = current.Comments;
            txtCondition.Text = current.Condition;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Guns current = (Guns)bs.Current;
            int id = current.GunID;
            new Guns().UpdateData(id, txtManufacturer.Text, txtModel.Text, txtCondition.Text, txtComments.Text,txtSerial.Text);
            Stuff();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Guns current = (Guns)bs.Current;
            int id = current.GunID;
            new Guns().DeleteData(id);
            bs.MoveFirst();
            Stuff();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        //unused events
        private void TxtShootername_KeyPress(object sender, KeyPressEventArgs e) { }
        private void TxtDay_KeyPress(object sender, KeyPressEventArgs e) { }
        private void TxtMonth_KeyPress(object sender, KeyPressEventArgs e) { }
        private void TxtYear_KeyPress(object sender, KeyPressEventArgs e) { }
        private void TxtCondition_TextChanged(object sender, EventArgs e) { }

        private void BtnLend_Click(object sender, EventArgs e)
        {
            new frmBorrowedGuns().Show();
            this.Hide();

        }
    }
}
