namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The zip code or postal code.
    /// </summary>
    [MaxLength(30)]
    public class PostalCode : StringValue
    {
    }
}
