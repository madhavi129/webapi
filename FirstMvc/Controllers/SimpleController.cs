using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvc.Controllers
{
    public class SimpleController : Controller
    {
        [HttpGet]
        public ActionResult AddNos()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddNos(int i, int j)
        {
            int ans = i + j;
            return Content(ans.ToString());
        }

    }
}