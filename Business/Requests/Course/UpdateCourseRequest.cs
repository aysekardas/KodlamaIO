namespace Business.Requests.Course
{
    public class UpdateCourseRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}