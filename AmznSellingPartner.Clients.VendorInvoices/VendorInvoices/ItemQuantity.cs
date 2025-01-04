namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of quantity.
	/// </summary>
	public class ItemQuantity : BaseClass
	{
		/// <summary>
		/// Quantity of an item. This value should not be zero.
		/// </summary>
		[JsonProperty("amount")]
		[IsRequired]
		public int Amount { get; set; } 

		/// <summary>
		/// Unit of measure for the quantity.
		/// </summary>
		[JsonProperty("unitOfMeasure")]
		[IsRequired]
		public UnitOfMeasure UnitOfMeasure { get; set; } 

		/// <summary>
		/// The case size, if the unit of measure value is Cases.
		/// </summary>
		[JsonProperty("unitSize")]
		public int UnitSize { get; set; } 

		[JsonProperty("totalWeight")]
		public TotalWeight TotalWeight { get; set; } 
	}
}
