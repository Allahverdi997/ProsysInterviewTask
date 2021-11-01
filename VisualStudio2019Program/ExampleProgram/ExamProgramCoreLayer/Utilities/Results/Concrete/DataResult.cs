using ExamProgramCoreLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.Utilities.Results.Concrete
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public DataResult(string _Message,bool Success,T _Data):base(_Message,Success)
        {
            Data = _Data;
            Message = _Message;
        }

        public string Message { get; set; }
        public T Data { get ; set ; }
    }
}
