namespace Business.Requests.Course
{
    public class AddCourseRequest
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}