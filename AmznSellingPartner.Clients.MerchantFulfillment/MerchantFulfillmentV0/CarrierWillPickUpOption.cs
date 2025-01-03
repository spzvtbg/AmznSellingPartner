namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Carrier will pick up option.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CarrierWillPickUpOption
	{
		/// <summary>
		/// The carrier will pick up the package.
		/// </summary>
		[EnumMember(Value = "CarrierWillPickUp")]
		CarrierWillPickUp,

		/// <summary>
		/// The seller is responsible for arranging pickup or dropping off the package to the carrier.
		/// </summary>
		[EnumMember(Value = "ShipperWillDropOff")]
		ShipperWillDropOff,

		/// <summary>
		/// No preference.
		/// </summary>
		[EnumMember(Value = "NoPreference")]
		NoPreference,
	}
}
