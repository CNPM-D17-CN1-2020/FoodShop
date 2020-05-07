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
    public partial class FormDangKy : DevExpress.XtraEditors.XtraForm
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công");
          
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
           
        }

        private void txtSodienthoai_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "" && txtMatkhau.Text.Trim() != "" && txtSodienthoai.Text.Trim() != "" && txtReMatkhau.Text.Trim() != "" && txtXa.Text.Trim() != "")
            {
                btnDongy.Enabled = true;
            }
            else btnDongy.Enabled = false;
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "" && txtMatkhau.Text.Trim() != "" && txtSodienthoai.Text.Trim() != "" && txtReMatkhau.Text.Trim() != "" && txtXa.Text.Trim() != "")
            {
                btnDongy.Enabled = true;
            }
            else btnDongy.Enabled = false;
        }

        private void txtMatkhau_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "" && txtMatkhau.Text.Trim() != "" && txtSodienthoai.Text.Trim() != "" && txtReMatkhau.Text.Trim() != "" && txtXa.Text.Trim() != "")
            {
                btnDongy.Enabled = true;
            }
            else btnDongy.Enabled = false;
        }

        private void txtReMatkhau_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "" && txtMatkhau.Text.Trim() != "" && txtSodienthoai.Text.Trim() != "" && txtReMatkhau.Text.Trim() != "" && txtXa.Text.Trim() != "")
            {
                btnDongy.Enabled = true;
            }
            else btnDongy.Enabled = false;
        }

        private void txtXa_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "" && txtMatkhau.Text.Trim() != "" && txtSodienthoai.Text.Trim() != "" && txtReMatkhau.Text.Trim() != "" && txtXa.Text.Trim() != "")
            {
                btnDongy.Enabled = true;
            }
            else btnDongy.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}