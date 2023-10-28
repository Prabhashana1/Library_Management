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
using System.Xml.Linq;

namespace Library_Management
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=");
        MySqlCommand cmd;

        private void AdminForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();
        }

        public void gridLoadItem()
        {
            string selectQuery = "select * from librarian";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            userDataGridView.DataSource = table;
        }

        private void userDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtUname.Text = userDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = userDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = userDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNO.Text = userDataGridView.CurrentRow.Cells[4].Value.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO librarian (userName,password,name,phoneNO) VALUES ('" + txtUname.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + txtPhoneNO.Text + "')";
            exeQuery(insertQuery);
            gridLoadItem();
            txtClear();

        }

        public void txtClear()
        {
            txtID.Text = "";
            txtUname.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtPhoneNO.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you update");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to update this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE librarian SET userName= '" + txtUname.Text + "',password='" + txtPassword.Text + "',name='" + txtName.Text + "',phoneNO='" + txtPhoneNO.Text + "' WHERE librarianID=" + int.Parse(txtID.Text);
                    exeQuery(updateQuery);
                    gridLoadItem();
                    txtClear();
                }
                else
                {
                    txtClear();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you delete");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "delete from librarian where librarianID =" + int.Parse(txtID.Text);
                    exeQuery(deleteQuery);
                    gridLoadItem();
                    txtClear();
                }
                else
                {
                    txtClear();
                }
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            cmd = new MySqlCommand("select * from librarian where librarianID= " + txtID.Text, con);
            openCon();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtUname.Text = dr.GetString("userName");
                txtPassword.Text = dr.GetString("password");
                txtName.Text = dr.GetString("name");
                txtPhoneNO.Text = dr.GetString("phoneNO");
            }
            else
            {
                MessageBox.Show("User not found");
                txtClear();
            }
            closeCon();

        }
    }
}
