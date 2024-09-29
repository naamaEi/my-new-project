using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursePhotography.Controllers
{
    public class RegisterToCourseController : ControllerBase
    {
        private static new List<RegisterToCourse> registerToCourse = new List<RegisterToCourse> {
                new RegisterToCourse { Id = 1, CourseId = 2, TeacherId = "11", StudentId = "23"},
                new RegisterToCourse { Id = 2, CourseId = 1, TeacherId = "12", StudentId = "45"},

            };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<RegisterToCourse> Get()
        {
            return registerToCourse;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public RegisterToCourse Post([FromBody] RegisterToCourse value)
        {
            registerToCourse.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public RegisterToCourse Put(int id, [FromBody] RegisterToCourse value)
        {
            var index = registerToCourse.FindIndex(e => e.Id == id);
            registerToCourse[index].Id = id;
            registerToCourse[index].CourseId = value.CourseId;
            registerToCourse[index].TeacherId = value.TeacherId;
            registerToCourse[index].StudentId = value.StudentId;
            return registerToCourse[index];
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = registerToCourse.FindIndex(e => e.Id == id);
            registerToCourse.RemoveAt(index);
        }
    }
}
