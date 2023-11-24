using DevTrackR.ShippingOrders.Core.Entities;
using DevTrackR.ShippingOrders.Core.ValueObjects;

namespace DevTrackR.ShippingOrders.Application.InputModels;

public class AddShippingOrderInputModel
{
    public string Description { get; set; } = string.Empty;
    public decimal WeightInKg { get; set; }
    public DeliveryAddressInputModel DeliveryAddress { get; set; }
    public List<ShippingServiceInputModel> Services { get; set; }

    public ShippingOrder ToEntity()
        => new ShippingOrder(
            Description,
            WeightInKg,
            DeliveryAddress.ToValueObject()
        );
}

public class DeliveryAddressInputModel
{
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;

    public DeliveryAddress ToValueObject()
        => new DeliveryAddress(Street, Number, ZipCode, City, State, Country, ContactEmail);
}

public class ShippingServiceInputModel
{
    public string Title { get; set; } = string.Empty;
    public decimal PricePerKg { get; set; }
    public decimal FixedPrice { get; set; }

    public ShippingService ToEntity()
        => new ShippingService(Title, PricePerKg, FixedPrice);
}