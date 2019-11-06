using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG32019.service;
using AppG32019.model;
namespace AppG32019
{
    public partial class Form3 : Form
    {
        private string pathDataStudent;
        public Form3(string idStudent)
        {
            InitializeComponent();
            picAnhDaiDien.AllowDrop = true;
            dtgQTHT.AutoGenerateColumns = false;
            pathDataStudent = Application.StartupPath + "\\Data" + "\\student.husc"; // hoặc @"\Data" + "\student.husc"
            // var student = StudentService.GetStudent(idStudent);
            var student = StudentService.GetStudent(pathDataStudent,idStudent);
            var qtht = LearningHistoryService.GetList(idStudent);
            if (student != null)
            {
                txtMsv.Text = student.Id;
                txtHo.Text = student.FirstName;
                txtTen.Text = student.LastName;
                dtpNgaySinh.Value = student.DateOfBirth;
                txtNoiSinh.Text = student.PlaceOfBirth;
                cbbGioiTinh.SelectedIndex = (int)student.Gender;

                student.ListLearningHistory = LearningHistoryService.GetList(idStudent);
                dtgQTHT.DataSource = student.ListLearningHistory;
                tssTong.Text = student.ListLearningHistory.Count().ToString();

            }
            else
            {
                throw new Exception("sinh vien nay ko ton tai");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chonAnhDaiDien();
        }

        private void picAnhDaiDien_DoubleClick(object sender, EventArgs e)
        {
            chonAnhDaiDien();
        }
        /// <summary>
        /// Chọn ảnh đại diện OpenFileDialog
        /// </summary>
        private void chonAnhDaiDien()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //lọc dialog:
            dialog.Filter = "File ảnh (*.png,*jpg)|*.png;*.jpg";
            dialog.Title = "chọn ảnh đại diện";
            //trả result:
            var rs = dialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                picAnhDaiDien.Image = Image.FromFile(fileName);
            }
        }

        private void picAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var listFileName =(string[])e.Data.GetData(DataFormats.FileDrop);
            var fileName = listFileName.FirstOrDefault();
            picAnhDaiDien.Image = Image.FromFile(fileName);
        }
    }
}
