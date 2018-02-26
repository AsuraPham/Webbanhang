using banhang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace banhang.Controllers
{
    public class BanHangController : Controller
    {
        // GET: BanHang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult hienthi()
        {
            return View(BanHang.GetList());
        }
        public ActionResult TrangChu()
        {
            return View();
        }
    }
}