using Business.Abstract;
using Business.Requests.Instructor;
using Business.Responses.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        public AddInstructorResponse Add(AddInstructorRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteInstructorResponse Delete(DeleteInstructorRequest request)
        {
            throw new NotImplementedException();
        }

        public GetInstructorByIdResponse GetById(GetInstructorByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetInstructorListResponse GetList(GetInstructorListRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateInstructorResponse Update(UpdateInstructorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
