using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices
{
    public class StrykerServiceResponse
    {
        public object Data { get; set; }
        public object Error { get; set; }
        public string Message { get; set; }

        public static StrykerServiceResponse Success(object results)
        {
            return new StrykerServiceResponse 
            { 
                Data = results,
                Error = null,
                Message = null
            };
        }

        public static StrykerServiceResponse Failure(object error)
        {
            return new StrykerServiceResponse
            {
                Data = null,
                Error = error,
                Message = null
            };
        }
    }
}
