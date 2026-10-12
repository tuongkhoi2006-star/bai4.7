namespace bai_2_12_10
{
    public partial class FormStudent : Form
    {
        private List<Student> students = new List<Student>();
        private Form1 parentForm;

        public FormStudent()
        {
            InitializeComponent();
            this.Load += FormStudent_Load;
            deleteRowToolStripMenuItem.Click += DeleteRowToolStripMenuItem_Click;
            addNewRowToolStripMenuItem.Click += AddNewRowToolStripMenuItem_Click;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            deleteButton.Click += DeleteButton_Click;
            clearButton.Click += ClearButton_Click;
            saveButton.Click += SaveButton_Click;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            // Lấy reference đến FormMain
            parentForm = (Form1)this.MdiParent;

            // Lấy dữ liệu mẫu
            LoadSampleData();

            // Cập nhật StatusStrip trên Form chính
            if (parentForm != null)
            {
                parentForm.UpdateStatus("FormStudent đã tải - Số lượng sinh viên: " + students.Count);
            }
        }

        /// <summary>
        /// Tải dữ liệu mẫu vào DataGridView
        /// </summary>
        private void LoadSampleData()
        {
            students.Clear();

            // Thêm dữ liệu mẫu
            students.Add(new Student(1, "Nguyễn Văn A", "SV001", "nguyenvana@gmail.com", "0123456789", "Hà Nội", new DateTime(2000, 1, 15), "Khoa học máy tính"));
            students.Add(new Student(2, "Trần Thị B", "SV002", "tranthib@gmail.com", "0987654321", "TP. HCM", new DateTime(2001, 5, 20), "Kỹ thuật phần mềm"));
            students.Add(new Student(3, "Lê Minh C", "SV003", "leminhc@gmail.com", "0912345678", "Đà Nẵng", new DateTime(1999, 8, 10), "Hệ thống thông tin"));

            RefreshDataGridView();
        }

        /// <summary>
        /// Cập nhật DataGridView từ danh sách students
        /// </summary>
        private void RefreshDataGridView()
        {
            dataGridViewStudent.Rows.Clear();

            foreach (var student in students)
            {
                dataGridViewStudent.Rows.Add(
                    student.Id,
                    student.Name,
                    student.StudentCode,
                    student.Email,
                    student.PhoneNumber,
                    student.Address,
                    student.DateOfBirth.ToString("dd/MM/yyyy"),
                    student.Major
                );
            }

            // Cập nhật trạng thái
            if (parentForm != null)
            {
                parentForm.UpdateStatus($"Đã tải {students.Count} sinh viên");
            }
        }

        /// <summary>
        /// Xóa dòng được chọn
        /// </summary>
        private void DeleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStudent.SelectedRows[0].Index;

                if (selectedIndex < students.Count)
                {
                    string studentName = students[selectedIndex].Name;
                    students.RemoveAt(selectedIndex);

                    MessageBox.Show($"Đã xóa sinh viên: {studentName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Thêm dòng mới
        /// </summary>
        private void AddNewRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.Rows.Add();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                MessageBox.Show("Chỉnh sửa dòng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Có thể mở dialog để chỉnh sửa chi tiết
            }
        }

        /// <summary>
        /// Nút Thêm - Thêm sinh viên mới vào danh sách
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo sinh viên mới với ID tự động tăng
                int newId = students.Count > 0 ? students.Max(s => s.Id) + 1 : 1;

                Student newStudent = new Student(
                    newId,
                    "Sinh viên mới",
                    $"SV{newId.ToString().PadLeft(3, '0')}",
                    "email@example.com",
                    "0123456789",
                    "Địa chỉ",
                    DateTime.Now.AddYears(-20),
                    "Chuyên ngành"
                );

                students.Add(newStudent);
                RefreshDataGridView();

                MessageBox.Show("Đã thêm sinh viên mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nút Sửa - Chỉnh sửa sinh viên được chọn
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStudent.SelectedRows[0].Index;

                if (selectedIndex < students.Count)
                {
                    MessageBox.Show($"Chỉnh sửa: {students[selectedIndex].Name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Có thể mở dialog để chỉnh sửa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Nút Xóa - Xóa sinh viên được chọn
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStudent.SelectedRows[0].Index;

                if (selectedIndex < students.Count)
                {
                    if (MessageBox.Show($"Bạn có chắc chắn muốn xóa {students[selectedIndex].Name}?", 
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        students.RemoveAt(selectedIndex);
                        RefreshDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Nút Xóa dữ liệu - Xóa tất cả dữ liệu
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả dữ liệu?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                students.Clear();
                RefreshDataGridView();
                MessageBox.Show("Đã xóa tất cả dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Nút Lưu - Lưu dữ liệu từ DataGridView vào danh sách
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                students.Clear();

                foreach (DataGridViewRow row in dataGridViewStudent.Rows)
                {
                    if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    {
                        try
                        {
                            int id = int.Parse(row.Cells[0].Value?.ToString() ?? "0");
                            string name = row.Cells[1].Value?.ToString() ?? "";
                            string code = row.Cells[2].Value?.ToString() ?? "";
                            string email = row.Cells[3].Value?.ToString() ?? "";
                            string phone = row.Cells[4].Value?.ToString() ?? "";
                            string address = row.Cells[5].Value?.ToString() ?? "";
                            DateTime dob = DateTime.TryParse(row.Cells[6].Value?.ToString(), out var date) ? date : DateTime.Now;
                            string major = row.Cells[7].Value?.ToString() ?? "";

                            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(code))
                            {
                                students.Add(new Student(id, name, code, email, phone, address, dob, major));
                            }
                        }
                        catch
                        {
                            // Bỏ qua hàng có dữ liệu không hợp lệ
                        }
                    }
                }

                MessageBox.Show($"Đã lưu {students.Count} sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (parentForm != null)
                {
                    parentForm.UpdateStatus($"Đã lưu {students.Count} sinh viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
