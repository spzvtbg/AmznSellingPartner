namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The unique carrier code for the carrier for whom container labels are requested
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CarrierId
	{
		/// <summary>
		/// Ship with Amazon Carrier
		/// </summary>
		[EnumMember(Value = "SWA")]
		SWA,
	}
}
