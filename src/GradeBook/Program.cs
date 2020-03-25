using System;
using System.Collections.Generic;

namespace GradeBook
{   

    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Simons Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStats();

            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The average grade is {stats.Average:N2}");
            System.Console.WriteLine($"The maximum grade is {stats.High}");
            System.Console.WriteLine($"The minimum grade is {stats.Low}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");

            // var grades = new List<double>() 22
            // {12.4, 11.2, 24.3, 25.2};
            // grades.Add(56.1)");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("Enter a Grade. Press q once you are done.");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("***");
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("A grade has been added!");
        }
    }
}
