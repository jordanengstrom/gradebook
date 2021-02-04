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
        }
    }
}
