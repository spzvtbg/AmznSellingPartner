namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Describes the segment in which the offer is featured.
	/// </summary>
	public class FeaturedOfferSegment : BaseClass
	{
		/// <summary>
		/// The customer membership type that makes up this segment
		/// </summary>
		[JsonProperty("customerMembership")]
		[IsRequired]
		public CustomerMembership CustomerMembership { get; set; } 

		/// <summary>
		/// The details about the segment.
		/// </summary>
		[JsonProperty("segmentDetails")]
		[IsRequired]
		public SegmentDetails SegmentDetails { get; set; } 
	}
}
