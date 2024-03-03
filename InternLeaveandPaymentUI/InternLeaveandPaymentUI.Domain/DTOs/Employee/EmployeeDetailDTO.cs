﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Domain.DTOs.Employee
{
    public class EmployeeDetailDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Email { get; set; }


        public int? EmployeeDepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public bool? IsActive { get; set; }
    }
}