namespace Business.Responses.Category
{
    public class DeleteCategoryResponse
    {
        public DeleteCategoryResponse()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}