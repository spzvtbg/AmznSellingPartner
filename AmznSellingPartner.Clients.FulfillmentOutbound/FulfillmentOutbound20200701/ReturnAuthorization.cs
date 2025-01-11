namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Return authorization information for items accepted for return.
	/// </summary>
	public class ReturnAuthorization : BaseClass
	{
		/// <summary>
		/// An identifier for the return authorization. This identifier associates return items with the
		/// return authorization used to return them.
		/// </summary>
		[JsonProperty("returnAuthorizationId")]
		[IsRequired]
		public string ReturnAuthorizationId { get; set; } 

		/// <summary>
		/// An identifier for the Amazon fulfillment center that the return items should be sent to.
		/// </summary>
		[JsonProperty("fulfillmentCenterId")]
		[IsRequired]
		public string FulfillmentCenterId { get; set; } 

		/// <summary>
		/// The address of the Amazon fulfillment center that the return items should be sent to.
		/// </summary>
		[JsonProperty("returnToAddress")]
		[IsRequired]
		public Address ReturnToAddress { get; set; } 

		/// <summary>
		/// The return merchandise authorization (RMA) that Amazon needs to process the return.
		/// </summary>
		[JsonProperty("amazonRmaId")]
		[IsRequired]
		public string AmazonRmaId { get; set; } 

		/// <summary>
		/// A URL for a web page that contains the return authorization barcode and the mailing label.
		/// This does not include pre-paid shipping.
		/// </summary>
		[JsonProperty("rmaPageURL")]
		[IsRequired]
		public string RmaPageURL { get; set; } 
	}
}
