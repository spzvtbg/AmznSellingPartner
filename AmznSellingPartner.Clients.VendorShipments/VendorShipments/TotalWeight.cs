namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The total weight of units that are sold by weight in a shipment.
	/// </summary>
	public class TotalWeight : BaseClass
	{
		/// <summary>
		/// The unit of measure for the weight of items that are ordered by cases and support pricing by weight.
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }

		[IsRequired]
		[JsonProperty("amount")]
		public Decimal Amount { get; set; }
	}
}
