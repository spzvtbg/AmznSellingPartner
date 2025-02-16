namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The street address information.
    /// </summary>
    [MaxLength(180)]
    public class AddressLine1 : StringValue
    {
    }
}
