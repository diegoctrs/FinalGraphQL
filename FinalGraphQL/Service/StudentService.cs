using FinalGraphQL.lService;
using FinalGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalGraphQL.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for(int i = 1; i <= 9; i++)
            {
                students.Add(new Student() {
                    StundentId = i, 
                    Name = "Stu" + i,
                    Roll = "100" + i
                });
            }
            return students;
        }
    }
}
