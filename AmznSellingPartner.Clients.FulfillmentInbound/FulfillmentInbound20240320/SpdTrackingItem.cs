namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains information used to track and identify a Small Parcel Delivery (SPD) item.
	/// </summary>
	public class SpdTrackingItem : BaseClass
	{
		/// <summary>
		/// The ID provided by Amazon that identifies a given box. This ID is comprised of the external shipment
		/// ID (which is generated after transportation has been confirmed) and the index of the box.
		/// </summary>
		[JsonProperty("boxId")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string BoxId { get; set; } 

		/// <summary>
		/// The tracking ID associated with each box in a non-Amazon partnered Small Parcel Delivery (SPD) shipm
		/// ent.
		/// </summary>
		[JsonProperty("trackingId")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string TrackingId { get; set; } 

		/// <summary>
		/// Whether or not Amazon has validated the tracking number. If more than 24 hours have passed and the status
		/// is not yet 'VALIDATED', please verify the number and update if necessary. Possible values: `VALIDATED`,
		/// `NOT_VALIDATED`.
		/// </summary>
		[JsonProperty("trackingNumberValidationStatus")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string TrackingNumberValidationStatus { get; set; } 
	}
}
