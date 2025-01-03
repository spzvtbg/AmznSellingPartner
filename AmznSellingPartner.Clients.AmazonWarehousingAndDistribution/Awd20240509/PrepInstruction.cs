namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	/// <summary>
	/// Information pertaining to the preparation of inbound products.
	/// </summary>
	public class PrepInstruction : BaseClass
	{
		[JsonProperty("prepOwner")]
		public PrepOwner PrepOwner { get; set; }

		/// <summary>
		/// The type of preparation to be done. For more information about preparing items, refer to [Prep guidance](https://sellercentral.amazon.com/help/hub/reference/external/GF4G7547KSLDX2KC)
		/// on Seller Central.
		/// </summary>
		[JsonProperty("prepType")]
		public string PrepType { get; set; }
	}
}
