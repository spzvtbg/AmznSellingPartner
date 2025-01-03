namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The aggregate weight of this item being invoiced. This information will be available for items sold by weight.
	/// </summary>
	public class TotalWeight : BaseClass
	{
		/// <summary>
		/// The unit of measure for items sold by weight.
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }

		[IsRequired]
		[JsonProperty("amount")]
		public Decimal Amount { get; set; }
	}
}
