﻿using System;
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
    public partial class LibrarianForm : Form
    {
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            loadForm(new ManageMemberForm());
        }

        public void loadForm(object Form)
        {
            if (this.panelForm.Controls.Count > 0) this.panelForm.Controls.RemoveAt(0);
            Form fr = Form as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(fr);
            this.panelForm.Tag = fr;
            fr.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            loadForm(new ManageMemberForm());
            btnMember.BackColor = Color.Tan;
            btnBorrowing.BackColor = Color.DimGray;
            btnBook.BackColor = Color.DimGray;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            loadForm(new ManageBookForm());
            btnBook.BackColor = Color.Tan;
            btnMember.BackColor = Color.DimGray;
            btnBorrowing.BackColor = Color.DimGray;
        }

        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            loadForm(new BorrowingForm());
            btnBorrowing.BackColor = Color.Tan;
            btnMember.BackColor = Color.DimGray;
            btnBook.BackColor = Color.DimGray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
