namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// Summarized inventory details. This object will not appear if the details parameter in the request is
	/// false.
	/// </summary>
	public class InventoryDetails : BaseClass
	{
		/// <summary>
		/// The item quantity that can be picked, packed, and shipped.
		/// </summary>
		[JsonProperty("fulfillableQuantity")]
		public int FulfillableQuantity { get; set; }

		/// <summary>
		/// The number of units in an inbound shipment for which you have notified Amazon.
		/// </summary>
		[JsonProperty("inboundWorkingQuantity")]
		public int InboundWorkingQuantity { get; set; }

		/// <summary>
		/// The number of units in an inbound shipment that you have notified Amazon about and have provided a tracking
		/// number.
		/// </summary>
		[JsonProperty("inboundShippedQuantity")]
		public int InboundShippedQuantity { get; set; }

		/// <summary>
		/// The number of units that have not yet been received at an Amazon fulfillment center for processing, but
		/// are part of an inbound shipment with some units that have already been received and processed.
		/// </summary>
		[JsonProperty("inboundReceivingQuantity")]
		public int InboundReceivingQuantity { get; set; }

		[JsonProperty("reservedQuantity")]
		public ReservedQuantity ReservedQuantity { get; set; }

		[JsonProperty("researchingQuantity")]
		public ResearchingQuantity ResearchingQuantity { get; set; }

		[JsonProperty("unfulfillableQuantity")]
		public UnfulfillableQuantity UnfulfillableQuantity { get; set; }
	}
}
