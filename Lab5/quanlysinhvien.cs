using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5.BUS;
using Lab5.DAL.NewFolder1;

namespace Lab5
{
    public partial class quanlysinhvien : Form
    {
        private readonly Studentservice studentservice = new Studentservice();
        private readonly Facultyservice Facultyservice = new Facultyservice();

        public quanlysinhvien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbmsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void quanlysinhvien_Load(object sender, EventArgs e)
        {
            cmbkhoa.SelectedIndex = 0;
            try
            {
                setGridViewStyle(dgvsinhvien);
                var listFacultys = Facultyservice.GetAll();
                var listStudents = studentservice.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAvatar_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            String imagePath = "";
            try
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = " Chọn hình ảnh sinh viên ";
                fileOpen.Filter = "Hình ảnh(*.jpg; *.jpeg; *.png)| *.jpg; *.jpeg; *.png | All files(*.*) | *.* ";
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = fileOpen.FileName;
                    picAvatar.Image = Image.FromFile(imageLocation);
                    imagePath = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Lỗi không thể upload ảnh! ", " Lỗi ", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
            }
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
         
            cmbkhoa.DataSource = listFacultys;
            cmbkhoa.DisplayMember = "FacultyName";
            cmbkhoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvsinhvien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvsinhvien.Rows.Add();
                dgvsinhvien.Rows[index].Cells[0].Value = item.StudentID;
                dgvsinhvien.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvsinhvien.Rows[index].Cells[2].Value =
                    item.Faculty.FacultyName;
                dgvsinhvien.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvsinhvien.Rows[index].Cells[4].Value = item.Major.Name + "";
                //   ShowAvatar(item.Avatar);
            }
        }
        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chdangki_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chdangki.Checked)
                listStudents = studentservice.GetAllHasNoMajor();
            else
                listStudents = studentservice.GetAll();
            BindGrid(listStudents);
        }

        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvsinhvien.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
                {
                    dgvsinhvien.CurrentRow.Selected = true;
                    tbmsv.Text = dgvsinhvien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbht.Text = dgvsinhvien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cmbkhoa.SelectedItem = dgvsinhvien.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    tbdtb.Text = dgvsinhvien.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                picAvatar.Image = null;
            }
            else
            {
                string parentDirectory =
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName
                ;
                string imagePath = Path.Combine(parentDirectory, "Images",
                ImageName);
                picAvatar.Image = Image.FromFile(imagePath);
                picAvatar.Refresh();
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
       
        }


        private bool CheckData()
        {
            if(tbmsv.Text=="" || tbht.Text ==""  || tbdtb.Text== "")
            {
                MessageBox.Show("Vui long nhap day du thong tin", "Thong Bao", MessageBoxButtons.OK);
                return false;
            }else if(tbmsv.TextLength != 10)
            {
                MessageBox.Show("Vui long nhap ma so sinh vien du 10 ky tu", "Thong Bao", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void tbmsv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }
        private bool checkDulStudentID(string msv)
        {
            // Kiểm tra xem mã sinh viên đã tồn tại trong hệ thống hay chưa.
            var student = studentservice.FindByID(msv);
            if (student != null)
            {
                return true;
            }
            return false;
        }

 
        private bool CheckData(string msv, string ht, string dtb)
        {
            // Kiểm tra mã sinh viên.
            if (msv.Length == 0)
            {
                return false;
            }

            // Kiểm tra họ tên.
            if (ht.Length == 0)
            {
                return false;
            }

            // Kiểm tra điểm trung bình.
            if (dtb.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string id = tbmsv.Text.Trim();

            Student stuUpdate = studentservice.FindByID(id);

            btnxoa.Enabled = false;
            string pathImage = picAvatar.Text.Trim();



            if (CheckData(tbmsv.Text.Trim(), tbht.Text.Trim(), tbdtb.Text.Trim()))
            {
                if (checkDulStudentID(tbmsv.Text))
                {
                    
                    if (stuUpdate != null)
                    {
                        stuUpdate.FullName = tbmsv.Text.Trim();
                        stuUpdate.AverageScore = double.Parse(tbdtb.Text);
                        stuUpdate.FacultyID = int.Parse(cmbkhoa.SelectedValue.ToString());
                        if (!string.IsNullOrEmpty(pathImage) && File.Exists(pathImage))
                        {
                            string imageName = tbmsv.Text.Trim().ToString() + "." + Path.GetExtension(pathImage).TrimStart('.');
                            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                            string imagePath = Path.Combine(parentDirectory, "Images");
                            if (!Directory.Exists(imagePath))
                            {
                                Directory.CreateDirectory(imagePath);
                            }
                            string imageDestinationPath = Path.Combine(imagePath, imageName);
                            File.Copy(pathImage, imageDestinationPath, true);
                            stuUpdate.Avatar = imageName;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi upload hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        studentservice.InsertUpdate(stuUpdate);
                        dgvsinhvien.Refresh();
                        dgvsinhvien.Rows.Clear();
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnxoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(pathImage) && File.Exists(pathImage))
                    {
                        string imageName = tbmsv.Text.Trim().ToString() + "." + Path.GetExtension(pathImage).TrimStart('.');
                        // Kiểm tra xem thư mục "Images" có tồn tại không, nếu không, tạo mới
                        string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                        string imagePath = Path.Combine(parentDirectory, "Images");
                        if (!Directory.Exists(imagePath))
                        {
                            Directory.CreateDirectory(imagePath);
                        }
                        string imageDestinationPath = Path.Combine(imagePath, imageName);
                        // Copy image gốc sang thư mục Images
                        File.Copy(pathImage, imageDestinationPath, true);
                        Student stu = new Student()
                        {
                            StudentID = tbmsv.Text,
                            FullName = tbht.Text,
                            FacultyID = int.Parse(cmbkhoa.SelectedValue.ToString()),
                            AverageScore = Convert.ToDouble(tbdtb.Text),
                            Avatar = imageName
                        };

                        studentservice.InsertUpdate(stuUpdate);
                        dgvsinhvien.Refresh();
                        dgvsinhvien.Rows.Clear();
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnxoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi upload hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

       
    }
}
