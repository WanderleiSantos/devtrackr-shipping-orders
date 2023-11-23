namespace DevTrackR.ShippingOrders.Core.Entities;

public class EntityBase
{
    public EntityBase()
    {
        Id = Guid.NewGuid();
    }
        
    public Guid Id { get; private set; }
}