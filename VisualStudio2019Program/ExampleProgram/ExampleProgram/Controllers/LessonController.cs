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
    public class LessonController : ControllerBase
    {
        private ILessonDal lessonDal;
        public LessonController(ILessonDal _lessonDal)
        {
            lessonDal = _lessonDal;
        }

        [HttpGet]
        public IResult Get()
        {
            try
            {
                List<Lesson> model = lessonDal.GetAll();
                return new SuccessDataResult<List<Lesson>>(model, "Ugurlu Emeliyyat");
            }
            catch (Exception)
            {
                return new ErrorResult("Ugursuz Emeliyyat");
            }
        }

        [HttpPost]
        public IResult Post([FromBody] Lesson lesson)
        {
            try
            {
                lessonDal.Add(lesson);
                return new SuccessResult("Ugurlu Emeliyyat");
            }
            catch (Exception)
            {
                return new ErrorResult("Ugursuz Emeliyyat");
            }
        }
    }
}
