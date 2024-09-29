using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursePhotography.Controllers
{
    public class StudentController : ControllerBase
    {
        private static new List<Student> students = new List<Student> {
                new Student { Id = "23",Name = "Nchama", Phone="0525845511",Age=15 },
                new Student { Id = "45",Name = "Rachel", Phone= "0583265478" ,Age=16},

            };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Student Post([FromBody] Student value)
        {
            students.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Student Put(string id, [FromBody] Student value)
        {
            var index = students.FindIndex(e => e.Id == id);
            students[index].Name = value.Name;
            students[index].Phone = value.Phone;
            students[index].Id = id;
            return students[index];
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var index = students.FindIndex(e => e.Id == id);
            students.RemoveAt(index);
        }
    }
}
