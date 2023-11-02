namespace Library_Management
{
    partial class ManageMemberForm
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
            btnSearch = new Button();
            btnLogout = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            memberDataGridView = new DataGridView();
            txtPhoneNO = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtname = new TextBox();
            txtMemberID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtUname = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(244, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 31);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 255, 255);
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Location = new Point(5, 425);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 28);
            btnLogout.TabIndex = 34;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(158, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 43);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(244, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 43);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(158, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 43);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(72, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 43);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // memberDataGridView
            // 
            memberDataGridView.AllowUserToAddRows = false;
            memberDataGridView.AllowUserToDeleteRows = false;
            memberDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            memberDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberDataGridView.Location = new Point(327, 14);
            memberDataGridView.Name = "memberDataGridView";
            memberDataGridView.ReadOnly = true;
            memberDataGridView.RowTemplate.Height = 25;
            memberDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberDataGridView.Size = new Size(575, 426);
            memberDataGridView.TabIndex = 29;
            memberDataGridView.Click += memberDataGridView_Click;
            memberDataGridView.MouseClick += memberDataGridView_MouseClick;
            // 
            // txtPhoneNO
            // 
            txtPhoneNO.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNO.Location = new Point(137, 288);
            txtPhoneNO.Name = "txtPhoneNO";
            txtPhoneNO.Size = new Size(169, 27);
            txtPhoneNO.TabIndex = 28;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(137, 248);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(169, 27);
            txtAddress.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(137, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 27);
            txtEmail.TabIndex = 26;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtname.Location = new Point(137, 86);
            txtname.Name = "txtname";
            txtname.Size = new Size(169, 27);
            txtname.TabIndex = 25;
            // 
            // txtMemberID
            // 
            txtMemberID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMemberID.Location = new Point(137, 48);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(101, 27);
            txtMemberID.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 250);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 22;
            label5.Text = "Address :  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 210);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 21;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 90);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 20;
            label3.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 19;
            label2.Text = "Member ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 18;
            label1.Text = "Manage Member";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 291);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 23;
            label6.Text = "Phone No : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 128);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 36;
            label7.Text = "User Name : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 170);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 37;
            label8.Text = "Password : ";
            // 
            // txtUname
            // 
            txtUname.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUname.Location = new Point(137, 125);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(169, 27);
            txtUname.TabIndex = 38;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(137, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(169, 27);
            txtPassword.TabIndex = 39;
            // 
            // ManageMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 248, 220);
            ClientSize = new Size(910, 457);
            Controls.Add(txtPassword);
            Controls.Add(txtUname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(memberDataGridView);
            Controls.Add(txtPhoneNO);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtname);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageMemberForm";
            Load += ManageMemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnLogout;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView memberDataGridView;
        private TextBox txtPhoneNO;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtname;
        private TextBox txtMemberID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUname;
        private TextBox txtPassword;
    }
}