namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The phone number.
    /// </summary>
    [MaxLength(30)]
    public class PhoneNumber : StringValue
    {
    }
}
