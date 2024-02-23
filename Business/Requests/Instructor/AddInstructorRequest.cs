namespace Business.Requests.Instructor
{
    public class AddInstructorRequest
    {
        public AddInstructorRequest()
        {
            
        }
        public AddInstructorRequest(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}