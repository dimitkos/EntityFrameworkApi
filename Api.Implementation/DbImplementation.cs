using Api.EntityTypes;
using Api.EntityTypes.Model;
using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implementation
{
    public class DbImplementation : IService
    {
        public GetAllStudentResponse GetAllStudents()
        {
            List<StudentModel> students = null;

            using (var ctx = new SchoolDbEntities())
            {
                students = ctx.Students.Include("StudentAddress")
                            .Select(s => new StudentModel()
                            {
                                Id = s.StudentId,
                                FirstName = s.FirstName,
                                LastName = s.LastName
                            }).ToList<StudentModel>();
            }

            return new GetAllStudentResponse
            {
                Students = students
            };
        }
    }
}
