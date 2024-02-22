using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Request.Category;
using Business.Requests.Category;
using Business.Responses.Category;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public AddCategoryResponse Add(AddCategoryRequest request);

        public GetCategoryListResponse GetList(GetCategoryListRequest request);
        public GetCategoryByIdResponse GetById(GetCategoryByIdRequest request);

        public UpdateCategoryResponse Update(UpdateCategoryRequest request);
        public DeleteCategoryResponse Delete(DeleteCategoryRequest request);
    }
}
