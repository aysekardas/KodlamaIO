namespace Business.Requests.Instructor
{
    public class DeleteInstructorRequest
    {
        public int Id { get; set; }

        public DeleteInstructorRequest(int id)
        {
            Id = id;
        }
    }
}