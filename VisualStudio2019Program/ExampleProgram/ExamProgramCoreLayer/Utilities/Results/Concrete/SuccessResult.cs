using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string Message) : base(Message, true)
        {

        }
    }
}
