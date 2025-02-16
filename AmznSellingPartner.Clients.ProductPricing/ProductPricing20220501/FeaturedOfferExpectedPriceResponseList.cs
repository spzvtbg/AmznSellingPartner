namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// A batched list of FOEP responses.
    /// </summary>
    [MinItems(1)]
    public class FeaturedOfferExpectedPriceResponseList : List<FeaturedOfferExpectedPriceResponse>
    {
    }
}
