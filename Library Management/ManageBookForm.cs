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
    public partial class ManageBookForm : Form
    {
        public ManageBookForm()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=");
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private void ManageBookForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();
        }

        public void gridLoadItem()
        {
            string selectQuery = "select * from book";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            bookDataGridView.DataSource = table;
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

        public void txtClear()
        {
            txtBookID.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtGenre.Text = "";
            txtTotCopies.Text = "";
            txtAvaCopies.Text = "";
            txtTitle.Focus();
        }

        private void bookDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtBookID.Text = bookDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = bookDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtAuthor.Text = bookDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtGenre.Text = bookDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtTotCopies.Text = bookDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtAvaCopies.Text = bookDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand("select * from book where bookID= " + txtBookID.Text, con);
            openCon();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtBookID.Text = dr.GetString("bookID");
                txtTitle.Text = dr.GetString("title");
                txtAuthor.Text = dr.GetString("author");
                txtGenre.Text = dr.GetString("genre");
                txtTotCopies.Text = dr.GetString("totalCopies");
                txtAvaCopies.Text = dr.GetString("availableCopies");
            }
            else
            {
                MessageBox.Show("Book not found");
                txtClear();
            }
            closeCon();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO book (title,author,genre,totalCopies,availableCopies) VALUES ('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + txtGenre.Text + "','" + txtTotCopies.Text + "','" + txtAvaCopies.Text + "')";
            exeQuery(insertQuery);
            gridLoadItem();
            txtClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you update");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to update this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE book SET title= '" + txtTitle.Text + "',author='" + txtAuthor.Text + "',genre='" + txtGenre.Text + "',totalCopies='" + txtTotCopies.Text + "',availableCopies='" + txtAvaCopies.Text + "' WHERE bookID=" + int.Parse(txtBookID.Text);
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
            if (txtBookID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you delete");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "delete from book where bookID =" + int.Parse(txtBookID.Text);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1.Text);
        }
        public void search(string value)
        {
            string querySearch = "select * from book where concat(bookID,title,author,genre) like '%" + value + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(querySearch,con);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            bookDataGridView.DataSource = tbl;
        }


    }
}
