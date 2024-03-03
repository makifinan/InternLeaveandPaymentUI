using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Core.ReturnType
{
    public class GeneralReturnType<T>
    {
        public T Datas { get; set; }
        public string Message { get; set; }
        public int StatuCode { get; set; }
    }
}
