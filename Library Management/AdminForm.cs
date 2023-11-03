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
        //create connection URL
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=");
        
        //open this admin form when automatically execute above tasks.
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //call method for load data to grid view table
            gridLoadItem();
        }

        //method for load data to grid
        public void gridLoadItem()
        {
            //use try catch for error handling
            try
            {
                //open connection and execute query
                openCon();
                //get all data from librarian table then add to table
                string selectQuery = "select * from librarian";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
                adapter.Fill(table);
                userDataGridView.DataSource = table;
            }
            //use catch for find exception and show it
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // This finally keyword will work whether or not there is an error above
            finally
            { 
                //call closeCon method for close connection
                closeCon();
            }
            
        }

        //This is a mouseclick event. This will send data to the text box when selected in the gridview
        private void userDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtUname.Text = userDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = userDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = userDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNO.Text = userDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        //connection open method
        public void openCon()
        {
            //This condition open the connection if it is closed
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //This condition close the connection if it is opened
        public void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        //This will execute the *DML* SQL query. There are two parameters here, one to get the query and the other to know the type of the query
        public void exeQuery(string queryType, string query)
        {
            try
            {
                openCon();
                MySqlCommand cmd = new MySqlCommand(query, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(queryType+" successful");
                }
                else
                {
                    MessageBox.Show(queryType+" not successful!!! Please Try Again");
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

        //button for insert data 
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                //check all input fields are filled
                if (checkInput() == true)
                {
                    string insertQuery = "INSERT INTO librarian (userName,password,name,phoneNO) VALUES ('" + txtUname.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + txtPhoneNO.Text + "')";
                    exeQuery("Insert", insertQuery);
                    gridLoadItem();
                    txtClear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon() ;
            }
            

        }

        //method for clear input fields
        public void txtClear()
        {
            txtID.Text = "";
            txtUname.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtPhoneNO.Text = "";
            txtUname.Focus();
        }

        //clear button clear the all input fields using txtClear method
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        //button for update data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check ID field is empty
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please Select who want you update");
            }
            else
            {
                try
                {
                    //show message box including two options (Yes or No)

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Do you want to update this ?", "Warning!!!", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string updateQuery = "UPDATE librarian SET userName= '" + txtUname.Text + "',password='" + txtPassword.Text + "',name='" + txtName.Text + "',phoneNO='" + txtPhoneNO.Text + "' WHERE librarianID=" + int.Parse(txtID.Text);
                        exeQuery("Update", updateQuery);
                        gridLoadItem();
                        txtClear();
                    }
                    else
                    {
                        txtClear();
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

        }

        //button for delete
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
                    try
                    {
                        string deleteQuery = "delete from librarian where librarianID =" + int.Parse(txtID.Text);
                        exeQuery("Delete", deleteQuery);
                        gridLoadItem();
                        txtClear();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally 
                    { 
                        closeCon(); 
                    }
                    
                }
                else
                {
                    txtClear();
                }
            }

        }

        //button for logout 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //button for search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader dr;
                MySqlCommand cmd = new MySqlCommand("select * from librarian where librarianID= " + txtID.Text, con);
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

        //method for check inputs are correctly inserted
        public bool checkInput()
        {
            if(false == string.IsNullOrEmpty(txtUname.Text) && false == string.IsNullOrEmpty(txtPassword.Text) && false == string.IsNullOrEmpty(txtName.Text) && false == string.IsNullOrEmpty(txtPhoneNO.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter all details");
                return false;
            }
           
        }
    }
}
