namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The details of an appointment.
	/// </summary>
	public class Appointment : BaseClass
	{
		/// <summary>
		/// The appointment identifier.
		/// </summary>
		[JsonProperty("appointmentId")]
		public AppointmentId AppointmentId { get; set; }

		/// <summary>
		/// The status of the appointment.
		/// </summary>
		[JsonProperty("appointmentStatus")]
		public AppointmentStatus AppointmentStatus { get; set; }

		/// <summary>
		/// The time of the appointment window.
		/// </summary>
		[JsonProperty("appointmentTime")]
		public AppointmentTime AppointmentTime { get; set; }

		/// <summary>
		/// A list of technicians assigned to the service job.
		/// </summary>
		[JsonProperty("assignedTechnicians")]
		[MinItems(1)]
		public List<Technician> AssignedTechnicians { get; set; }

		/// <summary>
		/// The identifier of a rescheduled appointment.
		/// </summary>
		[JsonProperty("rescheduledAppointmentId")]
		public AppointmentId RescheduledAppointmentId { get; set; }

		/// <summary>
		/// Proof of Appointment (POA) details.
		/// </summary>
		[JsonProperty("poa")]
		public Poa Poa { get; set; }
	}
}
