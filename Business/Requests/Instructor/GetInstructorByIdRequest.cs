namespace Business.Requests.Instructor
{
    public class GetInstructorByIdRequest
    {
        public int Id { get; set; }

        public GetInstructorByIdRequest(int id)
        {
            Id = id;
        }
    }
}