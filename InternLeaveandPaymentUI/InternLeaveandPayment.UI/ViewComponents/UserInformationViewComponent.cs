using InternLeaveandPaymentUI.Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternLeaveandPayment.UI.ViewComponents
{
    public class UserInformationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var viewModel = new UserInformationVM() { UserName= HttpContext.Session.GetString("UserName"),UserSurname= HttpContext.Session.GetString("UserSurname"),Department= HttpContext.Session.GetString("Department") };
            return View(viewModel);
        }
    }
}
