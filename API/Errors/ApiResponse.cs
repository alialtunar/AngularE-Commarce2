using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int StatusCode, string Message=null)
        {
            this.StatusCode = StatusCode;
            this.Message = Message ?? GetDefaultMessageForStatusCode(StatusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            string ErrorMesage = string.Empty;

            switch (statusCode)
            {
                case 400:
                    ErrorMesage = "A Bad Request";
                    break;
                        case 401:
                    ErrorMesage = "Authorized Error";
                    break;
                case 404:
                    ErrorMesage = "Resource Not Found";
                    break;
                case 500:
                    ErrorMesage = "Server Error";
                    break;

            }
            return ErrorMesage;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
