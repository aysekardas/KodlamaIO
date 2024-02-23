namespace Business.Responses.Course
{
    public class DeleteCourseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}