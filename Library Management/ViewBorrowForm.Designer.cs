namespace Library_Management
{
    partial class ViewBorrowForm
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
            viewBorrowDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)viewBorrowDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewBorrowDataGridView
            // 
            viewBorrowDataGridView.AllowUserToAddRows = false;
            viewBorrowDataGridView.AllowUserToDeleteRows = false;
            viewBorrowDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewBorrowDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBorrowDataGridView.Location = new Point(12, 12);
            viewBorrowDataGridView.Name = "viewBorrowDataGridView";
            viewBorrowDataGridView.ReadOnly = true;
            viewBorrowDataGridView.RowTemplate.Height = 25;
            viewBorrowDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBorrowDataGridView.Size = new Size(776, 426);
            viewBorrowDataGridView.TabIndex = 53;
            viewBorrowDataGridView.CellContentClick += viewBorrowDataGridView_CellContentClick;
            // 
            // ViewBorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewBorrowDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBorrowForm";
            Text = "ViewBorrowForm";
            Load += ViewBorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewBorrowDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewBorrowDataGridView;
    }
}