namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The expiration details of the inventory. This object will only appear if the details parameter in the
	/// request is set to `SHOW`.
	/// </summary>
	public class ExpirationDetails : BaseClass
	{
		/// <summary>
		/// The expiration date of the SKU.
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; } 

		/// <summary>
		/// The quantity that is present in AWD.
		/// </summary>
		[JsonProperty("onhandQuantity")]
		public long OnhandQuantity { get; set; } 
	}
}
