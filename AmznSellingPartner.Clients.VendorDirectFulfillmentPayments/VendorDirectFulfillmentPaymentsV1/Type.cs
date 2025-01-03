namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
		/// <summary>
		/// Additional charge applied for giftwrap order.
		/// </summary>
		[EnumMember(Value = "GIFTWRAP")]
		GIFTWRAP,

		/// <summary>
		/// Fulfillment fees are the costs associated with receiving and storing products along with processing orders
		/// from handling to shipping.
		/// </summary>
		[EnumMember(Value = "FULFILLMENT")]
		FULFILLMENT,

		/// <summary>
		/// Charge to insert ads on orders.
		/// </summary>
		[EnumMember(Value = "MARKETINGINSERT")]
		MARKETINGINSERT,

		/// <summary>
		/// Additional charge for packaging orders.
		/// </summary>
		[EnumMember(Value = "PACKAGING")]
		PACKAGING,

		/// <summary>
		/// Additional charge for loading orders.
		/// </summary>
		[EnumMember(Value = "LOADING")]
		LOADING,

		/// <summary>
		/// Freight-out refers to the costs for which the seller is responsible when shipping to a buyer, such as
		/// delivery and insurance expenses.
		/// </summary>
		[EnumMember(Value = "FREIGHTOUT")]
		FREIGHTOUT,

		/// <summary>
		/// Tax collected at source (TCS) is the tax payable by a seller which he collects from the buyer at the
		/// time of sale.
		/// </summary>
		[EnumMember(Value = "TAX_COLLECTED_AT_SOURCE")]
		TAX_COLLECTED_AT_SOURCE,

		/// <summary>
		/// An additional tax on something already taxed, such as a higher rate of tax on incomes above a certain
		/// level.
		/// </summary>
		[EnumMember(Value = "SUR")]
		SUR,

		/// <summary>
		/// OCR.
		/// </summary>
		[EnumMember(Value = "OCR")]
		OCR,
	}
}
