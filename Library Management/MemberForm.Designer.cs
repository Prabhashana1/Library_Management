namespace Library_Management
{
    partial class MemberForm
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
            panel1 = new Panel();
            btnBorrowing = new Button();
            btnBook = new Button();
            btnMember = new Button();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnBorrowing);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(btnMember);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 449);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            btnBorrowing.Location = new Point(0, 311);
            btnBorrowing.Name = "btnBorrowing";
            btnBorrowing.Size = new Size(200, 56);
            btnBorrowing.TabIndex = 7;
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
            btnBook.Location = new Point(0, 239);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(200, 56);
            btnBook.TabIndex = 6;
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
            btnMember.Location = new Point(0, 175);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(200, 53);
            btnMember.TabIndex = 5;
            btnMember.Text = "Members";
            btnMember.UseVisualStyleBackColor = false;
            btnMember.Click += btnMember_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_64;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelForm
            // 
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(200, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(800, 449);
            panelForm.TabIndex = 1;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 449);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            Name = "MemberForm";
            Text = "MemberForm";
            Load += MemberForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelForm;
        private PictureBox pictureBox1;
        private Button btnMember;
        private Button btnBook;
        private Button btnBorrowing;
    }
}