namespace Business.Responses.Instructor
{
    public class DeleteInstructorResponse
    {
        public DeleteInstructorResponse()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}