using System;
using System.Collections.Generic;
namespace GradeBook
{   
    
    class Program
    {   
        static void Main(string[] args)
        {   
            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.61);
            book.AddGrade(90.5);

            var grades = new List<double>() { 12.7,10.3,6.11,4.1};
            grades.Add(56.1);

            var res = 0.0;
            foreach(var number in grades){
                res+=number;
            }
            var  ans = res/grades.Count;
            Console.WriteLine(ans);
        }
    }
}
