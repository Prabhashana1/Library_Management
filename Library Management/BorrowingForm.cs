﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class BorrowingForm : Form
    {
        public BorrowingForm()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=;convert zero Datetime=True");
        

        private void borrowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowingForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();
        }


        public void gridLoadItem()
        {
            string selectQuery = "select borrow.borrowID, borrow.memberID, member.name, borrow.bookID, book.title, borrow.borrowDate, borrow.returnDate,borrow.status from borrow inner join member on borrow.memberID=member.memberID inner join book on borrow.bookID=book.bookID";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            borrowDataGridView.DataSource = table;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO borrow (memberID,bookID,borrowDate) VALUES ('" + txtMemberID.Text + "','" + txtBookID.Text + "','" + dtPickBorrow.Text + "')";
            string bookDecrement = "update book set availableCopies = availableCopies -1 where bookID ='" + int.Parse(txtBookID.Text) + "'";
            exeQuery(insertQuery, "Insert");
            try
            {
                openCon();
                MySqlCommand cmd = new MySqlCommand(bookDecrement, con);

                if (cmd.ExecuteNonQuery() == 1)
                {

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
            gridLoadItem();
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
        public void exeQuery(string query, string operation)
        {
            try
            {
                openCon();
                MySqlCommand cmd = new MySqlCommand(query, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(operation + " successfully");
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

        private void dtPickBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtborrowID.Text == string.Empty)
            {
                MessageBox.Show("Please Select borrow ID want you delete");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "delete from borrow where borrowID =" + int.Parse(txtborrowID.Text);
                    exeQuery(deleteQuery, "Delete");
                    gridLoadItem();
                    //txtClear();
                }
                else
                {
                    //txtClear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtborrowID.Text == string.Empty)
            {
                MessageBox.Show("Please Select Borrowing ID want you Return");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to return this ?", "Warning!!!", buttons);
                if (result == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE borrow SET  status='Completed',returnDate= '" + dtPickReturn.Text + "' WHERE borrowID=" + int.Parse(txtborrowID.Text);
                    exeQuery(updateQuery, "Return");
                    gridLoadItem();
                    string bookIncrement = "update book set availableCopies = availableCopies +1 where bookID ='" + int.Parse(txtBookID.Text) + "'";

                    try
                    {
                        openCon();
                        MySqlCommand cmd = new MySqlCommand(bookIncrement, con);

                        if (cmd.ExecuteNonQuery() == 1)
                        {

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
                    //txtClear();
                }
                else
                {
                    //txtClear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataReader dr;
                MySqlCommand cmd = new MySqlCommand("select * from borrow where borrowID= " + txtborrowID.Text, con);
                openCon();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtborrowID.Text = dr.GetString("borrowID");
                    txtMemberID.Text = dr.GetString("memberID");
                    txtBookID.Text = dr.GetString("bookID");
                    DateTime datevalueborrow = Convert.ToDateTime(dr["borrowDate"]);
                    dtPickBorrow.Value = datevalueborrow;
                    DateTime datevaluereturn = Convert.ToDateTime(dr["returnDate"]);
                    dtPickReturn.Value = datevaluereturn;

                }
                else
                {
                    MessageBox.Show("borrow ID not found");
                    //txtClear();
                }
                closeCon();
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

        private void borrowDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtborrowID.Text = borrowDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtMemberID.Text = borrowDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtBookID.Text = borrowDataGridView.CurrentRow.Cells[3].Value.ToString();
            dtPickBorrow.Text = borrowDataGridView.CurrentRow.Cells[5].Value.ToString();
            dtPickReturn.Text = borrowDataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
