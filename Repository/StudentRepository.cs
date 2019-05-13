using DataLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            using (var dbcontext = new Context())
            {
                return dbcontext.Students.ToList();
            }
        }
    }
}
