using WebApplication1.ShipmentTrackingService.Models;

namespace WebApplication1.ShipmentTrackingService
{
    public interface IShipmentProvider
    {
        ShipmentInfoModel Create(CreateShipmentModel createShipment);
        ShipmentQueryResponseModel Query(ShipmentInfoModel shipment);
    }
}
