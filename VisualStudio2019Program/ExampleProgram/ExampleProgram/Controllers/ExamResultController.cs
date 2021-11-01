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
    public class ExamResultController : ControllerBase
    {
        private IExemResultDal exemResultDal;
        public ExamResultController(IExemResultDal _exemResultDal)
        {
            exemResultDal = _exemResultDal;
        }

        [HttpGet]
        public IResult Get()
        {
            try
            {
                List<ExamResult> model = exemResultDal.GetAll();
                return new SuccessDataResult<List<ExamResult>>(model,"Ugurlu Emeliyyat");
            }
            catch (Exception)
            {
                return new ErrorResult("Ugursuz Emeliyyat");
            }

        }

        [HttpPost]
        public IResult Post([FromBody] ExamResult examResult)
        {
            try
            {
                exemResultDal.Add(examResult);
                return new SuccessResult("Ugurlu Emeliyyat");
            }
            catch (Exception)
            {
                return new ErrorResult("Ugursuz Emeliyyat");
            }
        }
    }
}
