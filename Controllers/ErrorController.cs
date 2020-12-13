using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PhoneWeb.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Error/{statusCode}")]

        public IActionResult HandleErrorCode(int statusCode)
        {
            var statusCodeData = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorCode = "404";
                    ViewBag.ErrorMessage = "Nhấp sai địa chỉ trang, vui lòng nhập lại !!!";
                    ViewBag.RouteOfException = statusCodeData.OriginalPath;
                    break;
                case 500:
                    ViewBag.ErrorMessage = "Xin lỗi đã xảy ra lỗi trên máy chủ";
                    ViewBag.RouteOfException = statusCodeData.OriginalPath;
                    break;
            }
            return View();
        }
    }
}
