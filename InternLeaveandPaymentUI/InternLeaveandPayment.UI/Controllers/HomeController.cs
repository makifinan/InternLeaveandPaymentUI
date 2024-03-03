using InternLeaveandPayment.UI.Models;
using InternLeaveandPaymentUI.Core.APIService;
using InternLeaveandPaymentUI.Domain.DTOs.Employee;
using InternLeaveandPaymentUI.Domain.DTOs.Intern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InternLeaveandPayment.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InternAPIService _internAPIService;
        private readonly EmployeeAPIService _employeeAPIService;
        public HomeController(ILogger<HomeController> logger, InternAPIService internAPIService, EmployeeAPIService employeeAPIService)
        {
            _logger = logger;
            _internAPIService = internAPIService;
            _employeeAPIService = employeeAPIService;
        }

        public IActionResult FirstScreen()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InternLogin()
        {
            return View(new InternLoginDTO());
        }

        [HttpPost]
        public async Task<IActionResult> InternLogin(InternLoginDTO internLoginDTO)
        {
            var result = await _internAPIService.InternLogin(internLoginDTO);
            if (result == null)
            {
                return new EmptyResult();
            }
            HttpContext.Session.SetString("ID", result.Datas.InternId.ToString());
            HttpContext.Session.SetString("UserName", result.Datas.InternName.ToString());
            HttpContext.Session.SetString("UserSurname", result.Datas.InternSurname.ToString());
            HttpContext.Session.SetString("Department", "Stajyer");
            
            
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EmployeeLogin()
        {
            return View( new EmployeeLoginDTO());
        }

        [HttpPost]
        public async Task<IActionResult> EmployeeLogin(EmployeeLoginDTO employeeLoginDTO)
        {
            var result = await _employeeAPIService.EmployeeLogin(employeeLoginDTO);
            if (result==null)
            {
                return new EmptyResult();
            }
            HttpContext.Session.SetString("ID", result.Datas.EmployeeId.ToString());
            HttpContext.Session.SetString("UserName", result.Datas.EmployeeName.ToString());
            HttpContext.Session.SetString("UserSurname", result.Datas.EmployeeSurname.ToString());
            HttpContext.Session.SetString("Department", result.Datas.DepartmentName);
            return RedirectToAction("Index", "Home");
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
