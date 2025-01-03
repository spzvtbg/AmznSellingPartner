namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The entity that labels the products
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LabelOwner
	{
		/// <summary>
		/// Amazon labels the products
		/// </summary>
		[EnumMember(Value = "AMAZON")]
		AMAZON,

		/// <summary>
		/// The seller labels the products
		/// </summary>
		[EnumMember(Value = "SELF")]
		SELF,
	}
}
