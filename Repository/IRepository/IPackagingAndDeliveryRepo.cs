namespace ReturnOrderMgmtSystemV1.Repository.IRepository
{
    public interface IPackagingAndDeliveryRepo
    {
        double CalculatePackagingAndDeliveryCharges(char ComponentType, int? Qty);
    }
}
