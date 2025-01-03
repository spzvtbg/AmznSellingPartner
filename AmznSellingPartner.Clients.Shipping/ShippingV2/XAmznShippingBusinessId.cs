namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum XAmznShippingBusinessId
	{
		/// <summary>
		/// The United States Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_US")]
		AmazonShipping_US,

		/// <summary>
		/// The India Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_IN")]
		AmazonShipping_IN,

		/// <summary>
		/// The United Kingdom Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_UK")]
		AmazonShipping_UK,

		/// <summary>
		/// The United Arab Emirates Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_UAE")]
		AmazonShipping_UAE,

		/// <summary>
		/// The Saudi Arabia Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_SA")]
		AmazonShipping_SA,

		/// <summary>
		/// The Egypt Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_EG")]
		AmazonShipping_EG,

		/// <summary>
		/// The Italy Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_IT")]
		AmazonShipping_IT,

		/// <summary>
		/// The Spain Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_ES")]
		AmazonShipping_ES,

		/// <summary>
		/// The France Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_FR")]
		AmazonShipping_FR,

		/// <summary>
		/// The Japan Amazon shipping business
		/// </summary>
		[EnumMember(Value = "AmazonShipping_JP")]
		AmazonShipping_JP,
	}
}
