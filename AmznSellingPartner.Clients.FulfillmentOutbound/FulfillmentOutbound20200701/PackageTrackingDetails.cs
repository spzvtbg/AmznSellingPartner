namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Tracking details of package
	/// </summary>
	public class PackageTrackingDetails : BaseClass
	{
		/// <summary>
		/// The package identifier
		/// </summary>
		[IsRequired]
		[JsonProperty("packageNumber")]
		public int PackageNumber { get; set; }

		/// <summary>
		/// The tracking number for the package
		/// </summary>
		[JsonProperty("trackingNumber")]
		public string TrackingNumber { get; set; }

		/// <summary>
		/// Link on swiship
		/// com that allows customers to track the package
		/// </summary>
		[JsonProperty("customerTrackingLink")]
		public string CustomerTrackingLink { get; set; }

		/// <summary>
		/// The name of the carrier
		/// </summary>
		[JsonProperty("carrierCode")]
		public string CarrierCode { get; set; }

		/// <summary>
		/// The phone number of the carrier
		/// </summary>
		[JsonProperty("carrierPhoneNumber")]
		public string CarrierPhoneNumber { get; set; }

		/// <summary>
		/// The URL of the carrier's website
		/// </summary>
		[JsonProperty("carrierURL")]
		public string CarrierURL { get; set; }

		/// <summary>
		/// The shipping date for the package
		/// </summary>
		[JsonProperty("shipDate")]
		public Timestamp ShipDate { get; set; }

		/// <summary>
		/// The estimated arrival date
		/// </summary>
		[JsonProperty("estimatedArrivalDate")]
		public Timestamp EstimatedArrivalDate { get; set; }

		/// <summary>
		/// The destination city for the package
		/// </summary>
		[JsonProperty("shipToAddress")]
		public TrackingAddress ShipToAddress { get; set; }

		[JsonProperty("currentStatus")]
		public CurrentStatus CurrentStatus { get; set; }

		/// <summary>
		/// Description corresponding to the `CurrentStatus` value
		/// </summary>
		[JsonProperty("currentStatusDescription")]
		public string CurrentStatusDescription { get; set; }

		/// <summary>
		/// The name of the person who signed for the package
		/// </summary>
		[JsonProperty("signedForBy")]
		public string SignedForBy { get; set; }

		[JsonProperty("additionalLocationInfo")]
		public AdditionalLocationInfo AdditionalLocationInfo { get; set; }

		[JsonProperty("trackingEvents")]
		public TrackingEventList TrackingEvents { get; set; }
	}
}
