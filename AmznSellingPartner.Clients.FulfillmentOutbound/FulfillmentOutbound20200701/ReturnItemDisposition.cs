namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The condition of the return item when received by an Amazon fulfillment center
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReturnItemDisposition
	{
		/// <summary>
		/// Item is in sellable condition
		/// </summary>
		[EnumMember(Value = "Sellable")]
		Sellable,

		/// <summary>
		/// Item is defective
		/// </summary>
		[EnumMember(Value = "Defective")]
		Defective,

		/// <summary>
		/// Item was damaged by the buyer or the seller
		/// </summary>
		[EnumMember(Value = "CustomerDamaged")]
		CustomerDamaged,

		/// <summary>
		/// Item was damaged by the carrier
		/// </summary>
		[EnumMember(Value = "CarrierDamaged")]
		CarrierDamaged,

		/// <summary>
		/// Item was damaged by Amazon
		/// </summary>
		[EnumMember(Value = "FulfillerDamaged")]
		FulfillerDamaged,
	}
}
