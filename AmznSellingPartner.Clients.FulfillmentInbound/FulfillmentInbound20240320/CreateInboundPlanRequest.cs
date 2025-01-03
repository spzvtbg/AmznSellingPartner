namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `createInboundPlan` request.
	/// </summary>
	public class CreateInboundPlanRequest : BaseClass
	{
		/// <summary>
		/// Marketplaces where the items need to be shipped to. Currently only one marketplace can be selected in this req
		/// est.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(1)]
		[JsonProperty("destinationMarketplaces")]
		public List<string> DestinationMarketplaces { get; set; }

		/// <summary>
		/// Items included in this plan.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(2000)]
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; }

		/// <summary>
		/// Name for the Inbound Plan. If one isn't provided, a default name will be provided.
		/// </summary>
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("name")]
		public string Name { get; set; }

		[IsRequired]
		[JsonProperty("sourceAddress")]
		public AddressInput SourceAddress { get; set; }
	}
}
