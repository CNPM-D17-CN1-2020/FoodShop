using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDoAn
{
    public partial class FormNVQL : Form
    {
        public FormNVQL()
        {
            InitializeComponent();
            panel_hiện_chọn.Height = button_trang_chủ.Height;
            trangchuNVQL1.Top = button_trang_chủ.Top;
            trangchuNVQL1.BringToFront();
        }

        private void FormNVQL_Load(object sender, EventArgs e)
        {

        }


        private void taotaikhoan1_Load(object sender, EventArgs e)
        {

        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            panel_hiện_chọn.Height = button_trang_chủ.Height;
            trangchuNVQL1.Top = button_trang_chủ.Top;
            trangchuNVQL1.BringToFront();
        }

        private void button_tạo_tài_khoản_Click(object sender, EventArgs e)
        {
            panel_hiện_chọn.Height = button_tạo_tài_khoản.Height;
            taotaikhoan1.Top = button_tạo_tài_khoản.Top;
            taotaikhoan1.BringToFront();
        }
    }
}
