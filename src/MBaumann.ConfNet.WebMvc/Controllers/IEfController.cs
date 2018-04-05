using MBaumann.ConfNet.WebMvc.Data;

namespace MBaumann.ConfNet.WebMvc.Controllers
{
    public interface IEfController
    {
        ApplicationDbContext DbContext { get; }
    }
}
