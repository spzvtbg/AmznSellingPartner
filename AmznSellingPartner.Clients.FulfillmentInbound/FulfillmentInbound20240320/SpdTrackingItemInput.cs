namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Small Parcel Delivery (SPD) tracking items input information.
	/// </summary>
	public class SpdTrackingItemInput : BaseClass
	{
		/// <summary>
		/// The ID provided by Amazon that identifies a given box. This ID is comprised of the external
		/// shipment ID (which is generated after transportation has been confirmed) and the index of the
		/// box.
		/// </summary>
		[JsonProperty("boxId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string BoxId { get; set; } 

		/// <summary>
		/// The tracking Id associated with each box in a non-Amazon partnered Small Parcel Delivery (SPD)
		/// shipment. The seller must provide this information.
		/// </summary>
		[JsonProperty("trackingId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string TrackingId { get; set; } 
	}
}
