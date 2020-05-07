using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BanDoAn
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtPass.Focus();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() != "" && txtUser.Text.Trim() != "")
            {
                btnDangnhap.Enabled = true;
            }
            else { btnDangnhap.Enabled = false; }
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim()!= "" && txtUser.Text.Trim()!= "")
            {
                btnDangnhap.Enabled = true;
            }
            else { btnDangnhap.Enabled = false; }
        }
    }
}