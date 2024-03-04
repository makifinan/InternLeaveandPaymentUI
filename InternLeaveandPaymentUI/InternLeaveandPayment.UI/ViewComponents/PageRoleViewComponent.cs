using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternLeaveandPayment.UI.ViewComponents
{
    public class PageRoleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var login = HttpContext.Session.GetString("Department");
            return View("Default",login);
        }
    }
}
