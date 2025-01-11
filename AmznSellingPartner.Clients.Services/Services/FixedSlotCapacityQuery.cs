namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Request schema for the `getFixedSlotCapacity` operation. This schema is used to define the
	/// time range, capacity types and slot duration which are being queried.
	/// </summary>
	public class FixedSlotCapacityQuery : BaseClass
	{
		/// <summary>
		/// An array of capacity types which are being requested. Default value is `[SCHEDULED_CAPACIT
		/// Y]`.
		/// </summary>
		[JsonProperty("capacityTypes")]
		public List<CapacityType> CapacityTypes { get; set; } 

		/// <summary>
		/// Size in which slots are being requested. This value should be a multiple of 5 and fall in the
		/// range: 5 <= `slotDuration` <= 360.
		/// </summary>
		[JsonProperty("slotDuration")]
		public int SlotDuration { get; set; } 

		/// <summary>
		/// Start date time from which the capacity slots are being requested in ISO 8601 format.
		/// </summary>
		[JsonProperty("startDateTime")]
		[IsRequired]
		public DateTimeValue StartDateTime { get; set; } 

		/// <summary>
		/// End date time up to which the capacity slots are being requested in ISO 8601 format.
		/// </summary>
		[JsonProperty("endDateTime")]
		[IsRequired]
		public DateTimeValue EndDateTime { get; set; } 
	}
}
