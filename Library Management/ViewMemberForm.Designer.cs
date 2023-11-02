namespace Library_Management
{
    partial class ViewMemberForm
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
            viewMemberDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)viewMemberDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewMemberDataGridView
            // 
            viewMemberDataGridView.AllowUserToAddRows = false;
            viewMemberDataGridView.AllowUserToDeleteRows = false;
            viewMemberDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewMemberDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewMemberDataGridView.Location = new Point(12, 12);
            viewMemberDataGridView.Name = "viewMemberDataGridView";
            viewMemberDataGridView.ReadOnly = true;
            viewMemberDataGridView.RowTemplate.Height = 25;
            viewMemberDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewMemberDataGridView.Size = new Size(776, 426);
            viewMemberDataGridView.TabIndex = 52;
            // 
            // ViewMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewMemberDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMemberForm";
            Text = "ViewMemberForm";
            Load += ViewMemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewMemberDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewMemberDataGridView;
    }
}