namespace Business.Request.Category
{
    public class DeleteCategoryRequest
    {
        public int Id { get; set; }

        public DeleteCategoryRequest(int id)
        {
            Id = id;
        }
    }
}