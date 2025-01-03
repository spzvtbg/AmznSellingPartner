namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request to update the time slot of a package.
	/// </summary>
	public class UpdatePackageDetails : BaseClass
	{
		[IsRequired]
		[JsonProperty("scheduledPackageId")]
		public ScheduledPackageId ScheduledPackageId { get; set; }

		[IsRequired]
		[JsonProperty("packageTimeSlot")]
		public TimeSlot PackageTimeSlot { get; set; }
	}
}
