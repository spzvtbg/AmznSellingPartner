namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Objects that were included in the update request.
	/// </summary>
	public class RequestedUpdates : BaseClass
	{
		/// <summary>
		/// A list of boxes that will be present in the shipment after the update.
		/// </summary>
		[JsonProperty("boxes")]
		public List<BoxUpdateInput> Boxes { get; set; } 

		/// <summary>
		/// A list of all items that will be present in the shipment after the update.
		/// </summary>
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; } 
	}
}
