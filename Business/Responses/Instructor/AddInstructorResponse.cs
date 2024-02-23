namespace Business.Responses.Instructor
{
    public class AddInstructorResponse
    {
        public AddInstructorResponse()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt
        {
            get; set;
        }
}