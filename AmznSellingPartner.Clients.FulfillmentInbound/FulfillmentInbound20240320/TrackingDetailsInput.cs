namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	/// <summary>
	/// Tracking information input for Less-Than-Truckload (LTL) and Small Parcel Delivery (SPD) shipments.
	/// </summary>
	public class TrackingDetailsInput : BaseClass
	{
		[JsonProperty("ltlTrackingDetail")]
		public LtlTrackingDetailInput LtlTrackingDetail { get; set; }

		[JsonProperty("spdTrackingDetail")]
		public SpdTrackingDetailInput SpdTrackingDetail { get; set; }
	}
}
