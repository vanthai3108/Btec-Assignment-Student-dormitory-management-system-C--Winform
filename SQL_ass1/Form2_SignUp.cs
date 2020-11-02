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
    public partial class Form_SignUp : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                               Initial Catalog = DormitoryManagement;
                                               Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txt_password.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            conn.Open();
            try
            {               
                command = conn.CreateCommand();
                command.CommandText = 
                "INSERT INTO Account(UserName, PassWord, LastName, FirstName, " +
                "DateOfBirth, Gender, PhoneNumber, EmailAddress) "+
                "VALUES (N'" + txt_userName.Text + "', N'"
                               + hasPass + "', N'"
                               + txt_lastName.Text + "', N'"
                               + txt_firstName.Text + "', N'"
                               + dtp_dateOfBirth.Value + "', N'"
                               + gender + "', N'"
                               + txt_phoneNumber.Text + "', N'"
                               + txt_emailAddress.Text + "')";
                command.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công", "Thông báo");
                Form_Login f = new Form_Login();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            conn.Close();
        }

        string gender;
        private void rdb_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdb_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
