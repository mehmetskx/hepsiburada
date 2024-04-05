using System;
using WebApplication1.ShipmentTrackingService.CargoCompanies;
using WebApplication1.ShipmentTrackingService.Enums;

namespace WebApplication1.ShipmentTrackingService
{
    public class ShipmentFactory
    {
        public IShipmentProvider CreateCargoCompany(CargoCompany cargoCompany)
        {
            switch (cargoCompany)
            {
                case CargoCompany.Aras:
                    return new ArasCargo();
                case CargoCompany.Yurtici:
                    return new YurticiCargo();
                default:
                    throw new ArgumentException("Cargo company not found.");
            }
        }
    }
}
