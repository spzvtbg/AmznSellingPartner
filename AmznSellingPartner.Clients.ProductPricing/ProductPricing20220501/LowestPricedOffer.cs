namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Describes the lowest priced offers for the specified item condition and offer type.
	/// </summary>
	public class LowestPricedOffer : BaseClass
	{
		/// <summary>
		/// The filtering criteria that are used to retrieve the lowest priced offers that correspond to the `lowestPricedOffersInputs`
		/// request.
		/// </summary>
		[JsonProperty("lowestPricedOffersInput")]
		[IsRequired]
		public LowestPricedOffersInput LowestPricedOffersInput { get; set; }

		/// <summary>
		/// A list of up to 20 lowest priced offers that match the criteria specified in `lowestPricedOffersInpu
		/// t`.
		/// </summary>
		[JsonProperty("offers")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(20)]
		public List<Offer> Offers { get; set; }
	}
}
