using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int StatusCode, string Message = null, string Detail = null) : base(StatusCode, Message)
        {
            this.Detail = Detail;
        }

        public string Detail { get; set; }
    }
}
