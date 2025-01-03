namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The fulfillment center appointment slot for the transportation option
	/// </summary>
	public class AppointmentSlot : BaseClass
	{
		/// <summary>
		/// An identifier to a self-ship appointment slot
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("slotId")]
		public string SlotId { get; set; }

		[IsRequired]
		[JsonProperty("slotTime")]
		public AppointmentSlotTime SlotTime { get; set; }
	}
}
