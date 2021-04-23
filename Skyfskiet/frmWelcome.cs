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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit","Exit confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnAddShooter_Click(object sender, EventArgs e)
        {
            new frmShooters().Show();
            this.Hide();
        }

        private void BtnAddNewGun_Click(object sender, EventArgs e)
        {
            new frmGuns().Show();
            this.Hide();
        }
    }
}
