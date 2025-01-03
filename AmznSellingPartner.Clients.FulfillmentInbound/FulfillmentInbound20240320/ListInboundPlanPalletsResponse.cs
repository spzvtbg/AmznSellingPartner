namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listInboundPlanPallets` response
	/// </summary>
	public class ListInboundPlanPalletsResponse : BaseClass
	{
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }

		/// <summary>
		/// The pallets in an inbound plan
		/// </summary>
		[IsRequired]
		[JsonProperty("pallets")]
		public List<Pallet> Pallets { get; set; }
	}
}
