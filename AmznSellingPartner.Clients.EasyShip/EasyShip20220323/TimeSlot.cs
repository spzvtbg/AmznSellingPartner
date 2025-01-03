namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A time window to hand over an Easy Ship package to Amazon Logistics
	/// </summary>
	public class TimeSlot : BaseClass
	{
		/// <summary>
		/// An Amazon-defined identifier for a time slot
		/// </summary>
		[IsRequired]
		[JsonProperty("slotId")]
		public String SlotId { get; set; }

		/// <summary>
		/// The start date and time of the time slot
		/// </summary>
		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// The end date and time of the time slot
		/// </summary>
		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; }

		/// <summary>
		/// The method by which a seller will hand a package over to Amazon Logistics
		/// </summary>
		[JsonProperty("handoverMethod")]
		public HandoverMethod HandoverMethod { get; set; }
	}
}
