namespace Business.Responses.Course
{
    public class AddCourseResponse
    {
        public AddCourseResponse()
        {
        }

        public string Name { get; set; }

        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}