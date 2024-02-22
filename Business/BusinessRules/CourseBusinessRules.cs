using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CourseBusinessRules
    {
        private readonly ICourseDal _courseDal;

        public CourseBusinessRules(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
    }
}
