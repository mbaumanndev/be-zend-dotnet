using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MBaumann.ConfNet.WebMvc.Controllers
{
    public class BaseController : Controller, IController
    {
        private readonly ILogger m_logger;

        public ILogger Logger => m_logger;

        public BaseController(ILogger<BaseController> p_logger)
        {
            m_logger = p_logger;
        }

    }
}
