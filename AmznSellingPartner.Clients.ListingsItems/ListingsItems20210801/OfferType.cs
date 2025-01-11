namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum OfferType
	{
		/// <summary>
		/// The offer on this listings item is available for Business to Consumer purchase, meaning that
		/// it is available to shoppers on Amazon retail sites.
		/// </summary>
		[EnumMember(Value = "B2C")]
		B2C,

		/// <summary>
		/// The offer on this listings item is available for Business to Business purchase.
		/// </summary>
		[EnumMember(Value = "B2B")]
		B2B,
	}
}
