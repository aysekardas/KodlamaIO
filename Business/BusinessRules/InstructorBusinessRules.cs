using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class InstructorBusinessRules
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorBusinessRules(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
    }
}
