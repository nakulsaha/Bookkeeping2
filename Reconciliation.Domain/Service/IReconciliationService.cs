using Reconciliation.Domain.Model;

namespace Reconciliation.Domain.Service
{
    public interface IReconciliationService
    {
        Task<IEnumerable<ReconciliationDto>> GetAllReconciliation();
    }
}
