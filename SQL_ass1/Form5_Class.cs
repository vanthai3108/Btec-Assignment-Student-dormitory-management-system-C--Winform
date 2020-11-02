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
    public partial class Form_Class : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JNU6Q1D;
                                               Initial Catalog = DormitoryManagement;
                                               Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        public Form_Class()
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

        private void Form_Class_Load(object sender, EventArgs e)
        {
            loadClass();
        }

        private void btn_className_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Class where ClassName like '%"
                                                + txt_className_search.Text + "%'";
                adapter.SelectCommand = command;
                var ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "Class");
                dgv_class.DataSource = ds.Tables["Class"];
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
                command.CommandText = "INSERT INTO Class(ClassID, ClassName)"
                     + "VALUES (N'" + txt_classID.Text + "', N'"
                                    + txt_className.Text + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Add thất bại", "Thông báo");
            }
            conn.Close();
            loadClass();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Class SET ClassName = '" + txt_className.Text
                                               + "' where ClassID = " +txt_classID.Text + ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Update thất bại", "Thông báo");
            }
            conn.Close();
            loadClass();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Class WHERE ClassID = " + txt_classID.Text +  ";";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Delete thất bại", "Thông báo");
            }
            conn.Close();
            loadClass();
        }

        void loadClass()
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Class";
            adapter.SelectCommand = command;
            var ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "Class");
            dgv_class.DataSource = ds.Tables["Class"];
            conn.Close();
        }

        private void dgv_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_class.CurrentRow.Index;
            txt_classID.Text = dgv_class.Rows[i].Cells[0].Value.ToString();
            txt_className.Text = dgv_class.Rows[i].Cells[1].Value.ToString();
        }
    }
}
