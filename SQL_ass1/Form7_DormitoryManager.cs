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
    
    public partial class Form_DormitoryManager : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;Initial Catalog = DormitoryManagement;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        public Form_DormitoryManager()
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

        private void Form_DormitoryManager_Load(object sender, EventArgs e)
        {
            loadDormitoryManager();
        }

        private void btn_managerName_search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM DormitoryManager where ManagerName like '%"
                                                + txt_managerName_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "DormitoryManager");
                dgv_dormitoryManager.DataSource = ds.Tables["DormitoryManager"];
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
                command.CommandText = "INSERT INTO DormitoryManager(ManagerID, ManagerName)"
                     + "VALUES (N'" + txt_managerID.Text + "', N'"
                                    + txt_managerName.Text + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Add thất bại", "Thông báo");
            }
            conn.Close();
            loadDormitoryManager();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE DormitoryManager SET ManagerName = '" + txt_managerName.Text
                                               + "' where ManagerID = " + txt_managerID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Update thất bại", "Thông báo");
            }
            conn.Close();
            loadDormitoryManager();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM DormitoryManager WHERE ManagerID = " + txt_managerID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadDormitoryManager();
        }

        void loadDormitoryManager()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM DormitoryManager";
            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "DormitoryManager");
            dgv_dormitoryManager.DataSource = ds.Tables["DormitoryManager"];
            conn.Close();
        }

        private void dgv_dormitoryManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_dormitoryManager.CurrentRow.Index;
            txt_managerID.Text = dgv_dormitoryManager.Rows[i].Cells[0].Value.ToString();
            txt_managerName.Text = dgv_dormitoryManager.Rows[i].Cells[1].Value.ToString();
        }
    }
}
