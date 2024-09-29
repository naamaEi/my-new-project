using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoursePhotography.Controllers
{
    public class CourseController : ControllerBase
    {
        private static new List<Course> courses = new List<Course> {
                new Course { Id = 1,Type = "newborn", Day= 3, MaxStudents = 10,TeachersId =new string[] {"327867458","37852418" }  },
                new Course { Id = 2,Type = "family", Day= 2, MaxStudents = 30,TeachersId = new string[]{"327867458", }  },

            };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Course Post([FromBody] Course value)
        {
            courses.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Course Put(int id, [FromBody] Course value)
        {
            var index = courses.FindIndex(e => e.Id == id);
            courses[index].Id =id;
            courses[index].Type = value.Type;
            courses[index].Day = value.Day;
            courses[index].MaxStudents = value.MaxStudents;
            courses[index].TeachersId = value.TeachersId;
            return courses[index];
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = courses.FindIndex(e => e.Id == id);
            courses.RemoveAt(index);
        }
    }
}
