using Api.EntityTypes;
using Api.EntityTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IService
    {
        GetAllStudentResponse GetAllStudents();

        GetAddressesOfStudentsResponse GetAddressesOfStudents();
    }
}
