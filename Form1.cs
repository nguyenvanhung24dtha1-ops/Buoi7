using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVienCRUD
{
    public partial class Form1 : Form
    {
        private readonly StudentBUS _studentBUS = new StudentBUS();

        private Label lblTieuDe;
        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            label1 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(730, 30);
            lblTieuDe.TabIndex = 11;
            lblTieuDe.Text = "QUẢN LÝ SINH VIÊN - EF CORE (CRUD ĐẦY ĐỦ)";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 65);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(75, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(300, 23);
            txtHoTen.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 65);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Điểm:";
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(445, 62);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(80, 23);
            txtDiem.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 105);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 32);
            btnThem.TabIndex = 6;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(130, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 32);
            btnSua.TabIndex = 5;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 32);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(320, 105);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(120, 32);
            btnTaiLai.TabIndex = 3;
            btnTaiLai.Text = "🔄 Tải lại danh";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(450, 105);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(155, 32);
            btnLocDat.TabIndex = 2;
            btnLocDat.Text = "Lọc SV đạt (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.Location = new Point(20, 143);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(725, 230);
            dgvSinhVien.TabIndex = 1;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(25, 390);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(113, 15);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng thái: Sẵn sàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 420);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Controls.Add(lblTieuDe);
            Name = "Form1";
            Text = "Quản lý Sinh viên - EF Core CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Sẵn sàng kết nối dữ liệu.";
            await TaiDanhSach();
        }

        private async Task TaiDanhSach()
        {
            try
            {
                var danhSach = await _studentBUS.GetAllStudentsAsync();
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = danhSach;
                lblTrangThai.Text = $"Đã tải {danhSach.Count} sinh viên.";
                lblTrangThai.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is Student sv)
            {
                txtHoTen.Text = sv.FullName;
                txtDiem.Text = sv.Grade.ToString();
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                await _studentBUS.AddStudentAsync(txtHoTen.Text, txtDiem.Text);
                lblTrangThai.Text = "Đã thêm sinh viên mới!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student svDangChon)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await _studentBUS.UpdateStudentAsync(svDangChon.Id, txtHoTen.Text, txtDiem.Text);
                lblTrangThai.Text = "Đã cập nhật thông tin!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student svDangChon)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
            $"Bạn có chắc muốn xóa \"{svDangChon.FullName}\"?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes) return;

            try
            {
                await _studentBUS.DeleteStudentAsync(svDangChon.Id);
                lblTrangThai.Text = "Đã xóa sinh viên!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnLocDat_Click(object sender, EventArgs e)
        {
            try
            {
                var ketQua = await _studentBUS.GetPassedStudentsAsync();
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = ketQua;
                lblTrangThai.Text = $"Tìm thấy {ketQua.Count} sinh viên đạt (>=5).";
                lblTrangThai.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }
    }
}
