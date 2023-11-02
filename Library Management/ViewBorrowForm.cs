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

    public partial class ViewBorrowForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;database=library; password=;convert zero Datetime=True");
        public ViewBorrowForm()
        {
            InitializeComponent();
        }

        private void ViewBorrowForm_Load(object sender, EventArgs e)
        {
            gridLoadItem();
        }

        public void gridLoadItem()
        {
            string selectQuery = "select borrowing.borrowID, borrowing.memberID, member.name, borrowing.bookID, book.title, borrowing.borrowDate, borrowing.returnDate from borrowing inner join member on borrowing.memberID=member.memberID inner join book on borrowing.bookID=book.bookID";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            viewBorrowDataGridView.DataSource = table;

        }
    }
}
