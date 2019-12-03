﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;

namespace giaodien_Windows
{
    public partial class Frm_nhanvien : Form
    {
        public Frm_nhanvien()
        {
            InitializeComponent();
        }
        BALNhanVien nv = new BALNhanVien();

        private void Frm_nhanvien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.LoadNhanVien();
        }
        private void btn_them_click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(rdo_nam.Checked == true)
            {
                nv.ThemNhanVien(txt_manv.Text, txt_hoten.Text, "Nam",DateTime.Parse(date_ngaysinh.DateTime.ToString()),txt_diachi.Text,txt_sdt.Text,txt_sdt.Text,DateTime.Parse(date_ngayvaolam.DateTime.ToString()),txt_cmnd.Text);
                dataGridView1.DataSource = nv.LoadNhanVien();
            }
            if(rdo_nu.Checked == true)
            {
                nv.ThemNhanVien(txt_manv.Text, txt_hoten.Text, "Nữ", DateTime.Parse(date_ngaysinh.DateTime.ToString()), txt_diachi.Text, txt_sdt.Text, txt_sdt.Text, DateTime.Parse(date_ngayvaolam.DateTime.ToString()), txt_cmnd.Text);
                dataGridView1.DataSource = nv.LoadNhanVien();
            }
        }
        private void btn_xoa_click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nv.XoaNhanVien(txt_manv.Text);
            dataGridView1.DataSource = nv.LoadNhanVien();
        }
        private void btn_sua_click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rdo_nam.Checked == true)
            {
                nv.SuaNhanVien(txt_manv.Text, txt_hoten.Text,"Nam",DateTime.Parse(date_ngaysinh.DateTime.ToString()), txt_diachi.Text, txt_sdt.Text, txt_sdt.Text, DateTime.Parse(date_ngayvaolam.DateTime.ToString()), txt_cmnd.Text);
                dataGridView1.DataSource = nv.LoadNhanVien();
            }
            if (rdo_nu.Checked == true)
            {
                nv.SuaNhanVien(txt_manv.Text, txt_hoten.Text,"Nữ", DateTime.Parse(date_ngaysinh.DateTime.ToString()), txt_diachi.Text, txt_sdt.Text, txt_sdt.Text, DateTime.Parse(date_ngayvaolam.DateTime.ToString()), txt_cmnd.Text);
                dataGridView1.DataSource = nv.LoadNhanVien();
            }
        }
        private void gdv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_manv.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txt_hoten.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            if (dataGridView1.Rows[numrow].Cells[2].Value.ToString() == "Nam")
            {
                rdo_nam.Checked = true;
                rdo_nu.Checked = false;
            }
            else
            {
                rdo_nam.Checked = false;
                rdo_nu.Checked = true;
            }
            date_ngaysinh.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
            txt_email.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
            date_ngayvaolam.Text = dataGridView1.Rows[numrow].Cells[7].Value.ToString();
            txt_cmnd.Text = dataGridView1.Rows[numrow].Cells[8].Value.ToString();

        }
    }
}
