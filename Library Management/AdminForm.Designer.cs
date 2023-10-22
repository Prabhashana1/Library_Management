namespace Library_Management
{
    partial class AdminForm
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
            label1 = new Label();
            lbluserId = new Label();
            txtuId = new TextBox();
            txtuName = new TextBox();
            lbluserName = new Label();
            txtName = new TextBox();
            lblname = new Label();
            txtPassword = new TextBox();
            lblpassword = new Label();
            userDataGridView = new DataGridView();
            lblroll = new Label();
            comBoxRoll = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lbluserId
            // 
            lbluserId.AutoSize = true;
            lbluserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbluserId.Location = new Point(25, 63);
            lbluserId.Name = "lbluserId";
            lbluserId.Size = new Size(73, 21);
            lbluserId.TabIndex = 1;
            lbluserId.Text = "User ID: ";
            // 
            // txtuId
            // 
            txtuId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuId.Location = new Point(132, 61);
            txtuId.Name = "txtuId";
            txtuId.Size = new Size(219, 29);
            txtuId.TabIndex = 2;
            // 
            // txtuName
            // 
            txtuName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuName.Location = new Point(132, 118);
            txtuName.Name = "txtuName";
            txtuName.Size = new Size(219, 29);
            txtuName.TabIndex = 4;
            // 
            // lbluserName
            // 
            lbluserName.AutoSize = true;
            lbluserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbluserName.Location = new Point(24, 121);
            lbluserName.Name = "lbluserName";
            lbluserName.Size = new Size(102, 21);
            lbluserName.TabIndex = 3;
            lbluserName.Text = "User Name: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(132, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 29);
            txtName.TabIndex = 6;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(26, 178);
            lblname.Name = "lblname";
            lblname.Size = new Size(64, 21);
            lblname.TabIndex = 5;
            lblname.Text = "Name: ";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(132, 243);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 29);
            txtPassword.TabIndex = 8;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.Location = new Point(24, 243);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(90, 21);
            lblpassword.TabIndex = 7;
            lblpassword.Text = "Password: ";
            // 
            // userDataGridView
            // 
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.BackgroundColor = SystemColors.ControlLight;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(362, 12);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Size = new Size(482, 455);
            userDataGridView.TabIndex = 9;
            userDataGridView.MouseClick += userDataGridView_MouseClick;
            // 
            // lblroll
            // 
            lblroll.AutoSize = true;
            lblroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblroll.Location = new Point(28, 307);
            lblroll.Name = "lblroll";
            lblroll.Size = new Size(86, 21);
            lblroll.TabIndex = 10;
            lblroll.Text = "User Roll: ";
            // 
            // comBoxRoll
            // 
            comBoxRoll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comBoxRoll.FormattingEnabled = true;
            comBoxRoll.Items.AddRange(new object[] { "Administrator", "Librarian", "Member" });
            comBoxRoll.Location = new Point(132, 307);
            comBoxRoll.Name = "comBoxRoll";
            comBoxRoll.Size = new Size(219, 29);
            comBoxRoll.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(18, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(141, 366);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(266, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 37);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(141, 429);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 37);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(856, 479);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(comBoxRoll);
            Controls.Add(lblroll);
            Controls.Add(userDataGridView);
            Controls.Add(txtPassword);
            Controls.Add(lblpassword);
            Controls.Add(txtName);
            Controls.Add(lblname);
            Controls.Add(txtuName);
            Controls.Add(lbluserName);
            Controls.Add(txtuId);
            Controls.Add(lbluserId);
            Controls.Add(label1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbluserId;
        private TextBox txtuId;
        private TextBox txtuName;
        private Label lbluserName;
        private TextBox txtName;
        private Label lblname;
        private TextBox txtPassword;
        private Label lblpassword;
        private DataGridView userDataGridView;
        private Label lblroll;
        private ComboBox comBoxRoll;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
    }
}