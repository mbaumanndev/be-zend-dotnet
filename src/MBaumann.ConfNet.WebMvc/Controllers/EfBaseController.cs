using MBaumann.ConfNet.WebMvc.Data;
using Microsoft.Extensions.Logging;

namespace MBaumann.ConfNet.WebMvc.Controllers
{
    public abstract class EfBaseController : BaseController, IEfController
    {
        private readonly ApplicationDbContext m_dbContext;

        public ApplicationDbContext DbContext => m_dbContext;

        public EfBaseController(ILogger<EfBaseController> p_logger, ApplicationDbContext p_dbContext) : base(p_logger)
        {
            m_dbContext = p_dbContext;
        }
    }
}
