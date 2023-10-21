using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Text;

namespace Library_Management
{
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library_management; password=");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
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
            if (cBoxPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string username = txtName.Text.ToString();
                string password = txtPass.Text.ToString();
                string roll = comBoxRoll.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(roll))
                {
                    MessageBox.Show("Please Enter User Details Correctly");
                }
                else
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("select count(*) from users where userName='" + username + "' and password = '" + password + "' and roll = '" + roll + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        switch (roll)
                        {
                            case "Administrator":
                                MessageBox.Show("admin");
                                break;

                            case "Librarian":
                                MessageBox.Show("libra");
                                break;

                            case "Member":
                                MessageBox.Show("member");
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
            }
            finally
            {
                con.Close();
            }

        }
        void txtClear()
        {
            txtName.Text = "";
            txtPass.Text = "";
            comBoxRoll.Focus();
        }
    }
}