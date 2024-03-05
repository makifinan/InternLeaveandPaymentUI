using InternLeaveandPaymentUI.Domain.DTOs.InternLeave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Domain.ViewModels
{
    public class AddInternLeaveVM
    {
        public int InternId { get; set; }
        public string InternName { get; set; }
        public string InternSurname { get; set; }
        public int ResponsibleID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public InternLeaveAddDTO InternLeaveAddDTO { get; set; }
    }
}
