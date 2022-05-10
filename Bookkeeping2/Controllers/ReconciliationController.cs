using Microsoft.AspNetCore.Mvc;
using Reconciliation.Domain.Model;
using Reconciliation.Domain.Service;

namespace Bookkeeping2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReconciliationController : ControllerBase
    {
        private readonly ILogger<ReconciliationController> _logger;
        private readonly IReconciliationService _reconciliationService;
        public ReconciliationController(ILogger<ReconciliationController> logger,
            IReconciliationService reconciliationService)
        {
            _logger = logger;
            _reconciliationService = reconciliationService;
        }
        [HttpGet("GetReconciliation")]
        public async Task<IEnumerable<ReconciliationDto>> GetAsync()
        {
            return await _reconciliationService.GetAllReconciliation();
        }
    }
}
