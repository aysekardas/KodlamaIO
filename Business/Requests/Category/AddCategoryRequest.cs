namespace Business.Request.Category
{
    public class AddCategoryRequest
    {
        public AddCategoryRequest(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}