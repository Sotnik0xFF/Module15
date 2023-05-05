﻿namespace Module15;

class Program
{
    static void Main(string[] args)
    {
        var classes = new[]
        {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
        var allStudents = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
        Console.ReadKey();
    }

    static string[] GetAllStudents(Classroom[] classes) => classes.SelectMany(c => c.Students).ToArray();

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}