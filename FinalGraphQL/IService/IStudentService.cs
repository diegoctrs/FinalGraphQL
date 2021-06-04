using FinalGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalGraphQL.lService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
