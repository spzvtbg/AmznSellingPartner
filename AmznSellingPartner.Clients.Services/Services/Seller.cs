namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the seller of the service job
	/// </summary>
	public class Seller : BaseClass
	{
		/// <summary>
		/// The identifier of the seller of the service job
		/// </summary>
		[Pattern("^[A-Z0-9]*")]
		[JsonProperty("sellerId")]
		public string SellerId { get; set; }
	}
}
