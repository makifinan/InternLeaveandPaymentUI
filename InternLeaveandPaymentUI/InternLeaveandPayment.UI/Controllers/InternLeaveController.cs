using InternLeaveandPaymentUI.Core.APIService;
using InternLeaveandPaymentUI.Domain.DTOs.InternLeave;
using InternLeaveandPaymentUI.Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternLeaveandPayment.UI.Controllers
{
    public class InternLeaveController : Controller
    {
        private readonly InternLeaveAPIService _internLeaveAPIService;
        private readonly DepartmentAPIService _departmentAPIService;
        private readonly EmployeeAPIService _employeeAPIService;
        public InternLeaveController(InternLeaveAPIService internLeaveAPIService, DepartmentAPIService departmentAPIService, EmployeeAPIService employeeAPIService)
        {
            _internLeaveAPIService = internLeaveAPIService;
            _departmentAPIService = departmentAPIService;
            _employeeAPIService = employeeAPIService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddInternLeave()
        {
            var deger = Convert.ToInt32(HttpContext.Session.GetString("DepartmentID"));
            var result = await _departmentAPIService.GetByIDDepartment(Convert.ToInt32(HttpContext.Session.GetString("DepartmentID")));
            var departmentName = result.Datas.DepartmentName;
            var employeeName = _employeeAPIService.GetByIDEmployee(Convert.ToInt32(HttpContext.Session.GetString("ManagerID"))).Result.Datas.EmployeeName;
            var employeeSurname = _employeeAPIService.GetByIDEmployee(Convert.ToInt32(HttpContext.Session.GetString("ManagerID"))).Result.Datas.EmployeeSurname;
            var internLeaveVM = new AddInternLeaveVM()
            {
                InternId = Convert.ToInt32(HttpContext.Session.GetString("ID")),
                DepartmentName = departmentName,
                DepartmentId = Convert.ToInt32(HttpContext.Session.GetString("DepartmentID")),
                ResponsibleID = Convert.ToInt32(HttpContext.Session.GetString("ManagerID")),
                EmployeeName = employeeName,
                EmployeeSurname = employeeSurname
            };
            return View(internLeaveVM);
        }
        [HttpPost]
        public IActionResult AddInternLeave(InternLeaveAddDTO internLeaveAddDTO)
        {
            return View();
        }
    }
}
