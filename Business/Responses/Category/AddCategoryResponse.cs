namespace Business.Responses.Category
{
    public class AddCategoryResponse
    {
        public AddCategoryResponse()
        {
           
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}