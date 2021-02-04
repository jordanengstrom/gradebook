using System;
using System.Collections.Generic;

namespace GradeBook
{    
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }
        public string Name
            { get; set; }
    };
    public class Book : NamedObject
    {
        private List<double> grades = new List<double>();
        private string name;
        public Book(string name) :  base("")
        {
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void ShowStatistics()
        {
            double result = 0.0;
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;

            foreach(var number in this.grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            
            result /= grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");

        }
    }
}