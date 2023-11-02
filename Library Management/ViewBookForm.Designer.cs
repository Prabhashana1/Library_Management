namespace Library_Management
{
    partial class ViewBookForm
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
            viewBookDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)viewBookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewBookDataGridView
            // 
            viewBookDataGridView.AllowUserToAddRows = false;
            viewBookDataGridView.AllowUserToDeleteRows = false;
            viewBookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookDataGridView.Location = new Point(12, 12);
            viewBookDataGridView.Name = "viewBookDataGridView";
            viewBookDataGridView.ReadOnly = true;
            viewBookDataGridView.RowTemplate.Height = 25;
            viewBookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBookDataGridView.Size = new Size(776, 426);
            viewBookDataGridView.TabIndex = 53;
            // 
            // ViewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewBookDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBookForm";
            Text = "ViewBookForm";
            Load += ViewBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewBookDataGridView;
    }
}