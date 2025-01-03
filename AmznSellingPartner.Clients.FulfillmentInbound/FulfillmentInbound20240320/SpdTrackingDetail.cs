namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains information related to Small Parcel Delivery (SPD) shipment tracking
	/// </summary>
	public class SpdTrackingDetail : BaseClass
	{
		/// <summary>
		/// List of Small Parcel Delivery (SPD) tracking items
		/// </summary>
		[JsonProperty("spdTrackingItems")]
		public List<SpdTrackingItem> SpdTrackingItems { get; set; }
	}
}
