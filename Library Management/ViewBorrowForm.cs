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
            string selectQuery = "select borrow.borrowID, borrow.memberID, member.name, borrow.bookID, book.title, borrow.borrowDate, borrow.returnDate, borrow.status from borrow inner join member on borrow.memberID=member.memberID inner join book on borrow.bookID=book.bookID";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            viewBorrowDataGridView.DataSource = table;

        }

        private void viewBorrowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
