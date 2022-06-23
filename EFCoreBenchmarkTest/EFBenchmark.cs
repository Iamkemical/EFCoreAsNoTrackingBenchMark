using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBenchmarkTest
{
    [MemoryDiagnoser]
    [RankColumn]
    public class EFBenchmark
    {
        public async Task AddStudentAsync()
        {
            var students = new List<Student>();
            using (var context = new SchoolDbContext())
            {
                students.Add(new Student
                {
                    Name = "Jeff"
                });
                students.Add(new Student
                {
                    Name = "David"
                });
                students.Add(new Student
                {
                    Name = "Emma"
                });
                students.Add(new Student { Name = "Chuks" }); students.Add(new Student { Name = "Angela" }); students.Add(new Student { Name = "Eghosa" });
                students.Add(new Student { Name = "Prince" }); students.Add(new Student { Name = "Sophie" });
                students.Add(new Student { Name = "Gabriel" }); students.Add(new Student { Name = "Daniel" });

                await context.AddRangeAsync(students);
                await context.SaveChangesAsync();
            }
        }

        [Benchmark]
        public async Task GetStudentAsync_WithAsNoTracking()
        {
            using(var context = new SchoolDbContext())
            {
                await context.Students.AsNoTracking().ToListAsync();
            }
        }

        [Benchmark]
        public async Task GetStudentAsync_WithoutAsNoTracking()
        {
            using (var context = new SchoolDbContext())
            {
                await context.Students.ToListAsync();
            }
        }
    }
}
