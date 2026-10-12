namespace bai_2_12_10
{
    partial class Form1
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
            components = new System.ComponentModel.Container();

            // MenuStrip
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            studentManagementToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();

            // ToolStrip
            toolStrip = new ToolStrip();
            openStudentToolStripButton = new ToolStripButton();

            // StatusStrip
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();

            // MenuStrip Items Setup
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, categoryToolStripMenuItem, windowToolStripMenuItem });

            fileToolStripMenuItem.Text = "Hệ thống";
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });

            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;

            categoryToolStripMenuItem.Text = "Danh mục";
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentManagementToolStripMenuItem, productManagementToolStripMenuItem });

            studentManagementToolStripMenuItem.Text = "Quản lý Sinh viên";
            studentManagementToolStripMenuItem.Click += StudentManagementToolStripMenuItem_Click;

            productManagementToolStripMenuItem.Text = "Quản lý Sản phẩm";
            productManagementToolStripMenuItem.Click += ProductManagementToolStripMenuItem_Click;

            windowToolStripMenuItem.Text = "Cửa sổ (Window)";
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem });

            cascadeToolStripMenuItem.Text = "Sắp xếp Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;

            tileHorizontalToolStripMenuItem.Text = "Sắp xếp Tile Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;

            tileVerticalToolStripMenuItem.Text = "Sắp xếp Tile Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;

            // ToolStrip Items Setup
            toolStrip.Items.AddRange(new ToolStripItem[] { openStudentToolStripButton });
            openStudentToolStripButton.Text = "Mở Sinh viên";
            openStudentToolStripButton.Click += StudentManagementToolStripMenuItem_Click;

            // StatusStrip Items Setup
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusLabel.Text = "Sẵn sàng";

            // Form Setup
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Text = "Quản lý Dữ liệu - MDI Application";
            WindowState = FormWindowState.Maximized;
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem studentManagementToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;

        private ToolStrip toolStrip;
        private ToolStripButton openStudentToolStripButton;

        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentForm();
        }

        private void ProductManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sẽ được triển khai ở Form1.cs
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
