using BaiTap05.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap05.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "ngày 28";
            ViewBag.Thang = "tháng 100";
            ViewData["nam"] = "nam 2024";
            return View();
        }

        public IActionResult Index2()
        {
            var theloai = new TheLoaiViewModel
            {
                Id = 1,
                Name = "Trinh thám"
            };
            return View(theloai);
        }
    }
}
