namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The type of standard identifier to print on the label.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StandardIdForLabel
	{
		/// <summary>
		/// An Amazon-defined order identifier in 3-7-7 format.
		/// </summary>
		[EnumMember(Value = "AmazonOrderId")]
		AmazonOrderId,
	}
}
