

oke rùi
Use DoAnCuoiKy

CREATE TABLE TaiKhoan
(
	IDNguoiDung INT PRIMARY KEY IDENTITY,
	TenDangNhap nvarchar(50) null,
	MatKhau nvarchar(50) null,
	LoaiNguoiDung nvarchar(30) null
);
SELECT *FROM TaiKhoan
DROP TABLE TaiKhoan

CREATE TABLE ThongTinKhachSan
(
	IDKhachSan INT PRIMARY KEY IDENTITY,
	TenKhachSan nvarchar(100) Null,
	DiaDiemKhachSan nvarchar(100)Null,
	Loai nvarchar(100)Null,
	MoTa nvarchar(500)Null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	HinhAnh3 IMAGE,
	HinhAnh4 IMAGE,
	IDChuKhachSan INT Foreign key References TaiKhoan(IDNguoiDung)
);
SELECT *FROM ThongTinKhachSan
DROP TABLE ThongTinKhachSan


CREATE TABLE ThongTinPhongCuaKhachSan
(
	TenPhong nvarchar(30) null,
	KichThuocPhong nvarchar(30) null,
	GiaPhong nvarchar (30) null,
	TienNghiPhongTam1 nvarchar (30) null,
	TienNghiPhongTam2 nvarchar (30) null,
	TienNghiPhongTam3 nvarchar (30) null,
	TienNghiPhongTam4 nvarchar (30) null,
	HuongTamNhin1 nvarchar (30) null,
	HuongTamNhin2 nvarchar (30) null,
	TienNghiPhong1 nvarchar (30) null,
	TienNghiPhong2 nvarchar (30) null,
	TienNghiPhong3 nvarchar (30) null,
	TienNghiPhong4 nvarchar (30) null,
	TienNghiPhong5 nvarchar (30) null,
	TienNghiPhong6 nvarchar (30) null,
	HutThuoc1 nvarchar (30) null,
	HutThuoc2 nvarchar (30) null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan)
);
SELECT *FROM ThongTinPhongCuaKhachSan
DROP TABLE ThongTinPhongCuaKhachSan
namespace QuanLyNhaTro
{
    public partial class frmDangNhap : Form
    {
        BusinessLayerTaiKhoan tkbusiness = new BusinessLayerTaiKhoan();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string err = "";
            // Thông tin ??ng nh?p (Tên ng??i dùng/ M?t kh?u)
            if (tkbusiness.DangNhap(ref err, txtTenNguoiDung.Text, txtMatKhau.Text.Trim()))
            {
                txtTenNguoiDung.ResetText();
                txtMatKhau.ResetText();
                txtTenNguoiDung.Focus();
                frmLoading ld = new frmLoading();
                ld.Show();
                //this.Close();
            }

            else // không ?úng thì xu?t ra thông báo!
            {
                MessageBox.Show(err, "Thông báo!");
                this.txtTenNguoiDung.ResetText();
                this.txtMatKhau.ResetText();
                this.txtTenNguoiDung.Focus();
            }
        }

        private void txtTenNguoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuy?n xu?ng nh?p M?t kh?u
            if (e.KeyChar == 13)
                txtMatKhau.Focus();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa Tên ng??i dùng và m?t kh?u
            this.txtTenNguoiDung.Clear();
            this.txtMatKhau.Clear();
            this.txtTenNguoiDung.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát kh?i FormDangNhap
            DialogResult traloi;
            traloi = MessageBox.Show("B?n có ch?c ch?n mu?n thoát không?", "Tr? l?i",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ??ng nh?p
            if (e.KeyChar == 13)
                btnDangNhap_Click(null, null);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\dangnhap.jpg"); //load hình back ground vào form
        }
    }
}
namespace QuanLyNhaTro
{
    public class BusinessLayerTaiKhoan
    {
        QuanLyNhaTroDataModel dbs = new QuanLyNhaTroDataModel();

        public List<TaiKhoan> LayTaiKhoan()
        {
            return dbs.TaiKhoans.ToList();
        }

        public bool DangNhap(ref string err, string TenNguoiDung, string MatKhau)
        {
            var tk = dbs.TaiKhoans.Where(x => x.TenNguoiDung == TenNguoiDung.Trim()).FirstOrDefault();
            if (tk == null)
            {
                err = "Tài kho?n không t?n t?i!";
                return false;
            }
            else if (tk.MatKhau.Trim() != MatKhau.Trim())
            {
                err = "M?t kh?u không ?úng!";
                return false;
            }
            else
            {
                return true;
            }
        }

        // Tài kho?n ?ã có ch?a
        public bool KiemTraTaiKhoan(ref string err, string TenNguoiDung)
        {
            var tk = dbs.TaiKhoans.Where(x => x.TenNguoiDung == TenNguoiDung.Trim()).FirstOrDefault();
            if (tk != null)
            {
                err = "Tài kho?n ?ã t?n t?i!";
                return true;
            }
            return false;
        }

