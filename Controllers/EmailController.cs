using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneWeb.Models;
using System.Net.Mail;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]

    public class EmailController : Controller
    {
        //[HttpPost]
        //public ActionResult<IEnumerable<bool>> SendEmail(Email email  )
        //{
        //    try
        //    {
        //        var message = new MimeMessage();
        //        message.From.Add(new MailboxAddress("Trên",
        //       "kevin.tran3577@gmail.com"));
        //        message.To.Add(new MailboxAddress("Nhân",
        //       "nhan7789@gmail.com"));
        //        message.Subject = "My First Email";
        //        message.Body = new TextPart("plain")
        //        {
        //            Text = "Nhân đẹp trai cute mai pho phe mèo méo meo mèo meo"
        //        };
        //        using (var client = new MailKit.Net.Smtp.SmtpClient())
        //        {
        //            client.Connect("smtp.gmail.com", 587, false);
        //            //SMTP server authentication if needed
        //            client.Authenticate("kevin.tran3577@gmail.com", "tren0836167265@");
        //            client.Send(message);
        //            client.Disconnect(true);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return StatusCode(500, "Error occured");
        //    }
        //    return Ok(true);
        //}

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Email email)
        {
            string to = email.To;
            string body = email.Body;
            string subject = email.Subject;
            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.From = new MailAddress("khoimessi99@gmail.com");
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = true,
                EnableSsl = true,
                Credentials = new System.Net.NetworkCredential("khoitedu99@gmail.com", "Fizz1999")
            };
            smtp.Send(mm);
            ViewBag.message = "Bạn đã xác nhận đơn hàng cho  " + email.To + " thành công ";
            return View();

        }
    }
} 

    

