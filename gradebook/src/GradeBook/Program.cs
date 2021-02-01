using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Jordan's grade book");
            book.AddGrade(95.0);
            book.AddGrade(76);
            book.AddGrade(56.1);
            book.ShowStatistics();

            // var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            double result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}
