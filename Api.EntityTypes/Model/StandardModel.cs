using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.EntityTypes.Model
{
    public class StandardModel
    {
        public int StandardId { get; set; }
        public string Name { get; set; }

        public ICollection<StudentModel> Students { get; set; }
    }
}
