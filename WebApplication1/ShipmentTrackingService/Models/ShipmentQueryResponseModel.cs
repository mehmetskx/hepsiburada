using WebApplication1.ShipmentTrackingService.Enums;

namespace WebApplication1.ShipmentTrackingService.Models
{
    public class ShipmentQueryResponseModel
    {
        public ShipmentStatus ShipmentStatus { get; set; }
        public string TrackingNumber { get; set; }
    }
}
