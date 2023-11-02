using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Text;

namespace Library_Management
{
    public partial class LoginForm : Form
    {
        //connection URL 
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //since a background picture is used, it should be put like this.
            label1.Parent = this;
            lblName.Parent = this;
            lblPass.Parent = this;
            cBoxPass.Parent = this;
            lblLogin.Parent = this;
            lblCopy.Parent = this;
            lblRoll.Parent = this;
            label1.BackColor = Color.Transparent;
            lblName.BackColor = Color.Transparent;
            lblPass.BackColor = Color.Transparent;
            cBoxPass.BackColor = Color.Transparent;
            lblLogin.BackColor = Color.Transparent;
            lblCopy.BackColor = Color.Transparent;
            lblRoll.BackColor = Color.Transparent;
        }

        private void cBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            //this condition used to show password option.
            if (cBoxPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        //login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //use tryCatch for error handling.
            try
            {
                //get value from text box to variable
                string username = txtName.Text.ToString();
                string password = txtPass.Text.ToString();
                string roll = comBoxRoll.SelectedItem.ToString();

                //this condition check all inputs are given
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(roll))
                {
                    MessageBox.Show("Please Enter User Details Correctly");
                    txtClear();
                    comBoxRoll.Focus();
                }
                else
                {
                    //get data from database.
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("select count(*) from "+roll+" where userName='" + username + "' and password = '" + password + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //this switch case use who is login and what show window.
                        switch (roll)
                        {
                            case "administrator":
                                //create an object for relevent form then show it.
                                AdminForm adminForm = new AdminForm();
                                adminForm.ShowDialog();
                                this.Close();
                                break;

                            case "librarian":
                                LibrarianForm librarianForm = new LibrarianForm();
                                librarianForm.ShowDialog();
                                this.Close();
                                break;

                            case "member":
                                MemberForm memberForm = new MemberForm();
                                memberForm.ShowDialog();
                                this.Close();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong !!! ");
                        txtClear();
                        comBoxRoll.Focus();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtClear();
                comBoxRoll.Focus();

            }
            finally
            {
                con.Close();
            }

        }
        //this method use clear all inputs boxes
        void txtClear()
        {
            txtName.Text = "";
            txtPass.Text = "";
            comBoxRoll.Focus();
        }
    }
}