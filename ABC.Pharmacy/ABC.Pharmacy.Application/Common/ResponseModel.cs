using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Common
{
    public class ResponseModel
    {

        public bool Status { get; set; }


        public string Message { get; set; }
            = string.Empty;


        public object? Data { get; set; }

    }
}
