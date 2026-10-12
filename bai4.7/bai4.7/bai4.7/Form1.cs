namespace bai_2_12_10
{
    public partial class Form1 : Form
    {
        // Biến để quản lý FormStudent (không mở lại cùng một form)
        private FormStudent formStudent = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Phương thức mở FormStudent (MDI Child)
        private void OpenFormStudent()
        {
            if (formStudent == null || formStudent.IsDisposed)
            {
                formStudent = new FormStudent();
                formStudent.MdiParent = this;
                formStudent.FormClosed += (s, e) =>
                {
                    formStudent = null;
                    statusLabel.Text = "FormStudent đã đóng";
                };
                formStudent.Show();
                statusLabel.Text = "FormStudent đã mở";
            }
            else
            {
                // Nếu form đã tồn tại, đưa nó lên phía trước
                formStudent.BringToFront();
                formStudent.Focus();
            }
        }

        // Sự kiện cho menu Quản lý Sinh viên
        public void ShowStudentForm()
        {
            OpenFormStudent();
        }

        // Cập nhật StatusStrip từ child form
        public void UpdateStatus(string message)
        {
            statusLabel.Text = message;
        }
    }
}
