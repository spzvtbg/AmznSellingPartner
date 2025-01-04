namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response of fetching appointment slots based on service context.
	/// </summary>
	public class GetAppointmentSlotsResponse : BaseClass
	{
		/// <summary>
		/// The appointment slots fetched based on service context.
		/// </summary>
		[JsonProperty("payload")]
		public AppointmentSlotReport Payload { get; set; } 

		/// <summary>
		/// Errors occurred in getting schedule.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
