using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.Utilities.Results.Concrete
{
    public class ErrorResult:Result
    {
        public ErrorResult(string Message):base(Message,false)
        {

        }
    }
}
