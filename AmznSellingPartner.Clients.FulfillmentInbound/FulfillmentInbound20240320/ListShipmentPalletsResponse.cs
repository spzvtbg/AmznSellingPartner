namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listShipmentPallets` response.
	/// </summary>
	public class ListShipmentPalletsResponse : BaseClass
	{
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; } 

		/// <summary>
		/// The pallets in a shipment.
		/// </summary>
		[JsonProperty("pallets")]
		[IsRequired]
		public List<Pallet> Pallets { get; set; } 
	}
}
