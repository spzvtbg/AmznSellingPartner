namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains input information to update Small Parcel Delivery (SPD) tracking information
	/// </summary>
	public class SpdTrackingDetailInput : BaseClass
	{
		/// <summary>
		/// List of Small Parcel Delivery (SPD) tracking items input
		/// </summary>
		[IsRequired]
		[JsonProperty("spdTrackingItems")]
		public List<SpdTrackingItemInput> SpdTrackingItems { get; set; }
	}
}
