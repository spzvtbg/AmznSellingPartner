namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Availability information as per the service context queried.
	/// </summary>
	public class AppointmentSlotReport : BaseClass
	{
		/// <summary>
		/// Defines the type of slots.
		/// </summary>
		[JsonProperty("schedulingType")]
		public SchedulingType SchedulingType { get; set; } 

		/// <summary>
		/// Start Time from which the appointment slots are generated in ISO 8601 format.
		/// </summary>
		[JsonProperty("startTime")]
		public DateTimeValue StartTime { get; set; } 

		/// <summary>
		/// End Time up to which the appointment slots are generated in ISO 8601 format.
		/// </summary>
		[JsonProperty("endTime")]
		public DateTimeValue EndTime { get; set; } 

		/// <summary>
		/// A list of time windows along with associated capacity in which the service can be performe
		/// d.
		/// </summary>
		[JsonProperty("appointmentSlots")]
		public List<AppointmentSlot> AppointmentSlots { get; set; } 
	}
}
