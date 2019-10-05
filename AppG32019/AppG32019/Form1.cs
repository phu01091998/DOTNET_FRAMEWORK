using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG32019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                errProvider.Clear();
                double temp = 0;
                if (!double.TryParse(txtSoThuNhat.Text, out temp)&& !double.TryParse(txtSoThuHai.Text, out temp))
                {
                    //MessageBox.Show("Cả hai số bạn nhập không đúng định dạng!");
                    errProvider.SetError(txtSoThuNhat, "Số thứ nhất bạn nhập không đúng định dạng!");
                    errProvider.SetError(txtSoThuHai, "Số thứ hai bạn nhập không đúng định dạng!");
                    txtSoThuNhat.Focus();
                    return;
                }
                if (!double.TryParse(txtSoThuNhat.Text, out temp))
                {
                    //MessageBox.Show("Số thứ nhất bạn nhập không đúng định dạng!");
                    errProvider.SetError(txtSoThuNhat, "Số thứ nhất bạn nhập không đúng định dạng!");
                    txtSoThuNhat.Focus();
                    return;
                }
                if (!double.TryParse(txtSoThuHai.Text, out temp))
                {
                    //MessageBox.Show("Số thứ hai bạn nhập không đúng định dạng!");
                    errProvider.SetError(txtSoThuNhat, "Số thứ hai bạn nhập không đúng định dạng!");
                    txtSoThuNhat.Focus();
                    return;
                }
                var soThuNhat = double.Parse(txtSoThuNhat.Text);
                var soThuHai = double.Parse(txtSoThuHai.Text);
                var tong = soThuNhat + soThuHai;
                var chuoiKetQua = string.Format("Tổng của {0} và {1} là: {2}", soThuNhat, soThuHai, tong);
                MessageBox.Show(chuoiKetQua);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!\n" + ex.Message);
            }
        }
    }
}
