namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the buyer.
	/// </summary>
	public class Buyer : BaseClass
	{
		/// <summary>
		/// The identifier of the buyer.
		/// </summary>
		[JsonProperty("buyerId")]
		[Pattern("^[A-Z0-9]*")]
		public string BuyerId { get; set; } 

		/// <summary>
		/// The name of the buyer.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } 

		/// <summary>
		/// The phone number of the buyer.
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; } 

		/// <summary>
		/// When true, the service is for an Amazon Prime buyer.
		/// </summary>
		[JsonProperty("isPrimeMember")]
		public bool IsPrimeMember { get; set; } 
	}
}
