namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A product offer with segment information indicating where it's featured
	/// </summary>
	public class SegmentedFeaturedOffer : BaseClass
	{
		/// <summary>
		/// The list of segment information in which the offer is featured
		/// </summary>
		[IsRequired]
		[JsonProperty("featuredOfferSegments")]
		public List<FeaturedOfferSegment> FeaturedOfferSegments { get; set; }
	}
}
