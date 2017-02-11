using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WizcationLocal.Areas.Hotel.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel/Hotel
        public ActionResult Index()
        {
            return View();
        }
    }
}