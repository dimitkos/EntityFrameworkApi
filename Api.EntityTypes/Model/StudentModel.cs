using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.EntityTypes.Model
{
    public class StudentModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddressModel Address { get; set; }
        public StandardModel Standard { get; set; }
    }
}
