namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// Additional street address information.
    /// </summary>
    [MaxLength(60)]
    public class AddressLine3 : StringValue
    {
    }
}
