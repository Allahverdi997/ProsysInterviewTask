using ExamProgramCoreLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(string _Message,bool _Success):this(_Success)
        {
            Message = Message;
        }
        public Result(bool _Success)
        {
            Success = _Success;
        }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
