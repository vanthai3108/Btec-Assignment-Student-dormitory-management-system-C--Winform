using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace SQL_ass1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;Initial Catalog = DormitoryManagement;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            // load dữ liệu của form
            // hien thi thong bao khi ket noi thanh cong, neu loi ket noi thi hien thi la loi ket noi
            try
            {
                conn.Open();
                conn.Close();
                txt_password.Text = "thai2001";
                txt_userName.Text = "thai2001";
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối thất bại!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txt_password.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText =
                "Select* from Account where UserName = '" + txt_userName.Text + "' "
                + "and Password = '" + hasPass + "'";
                SqlDataReader dta = command.ExecuteReader();
                if (dta.Read() == true)
                {
                    Form_Room a = new Form_Room();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !");
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đăng nhập!");
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            Form_SignUp b = new Form_SignUp();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
