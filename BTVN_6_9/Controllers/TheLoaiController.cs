﻿using Microsoft.AspNetCore.Mvc;

namespace BTVN_Baitap2_6_9.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MaSV = "1822041623";
            ViewBag.HoTen = "Nguyễn Thành Bửu";
            ViewData["Nam"] = "07-08-2004";
            return View();
        }
        public ActionResult MayTinh(double a, double b, string pheptinh)
        {
            double ketqua = 0;
            switch (pheptinh)
            {
                case "cong":
                    ketqua = a + b;
                    break;
                case "tru":
                    ketqua = a - b;
                    break;
                case "nhan":
                    ketqua = a * b;
                    break;
                case "chia":
                    if (a==0 || b==0)
                    {

                        return Content("ko dc chia vs 0 ");
                        break;  
                    }
                    else
                    {
                        ketqua = a / b;
                    }
                    break;
                default:
                    ViewBag.ketqua = "Phép tính không hợp lệ";
                    break;
            }
                
            ViewBag.KetQua = "Kết quả : "+ketqua;
            return View();
           
        }
        public ActionResult Profile()
        {
            return View();
        }
    }

}
