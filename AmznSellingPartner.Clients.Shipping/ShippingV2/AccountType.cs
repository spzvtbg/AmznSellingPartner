namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Shipper Account Type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AccountType
	{
		/// <summary>
		/// Shipper Account in case of others carriers like : FEDEX, ROYLA_MAIL, DHL etc.
		/// </summary>
		[EnumMember(Value = "SHIPPER_ACCOUNT")]
		SHIPPER_ACCOUNT,

		/// <summary>
		/// Shipper Account only for UPS .
		/// </summary>
		[EnumMember(Value = "SHIPPER_ACCOUNT_WITH_INVOICE")]
		SHIPPER_ACCOUNT_WITH_INVOICE,

		/// <summary>
		/// this for default account and will be used if seller dont have any active linked account.
		/// </summary>
		[EnumMember(Value = "AMAZON_ACCOUNT")]
		AMAZON_ACCOUNT,
	}
}
