namespace CoursePhotography
{
    public class Course
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Day { get; set; }
        public int MaxStudents { get; set; }
        public string[] TeachersId { get; set; }

    }
}
