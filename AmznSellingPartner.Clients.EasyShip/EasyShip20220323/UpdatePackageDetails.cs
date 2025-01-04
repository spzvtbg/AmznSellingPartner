namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request to update the time slot of a package.
	/// </summary>
	public class UpdatePackageDetails : BaseClass
	{
		[JsonProperty("scheduledPackageId")]
		[IsRequired]
		public ScheduledPackageId ScheduledPackageId { get; set; } 

		[JsonProperty("packageTimeSlot")]
		[IsRequired]
		public TimeSlot PackageTimeSlot { get; set; } 
	}
}
