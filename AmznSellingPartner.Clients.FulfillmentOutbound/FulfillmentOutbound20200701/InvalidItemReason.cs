namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The reason that the item is invalid for return
	/// </summary>
	public class InvalidItemReason : BaseClass
	{
		[IsRequired]
		[JsonProperty("invalidItemReasonCode")]
		public InvalidItemReasonCode InvalidItemReasonCode { get; set; }

		/// <summary>
		/// A human readable description of the invalid item reason code
		/// </summary>
		[IsRequired]
		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
