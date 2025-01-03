namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Request schema for the `getFixedSlotCapacity` operation. This schema is used to define the time range, capacit
	/// types and slot duration which are being queried.
	/// </summary>
	public class FixedSlotCapacityQuery : BaseClass
	{
		/// <summary>
		/// An array of capacity types which are being requested. Default value is `[SCHEDULED_CAPACITY]`.
		/// </summary>
		[JsonProperty("capacityTypes")]
		public List<CapacityType> CapacityTypes { get; set; }

		/// <summary>
		/// Size in which slots are being requested. This value should be a multiple of 5 and fall in the range: 5 <= `slo
		/// Duration` <= 360.
		/// </summary>
		[JsonProperty("slotDuration")]
		public int SlotDuration { get; set; }

		/// <summary>
		/// Start date time from which the capacity slots are being requested in ISO 8601 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("startDateTime")]
		public DateTime StartDateTime { get; set; }

		/// <summary>
		/// End date time up to which the capacity slots are being requested in ISO 8601 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("endDateTime")]
		public DateTime EndDateTime { get; set; }
	}
}
