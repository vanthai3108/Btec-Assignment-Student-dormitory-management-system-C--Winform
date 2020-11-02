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
    public partial class Form_Room : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                               Initial Catalog = DormitoryManagement;
                                               Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        public Form_Room()
        {
            InitializeComponent();
        }

        void loadRoom()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Room";
            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "Room");
            dgv_room.DataSource = ds.Tables["Room"];
            conn.Close();
        }

        private void Form_Room_Load(object sender, EventArgs e)
        {
            loadRoom();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Notice;
            Notice = MessageBox.Show("Do you want to exit ?", "Notice", 
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Notice == DialogResult.Yes)
                Application.Exit();
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

        private void btn_roomName_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Room where RoomName like '%" 
                                                + txt_roomName_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "Room");
                dgv_room.DataSource = ds.Tables["Room"];
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
                command.CommandText = 
                    "INSERT INTO Room(RoomID, RoomName, NumberOfBeds, RoomRates, RoomArea)"
                    + "VALUES (N'" + txt_roomID.Text + "', N'"
                                   + txt_roomName.Text + "', N'"
                                   + txt_numberOfBeds.Text + "', N'"
                                   + txt_roomRates.Text + "', N'"
                                   + txt_roomArea.Text + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Add thất bại", "Thông báo");
            }
            conn.Close();
            loadRoom();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = 
                    "UPDATE Room SET RoomName = '" + txt_roomName.Text
                           + "', NumberOfBeds = '" + txt_numberOfBeds.Text
                           + "', RoomRates = '" + txt_roomRates.Text
                           + "', RoomArea = '" + txt_roomArea.Text
                           + "' where RoomID = '" + txt_roomID.Text + "'";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Update thất bại", "Thông báo");
            }
            conn.Close();
            loadRoom();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = 
                    "DELETE FROM Room WHERE RoomID = " + txt_roomID.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadRoom();
        }

        private void dgv_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_room.CurrentRow.Index;
            txt_roomID.Text = dgv_room.Rows[i].Cells[0].Value.ToString();
            txt_roomName.Text = dgv_room.Rows[i].Cells[1].Value.ToString();
            txt_numberOfBeds.Text = dgv_room.Rows[i].Cells[2].Value.ToString();
            txt_roomRates.Text = dgv_room.Rows[i].Cells[3].Value.ToString();
            txt_roomArea.Text = dgv_room.Rows[i].Cells[4].Value.ToString();
        }
    }
}
