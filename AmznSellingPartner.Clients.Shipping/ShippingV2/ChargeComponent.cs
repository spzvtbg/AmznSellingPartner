namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The type and amount of a charge applied on a package.
	/// </summary>
	public class ChargeComponent : BaseClass
	{
		[JsonProperty("amount")]
		public Currency Amount { get; set; }

		/// <summary>
		/// The type of charge.
		/// </summary>
		[JsonProperty("chargeType")]
		public ChargeType ChargeType { get; set; }
	}
}
