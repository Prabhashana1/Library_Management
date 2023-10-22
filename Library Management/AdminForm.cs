using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class AdminForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library_management; password=");
        MySqlCommand cmd;
        public string uName { get; set; }
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();

        }

        public void gridLoadItem()
        {
            label1.Text = "Welocome " + uName;
            string selectQuery = "select * from users";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            userDataGridView.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO users (userName,name,password,roll) VALUES ('" + txtuName.Text + "','" + txtName.Text + "','" + txtPassword.Text + "','" + comBoxRoll.Text + "')";
            exeQuery(insertQuery);
            gridLoadItem();
            txtClear();
        }

        private void userDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtuId.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtuName.Text = userDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = userDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = userDataGridView.CurrentRow.Cells[3].Value.ToString();
            comBoxRoll.Text = userDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        public void openCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        public void exeQuery(string query)
        {
            try
            {
                openCon();
                cmd = new MySqlCommand(query, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed!!! Please Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to update this ?", "Warning!!!", buttons);
            if (result == DialogResult.Yes)
            {
                string updateQuery = "UPDATE users SET userName= '" + txtuName.Text + "',name='" + txtName.Text + "',password='" + txtPassword.Text + "',roll='" + comBoxRoll.Text + "' WHERE user_id=" + int.Parse(txtuId.Text);
                exeQuery(updateQuery);
                gridLoadItem();
                txtClear();
            }
            else
            {
                txtClear();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to delete this ?", "Warning!!!", buttons);
            if (result == DialogResult.Yes)
            {
                string deleteQuery = "delete from users where user_id =" + int.Parse(txtuId.Text);
                exeQuery(deleteQuery);
                gridLoadItem();
                txtClear();
            }
            else
            {
                txtClear();
            }
        }

        public void txtClear()
        {
            txtuId.Text = "";
            txtuName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            comBoxRoll.Text = "";
            txtuName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            cmd = new MySqlCommand("select * from users where user_id= " + txtuId.Text, con);
            openCon();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtuName.Text = dr.GetString("userName");
                txtName.Text = dr.GetString("name");
                txtPassword.Text = dr.GetString("password");
                comBoxRoll.Text = dr.GetString("roll");
            }
            else
            {
                MessageBox.Show("User not found");
                txtClear();
            }
            closeCon();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }
    }
}
