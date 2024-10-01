using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baibuoi3
{
    public partial class Nhân_Viên : Form
    {
        public Nhân_Viên()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

            txtMsnv.Text        = MSNV;
            txtTenNhanVien.Text = TenNV;
            txtLuongcb.Text     = LuongCB;
        }
        private void btnDongy_Click_1(object sender, EventArgs e)
        {
            MSNV = txtMsnv.Text;
            TenNV = txtTenNhanVien.Text;
            LuongCB = txtLuongcb.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Nhân_Viên_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)

                {
                    e.Cancel = true; 
                }
            }
        }
    }
}

