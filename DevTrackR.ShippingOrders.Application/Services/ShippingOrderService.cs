using DevTrackR.ShippingOrders.Application.InputModels;
using DevTrackR.ShippingOrders.Application.ViewModels;
using DevTrackR.ShippingOrders.Core.Entities;
using DevTrackR.ShippingOrders.Core.ValueObjects;

namespace DevTrackR.ShippingOrders.Application.Services;

public class ShippingOrderService : IShippingOrderService
{
    public Task<string> Add(AddShippingOrderInputModel model)
    {
        var shippingOrder = model.ToEntity();
        var shippingServices = model.Services.Select(s => s.ToEntity()).ToList();
        shippingOrder.SetupServices(shippingServices);

        return Task.FromResult(shippingOrder.TrackingCode);
    }

    public Task<ShippingOrderViewModel> GetByCode(string trackingCode)
    {
        var shippingOrder = new ShippingOrder("Pedido 1", 1.3m,
            new DeliveryAddress("Rua A", "2w", "12345-544", "Rio de Janeiro", "RJ", "Brasil", ""));

        return Task.FromResult(ShippingOrderViewModel.FromEntity(shippingOrder));
    }
}