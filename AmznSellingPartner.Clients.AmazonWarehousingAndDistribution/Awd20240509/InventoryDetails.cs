namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	/// <summary>
	/// Additional inventory details
	/// This object is only displayed if the details parameter in the request is set to `SHOW`
	/// </summary>
	public class InventoryDetails : BaseClass
	{
		/// <summary>
		/// Quantity that is available for downstream channel replenishment
		/// </summary>
		[JsonProperty("availableDistributableQuantity")]
		public long AvailableDistributableQuantity { get; set; }

		/// <summary>
		/// Quantity that is reserved for a downstream channel replenishment order that is being prepared for shipment
		/// </summary>
		[JsonProperty("reservedDistributableQuantity")]
		public long ReservedDistributableQuantity { get; set; }
	}
}
