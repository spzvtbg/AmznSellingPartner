namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The COD (Cash On Delivery) charges that you associate with a COD fulfillment order.
	/// </summary>
	public class CODSettings : BaseClass
	{
		/// <summary>
		/// When true, this fulfillment order requires a COD (Cash On Delivery) payment.
		/// </summary>
		[JsonProperty("isCodRequired")]
		[IsRequired]
		public bool IsCodRequired { get; set; } 

		/// <summary>
		/// The amount of the COD charge to be collected from the recipient for a COD order.
		/// </summary>
		[JsonProperty("codCharge")]
		public Money CodCharge { get; set; } 

		/// <summary>
		/// The amount of the tax on the COD charge to be collected from the recipient for a COD order.
		/// </summary>
		[JsonProperty("codChargeTax")]
		public Money CodChargeTax { get; set; } 

		/// <summary>
		/// The amount of the tax on the COD charge to be collected from the recipient for a COD order.
		/// </summary>
		[JsonProperty("shippingCharge")]
		public Money ShippingCharge { get; set; } 

		/// <summary>
		/// The amount of the tax on the shipping charge to be collected from the recipient for a COD order.
		/// </summary>
		[JsonProperty("shippingChargeTax")]
		public Money ShippingChargeTax { get; set; } 
	}
}
