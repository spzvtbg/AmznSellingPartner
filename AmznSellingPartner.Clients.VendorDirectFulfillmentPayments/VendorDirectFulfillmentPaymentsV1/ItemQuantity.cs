namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of item quantity
	/// </summary>
	public class ItemQuantity : BaseClass
	{
		/// <summary>
		/// Quantity of units available for a specific item
		/// </summary>
		[IsRequired]
		[JsonProperty("amount")]
		public int Amount { get; set; }

		/// <summary>
		/// Unit of measure for the available quantity
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public string UnitOfMeasure { get; set; }
	}
}
