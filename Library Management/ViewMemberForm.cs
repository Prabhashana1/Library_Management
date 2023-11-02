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
    public partial class ViewMemberForm : Form
    {

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=");
        public ViewMemberForm()
        {
            InitializeComponent();
        }

        private void ViewMemberForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();
        }
        public void gridLoadItem()
        {
            string selectQuery = "select memberID,name,email,address,phoneNO from member";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            viewMemberDataGridView.DataSource = table;
        }
    }
}
