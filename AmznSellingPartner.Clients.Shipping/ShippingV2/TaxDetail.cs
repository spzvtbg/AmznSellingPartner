namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Indicates the tax specifications associated with the shipment for customs compliance purposes in certain
	/// regions.
	/// </summary>
	public class TaxDetail : BaseClass
	{
		[IsRequired]
		[JsonProperty("taxType")]
		public TaxType TaxType { get; set; }

		/// <summary>
		/// The shipper's tax registration number associated with the shipment for customs compliance purposes in
		/// certain regions.
		/// </summary>
		[IsRequired]
		[JsonProperty("taxRegistrationNumber")]
		public string TaxRegistrationNumber { get; set; }
	}
}