        // Ki?m tra m?t kh?u c?
        public bool KiemTraMatKhau(ref string err, string TenNguoiDung, string MatKhauCu)
        {
            var tk = dbs.TaiKhoans.Where(x => x.TenNguoiDung == TenNguoiDung).FirstOrDefault();
            if (tk.MatKhau.Trim() != MatKhauCu.Trim())
            {
                err = "M?t kh?u c? không ?úng!";
                return true;
            }
            return false;
        }

        public bool ThemTaiKhoan(ref string err, string TenNguoiDung, string MatKhau)
        {
            bool flag = false;
            using (var dbContextTransaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    TaiKhoan tk = new TaiKhoan();
                    tk.TenNguoiDung = TenNguoiDung;
                    tk.MatKhau = MatKhau;

                    dbs.TaiKhoans.Add(tk);

                    dbs.SaveChanges();

                    dbContextTransaction.Commit();

                    flag = true;
                }

                catch (SqlException)
                {
                    err = "?ã x?y ra l?i khi thêm tài kho?n!";
                    dbContextTransaction.Rollback();
                }
                return flag;
            }
        }
        public bool XoaTaiKhoan(ref string err, string TenNguoiDung)
        {
            bool flag = false;
            // Linq
            var toDelete = dbs.TaiKhoans.Where(x => x.TenNguoiDung == TenNguoiDung).FirstOrDefault();
            using (var dbContextTransaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    if (toDelete != null)
                    {
dbs.TaiKhoans.Remove(toDelete);
                        dbs.SaveChanges();
                        dbContextTransaction.Commit();
                        flag = true;
                    }
                    else
                        err = "Không tìm th?y tài kho?n!";
                }
                catch (SqlException)
                {
                    err = "Không th? xoá tài kho?n!";
                    dbContextTransaction.Rollback();
                }
                return flag;
            }
        }

        public bool DoiMatKhau(ref string err, string TenNguoiDung, string MatKhauMoi)
        {
            bool flag = false;
            using (var dbContextTransaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    var tk = dbs.TaiKhoans.Where(x => x.TenNguoiDung == TenNguoiDung).FirstOrDefault();

                    tk.MatKhau = MatKhauMoi;
                    
                    dbs.SaveChanges();

                    dbContextTransaction.Commit();

                    flag = true;
                        
                }
                catch (SqlException)
                {
                    err = "?ã x?y ra l?i!";
                    dbContextTransaction.Rollback();
                }
            }
            return flag;
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows;
using ThesisManagement.Repositories;
using ThesisManagement.Views.Professor;
using ThesisManagement.Views.Shared;
using ThesisManagement.Views.Student;

namespace ThesisManagement.ViewModels
{
    public class LoginVM : ViewModelBase
    {
        private readonly IUserRepository _userRepo;

        private string email;

        private bool isLoading = false;
        private string loadingVisibility = "Hidden";

        public bool IsLoading
        {
            get
            {
                return isLoading;
            }
            set
            {
                isLoading = value;
                if (value)
                    LoadingVisibility = "Visible";
                else
                    LoadingVisibility = "Hidden";
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public string LoadingVisibility
        {
            get
            {
                return loadingVisibility;
            }
            set
            {
                loadingVisibility = value;
                OnPropertyChanged(nameof(LoadingVisibility));
            }
        }

        [EmailAddress(ErrorMessage = "B?n c?n nh?p email h?p l?")]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                ErrorMessage = "";
                OnPropertyChanged(nameof(Email));
            }
        }

        private SecureString password;

        [Required(ErrorMessage = "M?t kh?u không th? ?? tr?ng")]
        public SecureString Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                ErrorMessage = "";
                OnPropertyChanged(nameof(Password));
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }

            set
            {
                errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public ViewModelCommand LoginCommand { get; }
        public LoginVM()
        {
            _userRepo = new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLogin);
        }

        private bool CanExecuteLogin(object obj)
        {
            return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            IsLoading = true;
            if (ValidInfo())
            {
                var isUserValid = _userRepo.Authenticate(new NetworkCredential(email, password));
                if (isUserValid)
                {
var logicView = Application.Current.MainWindow as LoginView;

                    if (SessionInfo.Role == Role.Student)
                    {
                        ShowStudentWindow();
                    }
                    else if (SessionInfo.Role == Role.Professor)
                    {
                        ShowProfessorWindow();
                    }
                    else if (SessionInfo.Role == Role.Admin)
                    {
                        Console.WriteLine();
                    }
                    logicView.Close();
                }
            }
            ErrorMessage = "Thông tin ??ng nh?p không chính xác!";
            IsLoading = false;
        }

        private bool ValidInfo()
        {
            var isValid = Password != null && Password.Length > 0 && ValidEmail(email);
            return isValid;
        }

        private bool ValidEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new System.Globalization.IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void ShowProfessorWindow()
        {
            ProfessorMainView professorMainView = new();
            Application.Current.MainWindow = professorMainView;
            professorMainView.Show();
        }

