using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.Utilities.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string _Message):base(_Message,true,data)
        {
            Data = data;
            Message = _Message;
        }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
