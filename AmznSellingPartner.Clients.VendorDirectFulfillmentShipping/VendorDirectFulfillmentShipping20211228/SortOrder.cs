namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder
	{
		/// <summary>
		/// Sort in ascending order by packing slip creation date
		/// </summary>
		[EnumMember(Value = "ASC")]
		ASC,

		/// <summary>
		/// Sort in descending order by packing slip creation date
		/// </summary>
		[EnumMember(Value = "DESC")]
		DESC,
	}
}