        private void ShowStudentWindow()
        {
            StudentMainView wd = new();
            Application.Current.MainWindow = wd;
            wd.Show();
        }
    }
}
public void LoadDataTimKiem(FlowLayoutPanel flpTrangChu, string dd)
{
    List<UCThongTinPhong> thongTinPhongList = new List<UCThongTinPhong>();
    try
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
        connection.Open();
        string query = "SELECT TenKhachSan, DiaDiemKhachSan, Loai, MoTa FROM ThongTinKhachSan WHERE DiaDiemKhachSan = @dd";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@dd", dd);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            UCThongTinPhong uc = new UCThongTinPhong();                                                       
            uc.txtTenKhachSan.Text = reader[0].ToString();
            uc.txtDiaDiem.Text = reader[1].ToString();
            uc.loai = reader[2].ToString();
            uc.mota = reader[3].ToString();                   
            thongTinPhongList.Add(uc);
        }
        reader.Close();
        connection.Close();
        foreach (UCThongTinPhong uc in thongTinPhongList)
        {
            flpTrangChu.Controls.Add(uc);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
public void load(TaiKhoan tK, DataConnection dB, string dd)
{
    try
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
        connection.Open();
        string query = "SELECT * FROM TaiKhoan Where LoaiNguoiDung = @dd";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@dd", dd);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            tK.iD = (int)reader[0];
            tK.tenDangNhap = reader[1].ToString();
            tK.matKhau = reader[2].ToString();
            tK.loaiNguoiDung = reader[3].ToString();
        }
        reader.Close();
        connection.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
}
string dd = txtLoai.Text;
tKDao.load(tK, dB, dd);
if(txtTenDangNhap.Text == tK.TenDangNhap)
{
    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
}
public int iD;
public string tenDangNhap;
public string matKhau;
public string loaiNguoiDung;
public TaiKhoan() { }
public TaiKhoan(int iD, string tenDangNhap, string matKhau, string loaiNguoiDung) 
{
    this.iD = iD;
    this.tenDangNhap = tenDangNhap;
    this.matKhau = matKhau;
    this.loaiNguoiDung = loaiNguoiDung;
}

public int ID
{
    get { return iD; }
    set { iD = value; }
}
public string TenDangNhap
{ get { return tenDangNhap; } set {  tenDangNhap = value; } }

public string MatKhau
{  get { return matKhau; } set { matKhau = value; } }
public string LoaiNguoiDung
{
    get { return loaiNguoiDung; }
    set { loaiNguoiDung = value; }
}
Use DoAnCuoiKy

CREATE TABLE TaiKhoan
(
	IDNguoiDung INT PRIMARY KEY,
	TenDangNhap nvarchar(max) null,
	MatKhau nvarchar(max) null,
	LoaiNguoiDung nvarchar(max) null
);
SELECT *FROM TaiKhoan
DROP TABLE TaiKhoan

insert into TaiKhoan values
(1,'admin','admin','admin');
insert into TaiKhoan values
(2,'user','user','user');


CREATE TABLE ThongTinKhachSan
(
	IDKhachSan INT PRIMARY KEY IDENTITY,
	TenKhachSan nvarchar(max) Null,
	DiaDiemKhachSan nvarchar(max)Null,
	Loai nvarchar(max)Null,
	MoTa nvarchar(max)Null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	HinhAnh3 IMAGE,
	HinhAnh4 IMAGE,
	IDChuKhachSan INT Foreign key References TaiKhoan(IDNguoiDung)
);
SELECT *FROM ThongTinKhachSan
DROP TABLE ThongTinKhachSan


CREATE TABLE ThongTinPhongCuaKhachSan
(
	IDPhong INT PRIMARY KEY IDENTITY,
	TenPhong nvarchar(max) null,
	KichThuocPhong nvarchar(max) null,
	GiaPhong nvarchar (max) null,
	TienNghiPhongTam1 nvarchar (max) null,
	TienNghiPhongTam2 nvarchar (max) null,
	TienNghiPhongTam3 nvarchar (max) null,
	TienNghiPhongTam4 nvarchar (max) null,
	HuongTamNhin1 nvarchar (max) null,
	HuongTamNhin2 nvarchar (max) null,
	TienNghiPhong1 nvarchar (max) null,
	TienNghiPhong2 nvarchar (max) null,
	TienNghiPhong3 nvarchar (max) null,
	TienNghiPhong4 nvarchar (max) null,
	TienNghiPhong5 nvarchar (max) null,
	TienNghiPhong6 nvarchar (max) null,
	HutThuoc1 nvarchar (max) null,
	HutThuoc2 nvarchar (max) null,
	UuDai nvarchar (max) null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan)
);
SELECT *FROM ThongTinPhongCuaKhachSan
DROP TABLE ThongTinPhongCuaKhachSan
