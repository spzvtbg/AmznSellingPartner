namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The quantity of reserved inventory.
	/// </summary>
	public class ReservedQuantity : BaseClass
	{
		/// <summary>
		/// The total number of units in Amazon's fulfillment network that are currently being picked,
		/// packed, and shipped; or are sidelined for measurement, sampling, or other internal process
		/// es.
		/// </summary>
		[JsonProperty("totalReservedQuantity")]
		public int TotalReservedQuantity { get; set; } 

		/// <summary>
		/// The number of units reserved for customer orders.
		/// </summary>
		[JsonProperty("pendingCustomerOrderQuantity")]
		public int PendingCustomerOrderQuantity { get; set; } 

		/// <summary>
		/// The number of units being transferred from one fulfillment center to another.
		/// </summary>
		[JsonProperty("pendingTransshipmentQuantity")]
		public int PendingTransshipmentQuantity { get; set; } 

		/// <summary>
		/// The number of units that have been sidelined at the fulfillment center for additional proc
		/// essing.
		/// </summary>
		[JsonProperty("fcProcessingQuantity")]
		public int FcProcessingQuantity { get; set; } 
	}
}
