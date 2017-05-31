using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Services.Core
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            this.Success = true;
        }
        public bool Success { get; set; }

        public string Message { get; set; }

        public int? ErrorCode { get; set; }

        public dynamic Data { get; set; }

        public void RegistrarError(Exception ex)
        {
            this.Success = false;
            this.Message = ex.Message;
            this.ErrorCode = ErrorHelper.ErrorInesperado;

        }
    }
}
