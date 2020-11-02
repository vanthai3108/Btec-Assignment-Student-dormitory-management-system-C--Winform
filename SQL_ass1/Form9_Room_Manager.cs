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
    public partial class Form_Room_Manager : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                               Initial Catalog = DormitoryManagement;
                                               Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        public Form_Room_Manager()
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

        private void roomMagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
        }

        private void Form_Room_Manager_Load(object sender, EventArgs e)
        {
            loadRoom_Manager();
            Load_cbb_manager();
            Load_cbb_room();
        }

        private void btn_roomName_search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ManagerName, RoomName, NumberOfBeds, RoomRates, RoomArea"
                                + " FROM Room_Manager, Room, DormitoryManager"
                                + " WHERE Room_Manager.ManagerID = DormitoryManager.ManagerID and Room_Manager.RoomID = Room.RoomID and RoomName like '%" + txt_roomName_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "Room_Manager");
                dgv_room_manager.DataSource = ds.Tables["Room_Manager"];
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Room_Manager(ManagerID, RoomID)"
                     + "VALUES (N'" + cbb_managerName.SelectedValue.ToString() + "', N'"
                                    + cbb_roomName.SelectedValue.ToString() + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Add thất bại", "Thông báo");
            }
            conn.Close();
            loadRoom_Manager();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Room_Manager SET ManagerID = '" + cbb_managerName.SelectedValue.ToString()
                                               + "' where RoomID = " + cbb_roomName.SelectedValue.ToString() + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Update thất bại", "Thông báo");
            }
            conn.Close();
            loadRoom_Manager();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Room_Manager WHERE RoomID = " + cbb_managerName.SelectedValue.ToString()
                                                     + "and ManagerID = " + cbb_roomName.SelectedValue.ToString() + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadRoom_Manager();
        }

        void loadRoom_Manager()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ManagerName, RoomName, NumberOfBeds, RoomRates, RoomArea"
                                + " FROM Room_Manager, Room, DormitoryManager"
                                + " WHERE Room_Manager.ManagerID = DormitoryManager.ManagerID and Room_Manager.RoomID = Room.RoomID";
            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "Room_Manager");
            dgv_room_manager.DataSource = ds.Tables["Room_Manager"];
            conn.Close();
        }

        private void dgv_room_manager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_room_manager.CurrentRow.Index;
            cbb_managerName.Text = dgv_room_manager.Rows[i].Cells[0].Value.ToString();
            cbb_roomName.Text = dgv_room_manager.Rows[i].Cells[1].Value.ToString();
            txt_numberOfBeds.Text = dgv_room_manager.Rows[i].Cells[2].Value.ToString();
            txt_roomRates.Text = dgv_room_manager.Rows[i].Cells[3].Value.ToString();
            txt_roomArea.Text = dgv_room_manager.Rows[i].Cells[4].Value.ToString();
        }
        public void Load_cbb_manager()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select ManagerName, ManagerID From DormitoryManager", conn);
            da.Fill(dt);
            conn.Close();
            cbb_managerName.DataSource = dt.Copy();
            cbb_managerName.DisplayMember = "ManagerName";
            cbb_managerName.ValueMember = "ManagerID";
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
