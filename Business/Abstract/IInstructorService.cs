using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Requests.Instructor;
using Business.Responses.Instructor;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        public AddInstructorResponse Add(AddInstructorRequest request);

        public GetInstructorListResponse GetList(GetInstructorListRequest request);
        public GetInstructorByIdResponse GetById(GetInstructorByIdRequest request);

        public UpdateInstructorResponse Update(UpdateInstructorRequest request);
        public DeleteInstructorResponse Delete(DeleteInstructorRequest request);
    }
}
