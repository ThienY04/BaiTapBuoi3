using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Baibuoi3
{
    public partial class Form1 : Form
    {
        private DataTable employeeTable;
        public Form1()
        {
            InitializeComponent();
            InitializeEmployeeTable();
        }

        private void InitializeEmployeeTable()
        {
            employeeTable = new DataTable();
            employeeTable.Columns.Add("MSNV");
            employeeTable.Columns.Add("TenNV");
            employeeTable.Columns.Add("LuongCB");

            dataGridView1.DataSource = employeeTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Nhân_Viên form2 = new Nhân_Viên();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                DataRow newRow = employeeTable.NewRow();
                newRow["MSNV"] = form2.MSNV;
                newRow["TenNV"] = form2.TenNV;
                newRow["LuongCB"] = form2.LuongCB;
                employeeTable.Rows.Add(newRow);
            }
        }

        

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Nhân_Viên form2 = new Nhân_Viên();
                form2.MSNV = dataGridView1.CurrentRow.Cells["MSNV"].Value.ToString();
                form2.TenNV = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
                form2.LuongCB = dataGridView1.CurrentRow.Cells["LuongCB"].Value.ToString();


                if (form2.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.CurrentRow.Cells["MSNV"].Value = form2.MSNV;
                    dataGridView1.CurrentRow.Cells["TenNV"].Value = form2.TenNV;
                    dataGridView1.CurrentRow.Cells["LuongCB"].Value = form2.LuongCB;
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Nếu người dùng tự đóng form
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)

                {
                    e.Cancel = true; // Hủy bỏ việc đóng form
                }
            }
        }
    }
}




