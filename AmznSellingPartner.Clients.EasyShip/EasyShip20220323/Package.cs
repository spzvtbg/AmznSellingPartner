namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// This object contains all the details of the scheduled Easy Ship package.
	/// </summary>
	public class Package : BaseClass
	{
		[JsonProperty("scheduledPackageId")]
		[IsRequired]
		public ScheduledPackageId ScheduledPackageId { get; set; }

		[JsonProperty("packageDimensions")]
		[IsRequired]
		public Dimensions PackageDimensions { get; set; }

		[JsonProperty("packageWeight")]
		[IsRequired]
		public Weight PackageWeight { get; set; }

		[JsonProperty("packageItems")]
		public Items PackageItems { get; set; }

		[JsonProperty("packageTimeSlot")]
		[IsRequired]
		public TimeSlot PackageTimeSlot { get; set; }

		[JsonProperty("packageIdentifier")]
		public PackageIdentifier PackageIdentifier { get; set; }

		[JsonProperty("invoice")]
		public InvoiceData Invoice { get; set; }

		[JsonProperty("packageStatus")]
		public PackageStatus PackageStatus { get; set; }

		[JsonProperty("trackingDetails")]
		public TrackingDetails TrackingDetails { get; set; }
	}
}
