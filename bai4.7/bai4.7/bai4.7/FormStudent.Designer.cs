namespace bai_2_12_10
{
    partial class FormStudent
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
            components = new System.ComponentModel.Container();

            // ContextMenuStrip cho DataGridView
            contextMenuStrip = new ContextMenuStrip(components);
            deleteRowToolStripMenuItem = new ToolStripMenuItem();
            addNewRowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();

            // DataGridView
            dataGridViewStudent = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            studentCodeColumn = new DataGridViewTextBoxColumn();
            emailColumn = new DataGridViewTextBoxColumn();
            phoneColumn = new DataGridViewTextBoxColumn();
            addressColumn = new DataGridViewTextBoxColumn();
            dateOfBirthColumn = new DataGridViewTextBoxColumn();
            majorColumn = new DataGridViewTextBoxColumn();

            // Panel for Buttons
            buttonPanel = new Panel();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            clearButton = new Button();
            saveButton = new Button();

            // ContextMenuStrip Items Setup
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteRowToolStripMenuItem, addNewRowToolStripMenuItem, toolStripSeparator1, editToolStripMenuItem });

            deleteRowToolStripMenuItem.Text = "Xóa dòng";
            addNewRowToolStripMenuItem.Text = "Thêm dòng mới";
            editToolStripMenuItem.Text = "Chỉnh sửa";

            // DataGridView Setup
            dataGridViewStudent.AllowUserToAddRows = true;
            dataGridViewStudent.AllowUserToDeleteRows = true;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, studentCodeColumn, emailColumn, phoneColumn, addressColumn, dateOfBirthColumn, majorColumn });
            dataGridViewStudent.ContextMenuStrip = contextMenuStrip;
            dataGridViewStudent.Dock = DockStyle.Fill;
            dataGridViewStudent.Location = new Point(0, 50);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.Size = new Size(800, 400);
            dataGridViewStudent.TabIndex = 0;

            // Setup Columns
            idColumn.HeaderText = "ID";
            idColumn.Name = "Id";
            idColumn.Width = 50;

            nameColumn.HeaderText = "Tên";
            nameColumn.Name = "Name";
            nameColumn.Width = 150;

            studentCodeColumn.HeaderText = "Mã SV";
            studentCodeColumn.Name = "StudentCode";
            studentCodeColumn.Width = 100;

            emailColumn.HeaderText = "Email";
            emailColumn.Name = "Email";
            emailColumn.Width = 150;

            phoneColumn.HeaderText = "Điện thoại";
            phoneColumn.Name = "PhoneNumber";
            phoneColumn.Width = 120;

            addressColumn.HeaderText = "Địa chỉ";
            addressColumn.Name = "Address";
            addressColumn.Width = 150;

            dateOfBirthColumn.HeaderText = "Ngày sinh";
            dateOfBirthColumn.Name = "DateOfBirth";
            dateOfBirthColumn.Width = 120;

            majorColumn.HeaderText = "Chuyên ngành";
            majorColumn.Name = "Major";
            majorColumn.Width = 150;

            // Button Panel Setup
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Height = 50;
            buttonPanel.Padding = new Padding(10);

            // Buttons Setup
            addButton.Text = "Thêm";
            addButton.Location = new Point(10, 10);
            addButton.Size = new Size(80, 30);
            buttonPanel.Controls.Add(addButton);

            editButton.Text = "Sửa";
            editButton.Location = new Point(100, 10);
            editButton.Size = new Size(80, 30);
            buttonPanel.Controls.Add(editButton);

            deleteButton.Text = "Xóa";
            deleteButton.Location = new Point(190, 10);
            deleteButton.Size = new Size(80, 30);
            buttonPanel.Controls.Add(deleteButton);

            clearButton.Text = "Xóa dữ liệu";
            clearButton.Location = new Point(280, 10);
            clearButton.Size = new Size(80, 30);
            buttonPanel.Controls.Add(clearButton);

            saveButton.Text = "Lưu";
            saveButton.Location = new Point(370, 10);
            saveButton.Size = new Size(80, 30);
            buttonPanel.Controls.Add(saveButton);

            // Form Setup
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewStudent);
            Controls.Add(buttonPanel);
            Name = "FormStudent";
            Text = "Quản lý Sinh viên";
        }

        #endregion

        private DataGridView dataGridViewStudent;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn studentCodeColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn phoneColumn;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn dateOfBirthColumn;
        private DataGridViewTextBoxColumn majorColumn;

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripMenuItem addNewRowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem editToolStripMenuItem;

        private Panel buttonPanel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button clearButton;
        private Button saveButton;
    }
}
