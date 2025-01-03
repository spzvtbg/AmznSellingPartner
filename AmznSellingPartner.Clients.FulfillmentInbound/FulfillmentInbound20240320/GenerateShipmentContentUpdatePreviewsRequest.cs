namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `GenerateShipmentContentUpdatePreviews` request
	/// </summary>
	public class GenerateShipmentContentUpdatePreviewsRequest : BaseClass
	{
		/// <summary>
		/// A list of boxes that will be present in the shipment after the update
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(5000)]
		[JsonProperty("boxes")]
		public List<BoxUpdateInput> Boxes { get; set; }

		/// <summary>
		/// A list of all items that will be present in the shipment after the update
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(2000)]
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; }
	}
}
