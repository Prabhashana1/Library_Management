namespace Library_Management
{
    partial class LoginForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblName = new Label();
            lblPass = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            cBoxPass = new CheckBox();
            lblLogin = new Label();
            btnLogin = new Button();
            lblCopy = new Label();
            comBoxRoll = new ComboBox();
            lblRoll = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 0;
            label1.Text = "Library Management";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(26, 176);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 21);
            lblName.TabIndex = 1;
            lblName.Text = "User Name: ";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(26, 223);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(86, 21);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(159, 171);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 29);
            txtName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(159, 220);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(167, 29);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // cBoxPass
            // 
            cBoxPass.AutoSize = true;
            cBoxPass.Location = new Point(158, 258);
            cBoxPass.Name = "cBoxPass";
            cBoxPass.Size = new Size(108, 19);
            cBoxPass.TabIndex = 5;
            cBoxPass.Text = "Show Password";
            cBoxPass.UseVisualStyleBackColor = true;
            cBoxPass.CheckedChanged += cBoxPass_CheckedChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Red;
            lblLogin.Location = new Point(146, 65);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(111, 25);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login Here";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(159, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 47);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblCopy
            // 
            lblCopy.AutoSize = true;
            lblCopy.ForeColor = Color.LightGray;
            lblCopy.Location = new Point(4, 393);
            lblCopy.Name = "lblCopy";
            lblCopy.Size = new Size(104, 15);
            lblCopy.TabIndex = 0;
            lblCopy.Text = "© 2023 Jayarathna";
            // 
            // comBoxRoll
            // 
            comBoxRoll.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxRoll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comBoxRoll.FormattingEnabled = true;
            comBoxRoll.Items.AddRange(new object[] { "administrator", "librarian", "member" });
            comBoxRoll.Location = new Point(158, 122);
            comBoxRoll.Name = "comBoxRoll";
            comBoxRoll.Size = new Size(168, 29);
            comBoxRoll.TabIndex = 0;
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoll.Location = new Point(28, 126);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(48, 21);
            lblRoll.TabIndex = 9;
            lblRoll.Text = "Roll: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2WRYSmUVNStzHmASFjBNXo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(409, 411);
            Controls.Add(lblRoll);
            Controls.Add(comBoxRoll);
            Controls.Add(lblCopy);
            Controls.Add(btnLogin);
            Controls.Add(lblLogin);
            Controls.Add(cBoxPass);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(lblPass);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblPass;
        private TextBox txtName;
        private TextBox txtPass;
        private CheckBox cBoxPass;
        private Label lblLogin;
        private Button btnLogin;
        private Label lblCopy;
        private ComboBox comBoxRoll;
        private Label lblRoll;
    }
}