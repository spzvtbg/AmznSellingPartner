namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PaymentMethod
	{
		/// <summary>
		/// Cash on delivery
		/// </summary>
		[EnumMember(Value = "COD")]
		COD,

		/// <summary>
		/// Convenience store
		/// </summary>
		[EnumMember(Value = "CVS")]
		CVS,

		/// <summary>
		/// A payment method other than COD and CVS
		/// </summary>
		[EnumMember(Value = "Other")]
		Other,
	}
}
