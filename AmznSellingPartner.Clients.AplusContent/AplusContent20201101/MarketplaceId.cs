namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The identifier for the marketplace where the A+ Content is published.
    /// </summary>
    [MinLength(1)]
    public class MarketplaceId : StringValue
    {
    }
}
