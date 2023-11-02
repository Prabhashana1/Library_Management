namespace Library_Management
{
    partial class BorrowingForm
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
            label7 = new Label();
            btnSearch = new Button();
            btnLogout = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            borrowDataGridView = new DataGridView();
            txtBookID = new TextBox();
            txtMemberID = new TextBox();
            txtborrowID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtPickBorrow = new DateTimePicker();
            dtPickReturn = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)borrowDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 256);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 58;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(243, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 31);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 255, 255);
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Location = new Point(4, 425);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 28);
            btnLogout.TabIndex = 56;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(157, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 43);
            btnClear.TabIndex = 55;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(243, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 43);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(157, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 43);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Return";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(71, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 43);
            btnSave.TabIndex = 52;
            btnSave.Text = "Issuing";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // borrowDataGridView
            // 
            borrowDataGridView.AllowUserToAddRows = false;
            borrowDataGridView.AllowUserToDeleteRows = false;
            borrowDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrowDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowDataGridView.Location = new Point(326, 14);
            borrowDataGridView.Name = "borrowDataGridView";
            borrowDataGridView.ReadOnly = true;
            borrowDataGridView.RowTemplate.Height = 25;
            borrowDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowDataGridView.Size = new Size(575, 426);
            borrowDataGridView.TabIndex = 51;
            borrowDataGridView.CellContentClick += borrowDataGridView_CellContentClick;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookID.Location = new Point(136, 125);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(169, 27);
            txtBookID.TabIndex = 48;
            // 
            // txtMemberID
            // 
            txtMemberID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMemberID.Location = new Point(136, 86);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(169, 27);
            txtMemberID.TabIndex = 47;
            // 
            // txtborrowID
            // 
            txtborrowID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtborrowID.Location = new Point(136, 48);
            txtborrowID.Name = "txtborrowID";
            txtborrowID.Size = new Size(101, 27);
            txtborrowID.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 209);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 45;
            label6.Text = "Return Date : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 168);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 44;
            label5.Text = "Borrow Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 128);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 43;
            label4.Text = "Book ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 90);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 42;
            label3.Text = "Member ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 41;
            label2.Text = "Borrow ID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(137, 22);
            label1.TabIndex = 40;
            label1.Text = "Borrowing Details";
            // 
            // dtPickBorrow
            // 
            dtPickBorrow.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtPickBorrow.CustomFormat = "yyyy-MM-dd";
            dtPickBorrow.Format = DateTimePickerFormat.Custom;
            dtPickBorrow.Location = new Point(136, 168);
            dtPickBorrow.Name = "dtPickBorrow";
            dtPickBorrow.Size = new Size(169, 23);
            dtPickBorrow.TabIndex = 59;
            dtPickBorrow.Value = new DateTime(2023, 11, 1, 0, 0, 0, 0);
            dtPickBorrow.ValueChanged += dtPickBorrow_ValueChanged;
            // 
            // dtPickReturn
            // 
            dtPickReturn.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtPickReturn.CustomFormat = "yyyy-MM-dd";
            dtPickReturn.Format = DateTimePickerFormat.Custom;
            dtPickReturn.Location = new Point(136, 209);
            dtPickReturn.Name = "dtPickReturn";
            dtPickReturn.Size = new Size(169, 23);
            dtPickReturn.TabIndex = 60;
            dtPickReturn.Value = new DateTime(2023, 11, 1, 0, 0, 0, 0);
            // 
            // BorrowingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 248, 220);
            ClientSize = new Size(910, 457);
            Controls.Add(dtPickReturn);
            Controls.Add(dtPickBorrow);
            Controls.Add(label7);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(borrowDataGridView);
            Controls.Add(txtBookID);
            Controls.Add(txtMemberID);
            Controls.Add(txtborrowID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowingForm";
            Text = "BorrowingForm";
            Load += BorrowingForm_Load;
            ((System.ComponentModel.ISupportInitialize)borrowDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button btnSearch;
        private Button btnLogout;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView borrowDataGridView;
        private TextBox txtBookID;
        private TextBox txtMemberID;
        private TextBox txtborrowID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtPickBorrow;
        private DateTimePicker dtPickReturn;
    }
}