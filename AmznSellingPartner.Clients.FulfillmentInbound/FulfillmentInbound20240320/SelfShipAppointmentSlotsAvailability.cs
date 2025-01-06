namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The self ship appointment time slots availability and an expiration date for which the slots can be
	/// scheduled.
	/// </summary>
	public class SelfShipAppointmentSlotsAvailability : BaseClass
	{
		/// <summary>
		/// The time at which the self ship appointment slot expires. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format.
		/// </summary>
		[JsonProperty("expiresAt")]
		public DateTimeValue ExpiresAt { get; set; } 

		/// <summary>
		/// A list of appointment slots.
		/// </summary>
		[JsonProperty("slots")]
		public List<AppointmentSlot> Slots { get; set; } 
	}
}
