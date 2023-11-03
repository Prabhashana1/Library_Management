namespace Library_Management
{
    partial class LibrarianForm
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
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            btnBorrowing = new Button();
            btnBook = new Button();
            btnMember = new Button();
            panelForm = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.DimGray;
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(btnBorrowing);
            panelLeft.Controls.Add(btnBook);
            panelLeft.Controls.Add(btnMember);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 456);
            panelLeft.TabIndex = 0;
            panelLeft.Paint += panelLeft_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_64;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBorrowing
            // 
            btnBorrowing.BackColor = Color.DimGray;
            btnBorrowing.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrowing.FlatStyle = FlatStyle.Flat;
            btnBorrowing.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrowing.ForeColor = Color.White;
            btnBorrowing.Image = Properties.Resources.icons8_book_51;
            btnBorrowing.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrowing.Location = new Point(0, 294);
            btnBorrowing.Name = "btnBorrowing";
            btnBorrowing.Size = new Size(200, 56);
            btnBorrowing.TabIndex = 2;
            btnBorrowing.Text = "Borrowing";
            btnBorrowing.UseVisualStyleBackColor = false;
            btnBorrowing.Click += btnBorrowing_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.DimGray;
            btnBook.BackgroundImageLayout = ImageLayout.Zoom;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.ForeColor = Color.White;
            btnBook.Image = Properties.Resources.icons8_book_50;
            btnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnBook.Location = new Point(0, 232);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(200, 56);
            btnBook.TabIndex = 1;
            btnBook.Text = "Books";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnMember
            // 
            btnMember.BackColor = Color.Tan;
            btnMember.BackgroundImageLayout = ImageLayout.Zoom;
            btnMember.FlatStyle = FlatStyle.Flat;
            btnMember.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMember.ForeColor = Color.White;
            btnMember.Image = Properties.Resources.icons8_people_50__1_;
            btnMember.ImageAlign = ContentAlignment.MiddleLeft;
            btnMember.Location = new Point(0, 173);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(200, 53);
            btnMember.TabIndex = 0;
            btnMember.Text = "Members";
            btnMember.UseVisualStyleBackColor = false;
            btnMember.Click += btnMember_Click;
            // 
            // panelForm
            // 
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(200, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(911, 456);
            panelForm.TabIndex = 1;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 456);
            Controls.Add(panelForm);
            Controls.Add(panelLeft);
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelForm;
        private Button btnMember;
        private Button btnBorrowing;
        private Button btnBook;
        private PictureBox pictureBox1;
    }
}