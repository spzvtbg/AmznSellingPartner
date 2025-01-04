namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema for the `addAppointmentForServiceJobByServiceJobId` and `rescheduleAppointmentForServiceJobByServiceJobId`
	/// operations.
	/// </summary>
	public class SetAppointmentResponse : BaseClass
	{
		/// <summary>
		/// New appointment identifier generated during the `addAppointmentForServiceJobByServiceJobId` or `rescheduleAppointmentForServiceJobByServiceJobId`
		/// operations.
		/// </summary>
		[JsonProperty("appointmentId")]
		public AppointmentId AppointmentId { get; set; } 

		/// <summary>
		/// Warnings generated during the `addAppointmentForServiceJobByServiceJobId` or `rescheduleAppointmentForServiceJobByServiceJobId`
		/// operations.
		/// </summary>
		[JsonProperty("warnings")]
		public WarningList Warnings { get; set; } 

		/// <summary>
		/// Errors occurred during during the `addAppointmentForServiceJobByServiceJobId` or `rescheduleAppointmentForServiceJobByServiceJobId`
		/// operations.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
