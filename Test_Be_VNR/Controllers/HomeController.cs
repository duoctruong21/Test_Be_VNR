using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_Be_VNR.Models;

namespace Test_Be_VNR.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities1 db = new VNR_InternShipEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MonHoc(int id) {
            var monhoc = db.MonHocs.Find(id);
            var khoahoc = db.KhoaHocs.Find(id);
            ViewBag.KhocHoc = khoahoc.TenKhoaHoc;
            if (monhoc != null)
            {
                var monhocs = db.MonHocs.Where(x=>x.KhoaHocID == id);                
                return View(monhocs);
            }
            return View(monhoc);
        }

        public ActionResult KhoaHoc()
        {
            var khoahoc = db.KhoaHocs.ToList();
            
            return View(khoahoc);
        }
    }
}