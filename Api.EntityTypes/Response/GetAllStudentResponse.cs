using Api.EntityTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.EntityTypes
{
    public class GetAllStudentResponse
    {
        public List<StudentModel> Students { get; set; }
    }
}
