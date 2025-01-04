namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// An appointment slot time with start and end.
	/// </summary>
	public class AppointmentSlotTime : BaseClass
	{
		/// <summary>
		/// The end timestamp of the appointment in UTC.
		/// </summary>
		[JsonProperty("endTime")]
		[IsRequired]
		public DateTime EndTime { get; set; }

		/// <summary>
		/// The start timestamp of the appointment in UTC.
		/// </summary>
		[JsonProperty("startTime")]
		[IsRequired]
		public DateTime StartTime { get; set; }
	}
}
