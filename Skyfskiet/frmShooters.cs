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
    public partial class frmShooters : Form
    {
        BindingSource bs = new BindingSource();
        List<Shooters> ShooterList = new List<Shooters>();
        //List<Parents> ParentList = new List<Parents>();

        public frmShooters()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtParentEmail1.Clear();
            txtphone.Clear();
            //txtParentID1.Clear();
            txtParentName1.Clear();
            txtParentPhone.Clear();
            //txtParentSurname1.Clear();
            //txtParentEmail2.Clear();
            //txtParentID2.Clear();
            //txtParentName2.Clear();
            //txtParentNotes2.Clear();
            //txtParentSurname2.Clear();
            txtShooterEmail.Clear();
            txtShooterID.Clear();
            txtShootername.Clear();
            txtShooterNotes.Clear();
            txtShooterSurname.Clear();
            cbxScope.Checked = false;
            cbxKneeRoll.Checked = false;
            cbxMat.Checked = false;
            cbxTripod.Checked = false;
        }

        private void BtnMainForm_Click(object sender, EventArgs e)
        {
            new frmWelcome().Show();
            this.Hide();
        }

        private void TxtShootername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtShooterSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtShooterID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtShooterNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TxtParentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TxtParentSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TxtParentNotes_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TxtParentID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TxtParentName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtParentSurname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtParentID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void Shooters_Load(object sender, EventArgs e)
        {
            Stufff();
        }

        public void Stufff()
        {
            ShooterList = new Shooters().ReadData();
            bs.DataSource = ShooterList;
            dgvDisplay.DataSource = bs;
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

        private void DgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            Shooters current = (Shooters)bs.Current;
            txtphone.Text = current.Phone;
            txtShooterEmail.Text = current.Email;
            txtShooterID.Text = current.IDNumber;
            txtShootername.Text = current.Name;
            txtShooterNotes.Text = current.Notes;
            txtShooterSurname.Text = current.Surname;
            cbxKneeRoll.Checked = current.KneeRoll;
            cbxMat.Checked = current.Mat;
            cbxScope.Checked = current.Scope;
            cbxTripod.Checked = current.Tripod;
            txtParentEmail1.Text = current.ParentEmail;
            txtParentName1.Text = current.ParentName;
            txtParentPhone.Text = current.ParentPhone;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            new Shooters().InsertShooter(txtShootername.Text,txtShooterSurname.Text,txtphone.Text,txtShooterID.Text,txtShooterEmail.Text,txtParentName1.Text,txtParentEmail1.Text,txtParentPhone.Text,txtShooterNotes.Text,cbxScope.Checked,cbxTripod.Checked,cbxMat.Checked,cbxKneeRoll.Checked);
            Stufff();
            bs.MoveLast();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Shooters temp = (Shooters)bs.Current;
            int shooterID = temp.ChildID;
            new Shooters().UpdateShooter(shooterID, txtShootername.Text, txtShooterSurname.Text, txtphone.Text,txtShooterID.Text, txtShooterEmail.Text, txtParentName1.Text, txtParentEmail1.Text, txtParentPhone.Text, txtShooterNotes.Text, cbxScope.Checked, cbxTripod.Checked, cbxMat.Checked, cbxKneeRoll.Checked);
            Stufff();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Shooters temp = (Shooters)bs.Current;
            int shooterID = temp.ChildID;
            new Shooters().DeleteShooter(shooterID);
            bs.MoveFirst();
            Stufff();
        }

        //Unused events
        private void TxtShooterEmail_TextChanged(object sender, EventArgs e) { }
        private void TxtShooterEmail_KeyPress(object sender, KeyPressEventArgs e) { }
        private void TxtParentID_TextChanged(object sender, EventArgs e) { }
    }
}
