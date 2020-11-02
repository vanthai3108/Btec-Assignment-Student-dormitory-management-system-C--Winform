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

namespace SQL_ass1
{
    public partial class Form_Student : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                               Initial Catalog = DormitoryManagement;
                                               Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        public Form_Student()
        {
            InitializeComponent();
        }

        void loadStudent()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText =
                "SELECT StudentID, StudentName, Age, Gender, Address, PhoneNumber, ClassName, RoomName"
                + " FROM Student, Room, Class"
                + " WHERE Student.ClassID = Class.ClassID and Student.RoomID = Room.RoomID";

            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "Student");
            dgv_student.DataSource = ds.Tables["Student"];
            conn.Close();
        }

        public void Load_cbb_room()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select RoomName, RoomID From Room", conn);
            da.Fill(dt);
            conn.Close();
            cbb_roomName.DataSource = dt.Copy();
            cbb_roomName.DisplayMember = "RoomName";
            cbb_roomName.ValueMember = "RoomID";
        }
        public void Load_cbb_class()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select ClassName, ClassID From Class", conn);
            da.Fill(dt);
            conn.Close();
            cbb_className.DataSource = dt.Copy();
            cbb_className.DisplayMember = "ClassName";
            cbb_className.ValueMember = "ClassID";
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            loadStudent();
            Load_cbb_class();
            Load_cbb_room();
        }

        private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void classToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Class a = new Form_Class();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void roomToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Room a = new Form_Room();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void dormitoryManagerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_DormitoryManager a = new Form_DormitoryManager();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void rentalContractToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_RentalContract a = new Form_RentalContract();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void contractManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Contract_Manager a = new Form_Contract_Manager();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void roomManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Room_Manager a = new Form_Room_Manager();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", 
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
        }

        string b;
        private void rdb_male_CheckedChanged(object sender, EventArgs e)
        {
            b = "Male";
        }

        private void rdb_female_CheckedChanged(object sender, EventArgs e)
        {
            b = "Female";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Student WHERE StudentID = " + txt_studentID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadStudent();
        }

        private void btn_studentName_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = 
                    "SELECT StudentID, StudentName, Age, Gender, Address, PhoneNumber, ClassName, RoomName"
                    + " FROM Student, Room, Class"
                    + " WHERE Student.ClassID = Class.ClassID and"
                    + "Student.RoomID = Room.RoomID and StudentName like '%"
                    + txt_studentName_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "Student");
                dgv_student.DataSource = ds.Tables["Student"];
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo");
            }
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = 
                    "INSERT INTO Student(StudentID, StudentName, Age, Gender, PhoneNumber, Address, ClassID, RoomID)"
                    + "VALUES (N'" + txt_studentID.Text 
                    + "', N'" + txt_studentName.Text 
                    + "', N'" + txt_age.Text 
                    + "', N'" + b 
                    + "', N'" + txt_phoneNumber.Text 
                    + "', N'" + txt_address.Text 
                    + "', N'"+ cbb_className.SelectedValue.ToString() 
                    + "', N'"+ cbb_roomName.SelectedValue.ToString() + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Add thất bại", "Thông báo");
            }
            conn.Close();
            loadStudent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = 
                    "UPDATE Student SET StudentName = '" + txt_studentName.Text
                    + "', Age = '" + txt_age.Text
                    + "', Gender = '" + b
                    + "', PhoneNumber = '" + txt_phoneNumber.Text
                    + "', Address = '" + txt_address.Text                                                   
                    + "', ClassID = '" + cbb_className.SelectedValue.ToString()
                    + "', RoomID = '" + cbb_roomName.SelectedValue.ToString()
                    + "' where StudentID = " + txt_studentID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Update thất bại", "Thông báo");
            }
            conn.Close();
            loadStudent();
        }

        private void dgv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_student.CurrentRow.Index;
            txt_studentID.Text = dgv_student.Rows[i].Cells[0].Value.ToString();
            txt_studentName.Text = dgv_student.Rows[i].Cells[1].Value.ToString();
            txt_age.Text = dgv_student.Rows[i].Cells[2].Value.ToString();
            if (dgv_student.Rows[i].Cells[3].Value.ToString() == "Male")
                rdb_male.Checked = true;
            else
                rdb_female.Checked = true;
            txt_address.Text = dgv_student.Rows[i].Cells[4].Value.ToString();
            txt_phoneNumber.Text = dgv_student.Rows[i].Cells[5].Value.ToString();
            cbb_className.Text = dgv_student.Rows[i].Cells[6].Value.ToString();
            cbb_roomName.Text = dgv_student.Rows[i].Cells[7].Value.ToString();
        }
    }
}
