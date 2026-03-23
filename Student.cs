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
    
    
    
}