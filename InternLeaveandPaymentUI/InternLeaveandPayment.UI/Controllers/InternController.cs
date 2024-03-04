using InternLeaveandPaymentUI.Core.APIService;
using InternLeaveandPaymentUI.Domain.DTOs.Intern;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InternLeaveandPayment.UI.Controllers
{
    public class InternController : Controller
    {
        private readonly InternAPIService _internAPIService;

        public InternController(InternAPIService internAPIService)
        {
            _internAPIService = internAPIService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> InternList()
        {
            var result = await _internAPIService.GetAllIntern();
            if (result==null)
            {
                return new EmptyResult();
            }
            return View(result.Datas);
        }


        [HttpGet]
        public IActionResult AddIntern()
        {
            return View(new InternAddDTO());
        }


        [HttpPost]
        public async Task<IActionResult> AddIntern(InternAddDTO internAddDTO)
        {
            var result = await _internAPIService.AddIntern(internAddDTO);
            if (result==null)
            {
                return new EmptyResult();
            }
            return RedirectToAction("Intern","InternList");
        }
    }
}
