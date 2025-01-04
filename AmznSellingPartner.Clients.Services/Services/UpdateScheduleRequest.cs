namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request schema for the `updateSchedule` operation.
	/// </summary>
	public class UpdateScheduleRequest : BaseClass
	{
		/// <summary>
		/// List of schedule objects to define the normal working hours of a resource.
		/// </summary>
		[JsonProperty("schedules")]
		[IsRequired]
		public AvailabilityRecords Schedules { get; set; } 
	}
}
