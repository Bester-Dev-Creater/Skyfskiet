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
    public partial class frmBorrowedGuns : Form
    {
        public frmBorrowedGuns()
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

        private void BtnMainForm_Click(object sender, EventArgs e)
        {
            new frmWelcome().Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        BindingSource bsAvailGuns = new BindingSource();
        BindingSource bsGunsOut = new BindingSource();
        BindingSource bsShooter = new BindingSource();

        List<Guns> AvailableGunList = new List<Guns>();
        List<GunsBorrowed> GunsOutList = new List<GunsBorrowed>();
        List<Shooters> ShooterList = new List<Shooters>();
        private void FrmBorrowedGuns_Load(object sender, EventArgs e)
        {
       
            stuff();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGunOut_Click(object sender, EventArgs e)
        {
            Guns currentGun = (Guns)bsAvailGuns.Current;
            int id = ((Shooters)cbxShooters.SelectedItem).ChildID;
            string date = DateTime.Today.ToString("dd/MM/yyyy");
            new GunsBorrowed().Insert(currentGun.GunID,cbxBand.Checked,cbxRaiserBlock.Checked,id,date);
            stuff();
        }

        private void BtnGunBack_Click(object sender, EventArgs e)
        {
            GunsBorrowed currentGun = (GunsBorrowed)bsGunsOut.Current;
            int id = currentGun.GunID;

            new GunsBorrowed().delete(id);

            stuff();
        }

        public void stuff()
        {

            AvailableGunList = new GunsBorrowed().AvailableGuns();
            bsAvailGuns.DataSource = AvailableGunList;
            dataGridView1.DataSource = bsAvailGuns;

            GunsOutList = new GunsBorrowed().ReadData();
            bsGunsOut.DataSource = GunsOutList;
            dataGridView2.DataSource = bsGunsOut;

            ShooterList = new Shooters().ReadData();
            bsShooter.DataSource = ShooterList;
            cbxShooters.DataSource = bsShooter;

            cbxShooters.DisplayMember = "Name";
        }
    }
}
