namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Active Account Details
	/// </summary>
	public class ActiveAccount : BaseClass
	{
		/// <summary>
		/// Account Id associated with this account
		/// </summary>
		[JsonProperty("accountId")]
		public string AccountId { get; set; }

		[JsonProperty("carrierId")]
		public CarrierId CarrierId { get; set; }
	}
}
