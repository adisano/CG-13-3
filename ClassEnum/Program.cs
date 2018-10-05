using System;

namespace ClassEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Please enter your first name:");
            string firstname = Console.ReadLine().ToLower();
            Student.FirstName First = (Student.FirstName)Enum.Parse(typeof(Student.FirstName), firstname);
            student.LastNames(First);
            Console.ReadLine();
        }
    }
}
