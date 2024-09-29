//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;

//namespace CoursePhotography.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]

//    public class TeacherController : Controller
//    {
//        private static new List<Teacher> teachers = new List<Teacher> {
//                new Teacher { TeacherId = "11",Name = "Nchama", Phone="0525845511" },
//                new Teacher { TeacherId = "12",Name = "Rachel", Phone= "0583265478" },

//            };

//        // GET: api/<ValuesController>
//        [HttpGet]
//        public IEnumerable<Teacher> Get()
//        {
//            return teachers;
//        }

//        // GET api/<ValuesController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<ValuesController>
//        [HttpPost]
//        public Teacher Post([FromBody] Teacher value)
//        {
//            teachers.Add(value);
//            return value;
//        }

//        // PUT api/<ValuesController>/5
//        [HttpPut("{id}")]
//        public Teacher Put(string id, [FromBody] Teacher value)
//        {
//            var index = teachers.FindIndex(e => e.TeacherId == id);
//            teachers[index].Name = value.Name;
//            teachers[index].Phone = value.Phone;
//            teachers[index].TeacherId = id;
//            return teachers[index];
//        }

//        // DELETE api/<ValuesController>/5
//        [HttpDelete("{id}")]
//        public void Delete(string id)
//        {
//            var index = teachers.FindIndex(e => e.TeacherId == id);
//            teachers.RemoveAt(index);
//        }
//    }
//}



using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoursePhotography.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private static List<Teacher> teachers = new List<Teacher> {
            new Teacher { TeacherId = "11", Name = "Nchama", Phone = "0525845511" },
            new Teacher { TeacherId = "12", Name = "Rachel", Phone = "0583265478" }
        };

        // GET: api/Teacher
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return teachers;
        }

        // GET api/Teacher/5
        [HttpGet("{id}")]
        public Teacher Get(string id)
        {
            return teachers.FirstOrDefault(t => t.TeacherId == id);
        }

        // POST api/Teacher
        [HttpPost]
        public Teacher Post([FromBody] Teacher value)
        {
            teachers.Add(value);
            return value;
        }

        // PUT api/Teacher/5
        [HttpPut("{id}")]
        public Teacher Put(string id, [FromBody] Teacher value)
        {
            var teacher = teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher != null)
            {
                teacher.Name = value.Name;
                teacher.Phone = value.Phone;
            }
            return teacher;
        }

        // DELETE api/Teacher/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var teacher = teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher != null)
            {
                teachers.Remove(teacher);
            }
        }
    }
}