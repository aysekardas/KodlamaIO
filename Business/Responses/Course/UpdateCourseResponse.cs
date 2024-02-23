namespace Business.Responses.Course
{
    public class UpdateCourseResponse
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}