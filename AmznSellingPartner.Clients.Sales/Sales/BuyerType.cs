namespace AmznSellingPartner.Clients.Sales.Sales
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum BuyerType
	{
		/// <summary>
		/// Business to business.
		/// </summary>
		[EnumMember(Value = "B2B")]
		B2B,

		/// <summary>
		/// Business to customer.
		/// </summary>
		[EnumMember(Value = "B2C")]
		B2C,

		/// <summary>
		/// Business to business and business to customer.
		/// </summary>
		[EnumMember(Value = "All")]
		All,
	}
}
