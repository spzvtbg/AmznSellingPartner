namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The Amazon-defined identifier for an order placed by the buyer, in 3-7-7 format.
    /// </summary>
    [MinLength(5)]
    [MaxLength(20)]
    public class OrderId : StringValue
    {
    }
}
