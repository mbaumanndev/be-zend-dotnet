using System.Collections.Generic;
using System.Diagnostics;
using MBaumann.ConfNet.WebMvc.Models;
using MBaumann.ConfNet.WebMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MBaumann.ConfNet.WebMvc.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> p_logger) : base(p_logger)
        {
        }

        public IActionResult Index()
        {
            List<CarouselItem> v_model = new List<CarouselItem> {
                new CarouselItem {
                    Caption = "Learn how to build ASP.NET apps that can run anywhere.",
                    CaptionLink = "https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409",
                    CaptionLinkLabel = "Learn More",
                    Image = "/images/banner1.svg",
                    ImageAltText = "ASP.NET"
                },
                new CarouselItem {
                    Caption = "There are powerful new features in Visual Studio for building modern web apps.",
                    CaptionLink = "https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409",
                    CaptionLinkLabel = "Learn More",
                    Image = "/images/banner2.svg",
                    ImageAltText = "Visual Studio"
                },
                new CarouselItem {
                    Caption = "Bring in libraries from NuGet and npm, and automate tasks using Grunt or Gulp.",
                    CaptionLink = "https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409",
                    CaptionLinkLabel = "Learn More",
                    Image = "/images/banner3.svg",
                    ImageAltText = "Package Management"
                },
                new CarouselItem {
                    Caption = "Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.",
                    CaptionLink = "https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409",
                    CaptionLinkLabel = "Learn More",
                    Image = "/images/banner4.svg",
                    ImageAltText = "Microsoft Azure"
                }
            };

            return View(v_model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
