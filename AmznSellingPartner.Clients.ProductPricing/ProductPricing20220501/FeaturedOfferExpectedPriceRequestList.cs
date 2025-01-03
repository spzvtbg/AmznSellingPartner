namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A batched list of FOEP requests
	/// </summary>
	[MinItems(1)]
	public class FeaturedOfferExpectedPriceRequestList : List<FeaturedOfferExpectedPriceRequest>
	{
	}
}
