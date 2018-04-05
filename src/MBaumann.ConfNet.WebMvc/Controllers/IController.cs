using Microsoft.Extensions.Logging;

namespace MBaumann.ConfNet.WebMvc.Controllers
{
    internal interface IController
    {
        ILogger Logger { get; }
    }
}