using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceProject.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data{ get; set; }
    }
}
