namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The tax classification for the entity.
	/// </summary>
	public class TaxClassification : BaseClass
	{
		/// <summary>
		/// The type of tax.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; set; }

		/// <summary>
		/// The entity's tax identifier.
		/// </summary>
		[JsonProperty("Value")]
		public string Value { get; set; }
	}
}
