using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// Nhớ using Models nếu cần, ví dụ: using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class SachOnlineController : Controller
    {
        // Trang chủ
        public ActionResult Index()
        {
            return View();
        }

        // 1. Menu trên
        public ActionResult NavPartial()
        {
            return PartialView();
        }

        // 2. Banner quảng cáo
        public ActionResult SliderPartial()
        {
            return PartialView();
        }

        // 3. Menu Chủ đề (Cột trái)
        public ActionResult ChuDePartial()
        {
            return PartialView();
        }

        // 4. Menu Nhà xuất bản (Cột trái)
        public ActionResult NhaXuatBanPartial()
        {
            return PartialView();
        }

        // 5. Chân trang
        public ActionResult FooterPartial()
        {
            return PartialView();
        }

        // 6. Sách bán nhiều (Dành cho trang chủ)
        public ActionResult SachBanNhieuPartial()
        {
            return PartialView();
        }
    }
}