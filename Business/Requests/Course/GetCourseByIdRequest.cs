namespace Business.Requests.Course
{
    public class GetCourseByIdRequest
    {
        public GetCourseByIdRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}