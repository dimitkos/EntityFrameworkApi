using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class StudentController :ApiController
    {
        private readonly IService service;

        public StudentController(IService service)
        {
            this.service = service;
        }

        public IHttpActionResult GetAllStudents()
        {
            var result = service.GetAllStudents();

            if (result.Count == 0 || result== null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
