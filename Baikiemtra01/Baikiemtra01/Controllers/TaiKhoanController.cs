﻿
using Baikiemtra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baikiemtra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DangKy(TaiKhoanViewModel taikhoan)
        {
            if (taikhoan != null && taikhoan.Password != null && (taikhoan.Password).Length > 0)
            {
                taikhoan.Password = taikhoan.Password + "_chuoi_ma_hoa";
            }

            return View(taikhoan);
        }
    }
}
