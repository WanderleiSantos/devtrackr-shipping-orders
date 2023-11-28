using DevTrackR.ShippingOrders.Application.ViewModels;
using DevTrackR.ShippingOrders.Core.Entities;

namespace DevTrackR.ShippingOrders.Application.Services;

public class ShippingServiceService: IShippingServiceService
{
    public Task<List<ShippingServiceViewModel>> GetAll()
    {
        var shippingServices = new List<ShippingService>
        {
            new ShippingService("Selo", 0, 1.6m)
        };
        return Task.FromResult(
            shippingServices
                .Select(s => new ShippingServiceViewModel(s.Id, s.Title, s.PricePerKg, s.FixedPrice))
                .ToList()
        );
    }
}