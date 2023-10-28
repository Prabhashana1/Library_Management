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
    public partial class ManageMemberForm : Form
    {
        public ManageMemberForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.ShowDialog();
            this.Close();


        }
    }
}
