namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Quantity of inventory with an associated measurement unit context.
	/// </summary>
	public class InventoryQuantity : BaseClass
	{
		/// <summary>
		/// Quantity of the respective inventory.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		public double Quantity { get; set; }

		/// <summary>
		/// Unit of measurement for the inventory.
		/// </summary>
		[JsonProperty("unitOfMeasurement")]
		[IsRequired]
		public InventoryUnitOfMeasurement UnitOfMeasurement { get; set; }
	}
}
