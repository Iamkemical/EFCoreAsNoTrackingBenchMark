using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBenchmarkTest
{
    
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
    }
}
