using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambda2.ResponseModel
{
    public class ResponseSaludo
    {
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
    }
}
