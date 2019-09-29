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
                students = ctx.Students
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

        //public GetAddressesOfStudentsResponse GetAddressesOfStudents()
        //{
        //    List<StudentAddresses> addresses = null;
        //    using (var ctx = new SchoolDbEntities())
        //    {
        //        addresses = ctx.Students.Include("StudentAddress").Select(x => new StudentAddresses()
        //        {
        //            Id = x.StudentId,
        //            FirstName = x.FirstName,
        //            LastName = x.LastName,
        //            Address = x.StudentAddress == null ? null : new AddressModel()
        //            {
        //                StudentId = x.StudentId,
        //                Address1 = x.StudentAddress.Address1,
        //                Address2 = x.StudentAddress.Address2,
        //                City = x.StudentAddress.City,
        //                State = x.StudentAddress.State
        //            }
        //        }).ToList<StudentAddresses>();
        //    }
        //    return new GetAddressesOfStudentsResponse
        //    {
        //        StudentAddresses = addresses
        //    };
        //}

        public GetAddressesOfStudentsResponse GetAddressesOfStudents()
        {
            List<StudentAddresses> addresses = null;
            using (var ctx = new SchoolDbEntities())
            {
                addresses = ctx.MapStudentAddresses();
            }
            return new GetAddressesOfStudentsResponse
            {
                StudentAddresses = addresses
            };
        }

    }
}
