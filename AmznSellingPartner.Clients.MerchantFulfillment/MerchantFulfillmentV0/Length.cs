namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The length.
	/// </summary>
	public class Length : BaseClass
	{
		/// <summary>
		/// The value in units.
		/// </summary>
		[JsonProperty("value")]
		public double Value { get; set; } 

		[JsonProperty("unit")]
		public UnitOfLength Unit { get; set; } 
	}
}
