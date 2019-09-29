using Api.EntityTypes;
using Api.EntityTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implementation
{
    public static class ExtensonHelper
    {
        internal static List<StudentAddresses> MapStudentAddresses(this SchoolDbEntities ctx)
        {
            return ctx.Students.Include("StudentAddress").Select(x => new StudentAddresses()
            {
                Id = x.StudentId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.StudentAddress == null ? null : new AddressModel()
                {
                    StudentId = x.StudentId,
                    Address1 = x.StudentAddress.Address1,
                    Address2 = x.StudentAddress.Address2,
                    City = x.StudentAddress.City,
                    State = x.StudentAddress.State
                }
            }).ToList<StudentAddresses>();
        }
    }
}
