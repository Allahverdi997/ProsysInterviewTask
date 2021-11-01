using ExamProgramCoreLayer.Utilities.Results.Abstract;
using ExamProgramCoreLayer.Utilities.Results.Concrete;
using ExamProgramDataAccessLayer.Abstract;
using ExamProgramEntities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentDal studentDal;
        public StudentController(IStudentDal _studentDal)
        {
            studentDal = _studentDal;
        }

        [HttpGet]
        public IResult Get()
        {
            try
            {
                List<Student> model = studentDal.GetAll();
                return new SuccessDataResult<List<Student>>(model, "Ugurlu Emeliyyat");
            }
            catch (Exception)
            {
                return new ErrorResult("Ugursuz Emeliyyat");
            }
        }

        [HttpPost]
        public IResult Post([FromBody]Student student)
        {
            try
            {
                studentDal.Add(student);
                return new SuccessResult("Ugurlu Emeliyyat");
            }
            catch (Exception)
            {
                return new ErrorResult("Ugursuz Emeliyyat");
            }
        }
    }
}
