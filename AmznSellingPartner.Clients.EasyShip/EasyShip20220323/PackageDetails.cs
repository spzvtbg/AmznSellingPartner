namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Package details. Includes `packageItems`, `packageTimeSlot`, and `packageIdentifier`.
	/// </summary>
	public class PackageDetails : BaseClass
	{
		[JsonProperty("packageItems")]
		public Items PackageItems { get; set; } 

		[JsonProperty("packageTimeSlot")]
		[IsRequired]
		public TimeSlot PackageTimeSlot { get; set; } 

		[JsonProperty("packageIdentifier")]
		public PackageIdentifier PackageIdentifier { get; set; } 
	}
}
