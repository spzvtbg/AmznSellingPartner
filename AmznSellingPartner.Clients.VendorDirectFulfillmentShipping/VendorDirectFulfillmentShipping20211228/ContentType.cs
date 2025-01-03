namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentType
	{
		/// <summary>
		/// Portable Document Format (pdf)
		/// </summary>
		[EnumMember(Value = "application/pdf")]
		application_pdf,
	}
}
