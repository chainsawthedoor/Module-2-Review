namespace Module_2_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            
            var studentOne = new Student();
            studentOne.Name = "Jeff";
            studentOne.ID = 11;
            studentOne.AddGrade(94.3);
            studentOne.AddGrade(91.5);
            studentOne.AddGrade(89.2);
            students.Add(studentOne);
            
            var studentTwo = new Student("John", 12);
            studentTwo.AddGrade(82.2);
            studentTwo.AddGrade(79.0);
            studentTwo.AddGrade(88.1);
            students.Add(studentTwo);
            
            var studentThree = new Student()
            {
                Name = "Bill",
                ID = 13
                    
            };
            studentThree.AddGrade(91.5);
            studentThree.AddGrade(82.2);
            studentThree.AddGrade(79.8);
            students.Add(studentThree);

            var studentFour = new Student("Liam", 14);
            studentFour.AddGrade(68.3);
            studentFour.AddGrade(70.6);
            studentFour.AddGrade(69.2);
            students.Add(studentFour);

            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.Name}\nStudent ID: {student.ID}\nStudent Grades:");
                foreach (var grade in student.Grades)
                {
                    Console.WriteLine(grade);
                }
                student.CalculateAverageGrade();
                Console.WriteLine("\n");
            }
            






        }
    }
}