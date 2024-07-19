using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Masosv { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách học sinh
        List<Student> students = new List<Student>
{
    new Student { Masosv = 001, Name = "An", Age = 18 },
    new Student { Masosv = 002, Name = "Huy", Age = 20 },
    new Student { Masosv = 003,  Name = "Lun", Age = 17 },
    new Student { Masosv = 004, Name = "Dat", Age = 19 },
    new Student { Masosv = 005, Name = "Em", Age = 15 }
};
        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("Danh sách toàn bo sinh viên:");
        foreach (var student in students)
        {
            Console.WriteLine($"Masosv: {student.Masosv}, Tên: {student.Name}, Tuoi: {student.Age}");
        }

        // b. Tìm học sinh có tuổi từ 15 đến 18
        Console.WriteLine("\nSinh vien co tuoi tu 15 den 18:");
        var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var student in studentsAge15To18)
        {
            Console.WriteLine($"Masosv: {student.Masosv}, Tên: {student.Name}, Tuoi: {student.Age}");
        }

        // c. Tìm học sinh có tên bắt đầu bằng chữ "A"
        Console.WriteLine("\nSinh vien co ten bat dau bang chu'A'':");
        var studentsStartWithA = students.Where(s => s.Name.StartsWith("A"));
        foreach (var student in studentsStartWithA)
        {
            Console.WriteLine($"Masosv: {student.Masosv}, Tên: {student.Name}, Tuoi: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca sinh vien: {totalAge}");

        // e. Tìm học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine($"\nSinh vien co tuoi lon nhat: Masosv: {oldestStudent.Masosv}, Tên: {oldestStudent.Name}, Tuoi: {oldestStudent.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần
        var sortedStudents = students.OrderBy(s => s.Age);
        Console.WriteLine("\nDanh sach sinh vien sau khi sap xep tuoi tang dan :");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Masosv: {student.Masosv}, Tên: {student.Name}, Tuoi: {student.Age}");
        }

    }
}
