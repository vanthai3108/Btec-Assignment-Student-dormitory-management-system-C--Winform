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
using System.Reflection;

namespace SQL_ass1
{
    public partial class Form_RentalContract : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                                Initial Catalog = DormitoryManagement;
                                                Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        public Form_RentalContract()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Student a = new Form_Student();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Class a = new Form_Class();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Room a = new Form_Room();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void dormitoryManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DormitoryManager a = new Form_DormitoryManager();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void rentalContractToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
        }

        private void Form_RentalContract_Load(object sender, EventArgs e)
        {
            loadRentalContract();
            Load_cbb_student();
            Load_cbb_room();
        }

        private void btn_contractID_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ContractID, CheckInDay, CheckOutDay, StudentName, RoomName"
                                  + " FROM RentalContract, Student, Room"
                                  + " WHERE RentalContract.StudentID = Student.StudentID and Student.RoomID = Room.RoomID and RoomName like '%"
                                  + txt_roomName_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "RentalContract");
                dgv_rentalContract.DataSource = ds.Tables["RentalContract"];
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
                command.CommandText = "INSERT INTO RentalContract(ContractID, CheckInDay, CheckOutDay, StudentID)"
                     + "VALUES (N'" + txt_contractID.Text + "', N'"
                                    + dtp_checkInDay.Value + "', N'"
                                    + dtp_checkOutDay.Value + "', N'"
                                    + cbb_studentName.SelectedValue.ToString() + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Add thất bại", "Thông báo");
            }
            conn.Close();
            loadRentalContract();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE RentalContract SET CheckInDay = '" + dtp_checkInDay.Value
                                               + "', CheckOutDay = '" +dtp_checkOutDay.Value
                                               + "', StudentID = '" + cbb_studentName.SelectedValue.ToString()
                                               + "' where ContractID = " + txt_contractID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Update thất bại", "Thông báo");
            }
            conn.Close();
            loadRentalContract();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM RentalContract WHERE ContractID = " + txt_contractID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadRentalContract();
        }

        void loadRentalContract()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ContractID, CheckInDay, CheckOutDay, StudentName, RoomName"
                                  + " FROM RentalContract, Student, Room"
                                  + " WHERE RentalContract.StudentID = Student.StudentID and Student.RoomID = Room.RoomID ";
            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "RentalContract");
            dgv_rentalContract.DataSource = ds.Tables["RentalContract"];
            conn.Close();
        }

        private void dgv_rentalContract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_rentalContract.CurrentRow.Index;
            txt_contractID.Text = dgv_rentalContract.Rows[i].Cells[0].Value.ToString();
            dtp_checkInDay.Text = dgv_rentalContract.Rows[i].Cells[1].FormattedValue.ToString();
            dtp_checkOutDay.Text = dgv_rentalContract.Rows[i].Cells[2].FormattedValue.ToString();
            cbb_studentName.Text = dgv_rentalContract.Rows[i].Cells[3].Value.ToString();
            cbb_roomName.Text = dgv_rentalContract.Rows[i].Cells[4].Value.ToString();
        }
        public void Load_cbb_student()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select StudentName, StudentID From Student", conn);
            da.Fill(dt);
            conn.Close();
            cbb_studentName.DataSource = dt.Copy();
            cbb_studentName.DisplayMember = "StudentName";
            cbb_studentName.ValueMember = "StudentID";
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
    }
}
