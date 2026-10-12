namespace bai_2_12_10
{
    /// <summary>
    /// Lớp Model để lưu trữ thông tin sinh viên
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Major { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, string studentCode, string email, string phoneNumber, string address, DateTime dateOfBirth, string major)
        {
            Id = id;
            Name = name;
            StudentCode = studentCode;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            DateOfBirth = dateOfBirth;
            Major = major;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Name}, Mã SV: {StudentCode}, Email: {Email}";
        }
    }
}
