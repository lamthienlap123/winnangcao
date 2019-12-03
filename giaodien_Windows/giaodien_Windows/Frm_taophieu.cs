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
using BAL;
namespace giaodien_Windows
{
    public partial class Frm_taophieu : DevExpress.XtraEditors.XtraForm
    {
        public Frm_taophieu()
        {
            InitializeComponent();
        }
        BALLapPhieu lp = new BALLapPhieu();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gdv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_madonhang.Text = dv_donhang.Rows[numrow].Cells[0].Value.ToString();
            dt_ngaynhan.Text = dv_donhang.Rows[numrow].Cells[1].Value.ToString();
            dt_ngaytra.Text = dv_donhang.Rows[numrow].Cells[2].Value.ToString();
            txt_thanhtien.Text = dv_donhang.Rows[numrow].Cells[4].Value.ToString();
            txt_ghichu.Text = dv_donhang.Rows[numrow].Cells[5].Value.ToString();
            cbo_nhanvien.Text = dv_donhang.Rows[numrow].Cells[6].Value.ToString();
            string makh = dv_donhang.Rows[numrow].Cells[7].Value.ToString();
            cbo_khachhang.DataSource = lp.getKHtheoma(makh);
            cbo_kho.Text = dv_donhang.Rows[numrow].Cells[8].Value.ToString();
            dv_ctdg.DataSource = lp.loadtheocbo(txt_madonhang.Text); 
        }
        private void gdv_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_soluong.Text = dv_ctdg.Rows[numrow].Cells[0].Value.ToString();
            cbo_DV.Text = dv_ctdg.Rows[numrow].Cells[1].Value.ToString();
        }
        private void Frm_taophieu_Load(object sender, EventArgs e)
        {
            cbo_DV.DataSource = lp.loadcbodichvu();
            cbo_DV.ValueMember = "MaDV";
            cbo_DV.DisplayMember = "TenDV";
            dv_ctdg.DataSource = lp.loadchitietdonhang();
            cbo_khachhang.DataSource = lp.LoadKhachHang();
            cbo_khachhang.DisplayMember = "TenKH";
            cbo_khachhang.ValueMember = "MaKH";
            cbo_kho.DataSource = lp.LoadKho();
            cbo_kho.DisplayMember = "TenKho";
            cbo_kho.ValueMember = "MaKho";
            cbo_nhanvien.DataSource = lp.LoadNhanVien();
            cbo_nhanvien.DisplayMember = "HoTen";
            cbo_nhanvien.ValueMember = "MaNV";
            dv_donhang.DataSource = lp.loaddonhang();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
            lp.themdonhang(txt_madonhang.Text, DateTime.Parse(dt_ngaynhan.DateTime.ToString()), DateTime.Parse(dt_ngaytra.DateTime.ToString()), false, float.Parse(txt_thanhtien.Text), txt_ghichu.Text, cbo_nhanvien.SelectedValue.ToString(), cbo_khachhang.SelectedValue.ToString(), cbo_kho.SelectedValue.ToString());
            dv_donhang.DataSource = lp.loaddonhang();
            
        }

        private void btn_xoaphieu_Click(object sender, EventArgs e)
        {
            lp.XoaDonHang(txt_madonhang.Text);
            dv_donhang.DataSource = lp.loaddonhang();
        }

        private void btn_suaphieu_Click(object sender, EventArgs e)
        {
            lp.SuaDonHang(txt_madonhang.Text, DateTime.Parse(dt_ngaynhan.DateTime.ToString()), DateTime.Parse(dt_ngaytra.DateTime.ToString()), false, float.Parse(txt_thanhtien.Text), txt_ghichu.Text, cbo_nhanvien.SelectedValue.ToString(), cbo_khachhang.SelectedValue.ToString(), cbo_kho.SelectedValue.ToString());
            dv_donhang.DataSource = lp.loaddonhang();
            Frm_taophieu_Load(sender, e);
        }

        private void btn_themcthd_Click(object sender, EventArgs e)
        {
            lp.themchitietdonhang(int.Parse(txt_soluong.Text), txt_madonhang.Text, cbo_DV.SelectedValue.ToString());
            dv_ctdg.DataSource = lp.loadtheocbo(txt_madonhang.Text);
        }

        private void btn_xoacthd_Click(object sender, EventArgs e)
        {
            lp.XoaCTDH(txt_madonhang.Text, cbo_DV.SelectedValue.ToString());
            dv_ctdg.DataSource = lp.loadtheocbo(txt_madonhang.Text);
        }

        private void btn_suacthd_Click(object sender, EventArgs e)
        {

        }

        private void cbo_DV_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = lp.LayGiaBan(cbo_DV.SelectedValue.ToString());
        }
    }
}