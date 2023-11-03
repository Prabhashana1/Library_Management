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
    public partial class ManageMemberForm : Form
    {
        public ManageMemberForm()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=");
        


        private void ManageMemberForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();
        }

        public void txtClear()
        {
            txtMemberID.Text = "";
            txtname.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhoneNO.Text = "";
            txtUname.Text = "";
            txtPassword.Text = "";
            txtname.Focus();
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
                MySqlCommand cmd = new MySqlCommand(query, con);

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


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand("select * from member where memberID= " + txtMemberID.Text, con);
            openCon();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtname.Text = dr.GetString("name");
                txtUname.Text = dr.GetString("userName");
                txtPassword.Text = dr.GetString("password");
                txtEmail.Text = dr.GetString("email");
                txtAddress.Text = dr.GetString("address");
                txtPhoneNO.Text = dr.GetString("phoneNO");
            }
            else
            {
                MessageBox.Show("User not found");
                txtClear();
            }
            closeCon();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO member (name,userName,password,email,address,phoneNO) VALUES ('" + txtname.Text + "','" + txtUname.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtPhoneNO.Text+"')";
            exeQuery(insertQuery);
            gridLoadItem();
            txtClear();
        }

        public void gridLoadItem()
        {
            string selectQuery = "select * from member";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            memberDataGridView.DataSource = table;
        }

        private void memberDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void memberDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtMemberID.Text = memberDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = memberDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtUname.Text = memberDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = memberDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = memberDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = memberDataGridView.CurrentRow.Cells[5].Value.ToString();
            txtPhoneNO.Text = memberDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you update");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to update this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE member SET name= '" + txtname.Text + "',userName='" + txtUname.Text + "',password='" + txtPassword.Text + "',email='" + txtEmail.Text + "',address='" + txtAddress.Text + "',phoneNO='" + txtPhoneNO.Text + "' WHERE memberID=" + int.Parse(txtMemberID.Text);
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
            if (txtMemberID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you delete");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "delete from member where memberID =" + int.Parse(txtMemberID.Text);
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
            Application.Exit();
        }
    }


}



