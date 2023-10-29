namespace Library_Management
{
    partial class ManageBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAvaCopies = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnSearch = new Button();
            btnLogout = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            bookDataGridView = new DataGridView();
            txtTotCopies = new TextBox();
            txtGenre = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtBookID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtAvaCopies
            // 
            txtAvaCopies.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAvaCopies.Location = new Point(135, 253);
            txtAvaCopies.Name = "txtAvaCopies";
            txtAvaCopies.Size = new Size(169, 27);
            txtAvaCopies.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 296);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 256);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 58;
            label7.Text = "Available Copies : ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(242, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 31);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 255, 255);
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Location = new Point(3, 425);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 28);
            btnLogout.TabIndex = 56;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(156, 376);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 43);
            btnClear.TabIndex = 55;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(242, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 43);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(156, 327);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 43);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(70, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 43);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.AllowUserToDeleteRows = false;
            bookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.Location = new Point(325, 14);
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.ReadOnly = true;
            bookDataGridView.RowTemplate.Height = 25;
            bookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookDataGridView.Size = new Size(575, 426);
            bookDataGridView.TabIndex = 51;
            // 
            // txtTotCopies
            // 
            txtTotCopies.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotCopies.Location = new Point(135, 206);
            txtTotCopies.Name = "txtTotCopies";
            txtTotCopies.Size = new Size(169, 27);
            txtTotCopies.TabIndex = 50;
            // 
            // txtGenre
            // 
            txtGenre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenre.Location = new Point(135, 166);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(169, 27);
            txtGenre.TabIndex = 49;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAuthor.Location = new Point(135, 125);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(169, 27);
            txtAuthor.TabIndex = 48;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(135, 86);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(169, 27);
            txtTitle.TabIndex = 47;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookID.Location = new Point(135, 48);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(101, 27);
            txtBookID.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 209);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 45;
            label6.Text = "Total Copies : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 44;
            label5.Text = "Genre :  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 128);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 43;
            label4.Text = "Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 90);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 42;
            label3.Text = "Title : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 41;
            label2.Text = "Book ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(107, 22);
            label1.TabIndex = 40;
            label1.Text = "Manage Book";
            // 
            // ManageBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 248, 220);
            ClientSize = new Size(910, 457);
            Controls.Add(txtAvaCopies);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(bookDataGridView);
            Controls.Add(txtTotCopies);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtBookID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBookForm";
            Text = "ManageBookForm";
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotCopies;
        private TextBox txtAvaCopies;
        private TextBox txtGenre;
        private Label label8;
        private Label label7;
        private Button btnSearch;
        private Button btnLogout;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView bookDataGridView;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtBookID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}