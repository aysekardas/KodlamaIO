using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Requests.Course;
using Business.Responses.Course;

namespace Business.Abstract
{
    public interface ICourseService
    {
        public AddCourseResponse Add(AddCourseRequest request);

        public GetCourseListResponse GetList(GetCourseListRequest request);
        public GetCourseByIdResponse GetById(GetCourseByIdRequest request);

        public UpdateCourseResponse Update(UpdateCourseRequest request);
        public DeleteCourseResponse Delete(DeleteCourseRequest request);
    }
}
