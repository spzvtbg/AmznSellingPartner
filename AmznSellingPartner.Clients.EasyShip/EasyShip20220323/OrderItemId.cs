namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The Amazon-defined order item identifier.
    /// </summary>
    [MaxLength(255)]
    public class OrderItemId : StringValue
    {
    }
}
