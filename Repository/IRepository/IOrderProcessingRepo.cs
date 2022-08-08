using ReturnOrderMgmtSystemV1.Models.DTOs;
using System.Threading.Tasks;

namespace ReturnOrderMgmtSystemV1.Repository.IRepository
{
    public interface IOrderProcessingRepo
    {        
        Task<ProcessResponse> getProcessResponse(char ComponentType, float? Qty);  
        
        int CompleteProcessing(OrderDataDto orderData);
    }
}
