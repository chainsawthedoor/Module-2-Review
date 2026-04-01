using System.Security.Cryptography;

namespace Module_2_Review;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; } = new List<double>();

    public void AddGrade(double grade)
    {
        Grades.AddRange(grade);
    }

    public void CalculateAverageGrade()
    {
        double avgGrade = Grades.Average();
        Console.WriteLine($"Average grade: {avgGrade}");
        if (Grades.Count == 0)
        {
            Console.WriteLine("No grades found");
        }
    }

    public Student()
    {
        
    }

    public Student(string name, int id)
    {
        Name = name;
        ID = id;
    }
    
}