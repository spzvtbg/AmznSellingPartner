namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Collection Form Document Details
	/// </summary>
	public class CollectionsFormDocument : BaseClass
	{
		/// <summary>
		/// Base64 document Value of Collection.
		/// </summary>
		[JsonProperty("base64EncodedContent")]
		public string Base64EncodedContent { get; set; } 

		/// <summary>
		/// Collection Document format is PDF.
		/// </summary>
		[JsonProperty("documentFormat")]
		public string DocumentFormat { get; set; } 
	}
}
