namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A delivery document for a package.
	/// </summary>
	public class DeliveryDocument : BaseClass
	{
		/// <summary>
		/// The delivery document type. Values are `SIGNATURE` and `DELIVERY_IMAGE`.
		/// </summary>
		[JsonProperty("documentType")]
		[IsRequired]
		public string DocumentType { get; set; } 

		/// <summary>
		/// A URL that you can use to download the document. This URL has a `Content-Type` header. Note that the
		/// URL expires after one hour. To get a new URL, you must call the API again.
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; } 
	}
}
