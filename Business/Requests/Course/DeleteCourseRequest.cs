namespace Business.Requests.Course
{
    public class DeleteCourseRequest
    {
        public int Id { get; set; }

        public DeleteCourseRequest(int id)
        {
            Id = id;
        }
    }
}