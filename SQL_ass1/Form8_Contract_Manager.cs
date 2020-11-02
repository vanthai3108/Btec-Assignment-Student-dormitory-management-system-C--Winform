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
using System.Diagnostics.Contracts;
using System.Windows.Forms.VisualStyles;

namespace SQL_ass1
{
    public partial class Form_Contract_Manager : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                               Initial Catalog = DormitoryManagement;
                                               Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        public Form_Contract_Manager()
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
        }

        private void roomMagerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form_Contract_Manager_Load(object sender, EventArgs e)
        {
            loadContract_Manager();
            Load_cbb_manager();
        }


        private void btn_contractID_search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ContractID, ManagerName"
                                + " FROM Contract_Manager, DormitoryManager"
                                + " WHERE Contract_Manager.ManagerID = DormitoryManager.ManagerID AND ManagerName like '%"
                                                + txt_managerName_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "Contract_Manager");
                dgv_contract_manager.DataSource = ds.Tables["Contract_Manager"];
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
                command.CommandText = "INSERT INTO Contract_Manager(ManagerID, ContractID)"
                     + "VALUES (N'" + cbb_managerName.SelectedValue.ToString()  + "', N'"
                                    + txt_contractID.Text + "')";
                command.ExecuteNonQuery();
                conn.Close();
                loadContract_Manager();
            }
            catch (Exception)
            {
                MessageBox.Show(" Add thất bại", "Thông báo");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Contract_Manager SET ManagerID = '" + cbb_managerName.SelectedValue.ToString() 
                + "' where ContractID = " + txt_contractID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Update thất bại", "Thông báo");
            }
            conn.Close();
            loadContract_Manager();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Contract_Manager WHERE ContractID = "
                    + txt_contractID.Text + "and ManagerID = " + cbb_managerName.SelectedValue.ToString() + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadContract_Manager();
        }

        void loadContract_Manager()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ContractID, ManagerName"
                                + " FROM Contract_Manager, DormitoryManager"
                                + " WHERE Contract_Manager.ManagerID = DormitoryManager.ManagerID";
            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "Contract_Manager");
            dgv_contract_manager.DataSource = ds.Tables["Contract_Manager"];
            conn.Close();
        }

        private void dgv_contract_manager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_contract_manager.CurrentRow.Index;
            txt_contractID.Text = dgv_contract_manager.Rows[i].Cells[0].Value.ToString();
            cbb_managerName.Text = dgv_contract_manager.Rows[i].Cells[1].Value.ToString();
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
    }
}
