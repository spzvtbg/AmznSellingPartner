namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Additional information required to purchase shipping
	/// </summary>
	public class AdditionalSellerInput : BaseClass
	{
		/// <summary>
		/// The data type of the additional information
		/// </summary>
		[JsonProperty("DataType")]
		public string DataType { get; set; }

		/// <summary>
		/// The value when the data type is string
		/// </summary>
		[JsonProperty("ValueAsString")]
		public string ValueAsString { get; set; }

		/// <summary>
		/// The value when the data type is boolean
		/// </summary>
		[JsonProperty("ValueAsBoolean")]
		public bool ValueAsBoolean { get; set; }

		/// <summary>
		/// The value when the data type is integer
		/// </summary>
		[JsonProperty("ValueAsInteger")]
		public int ValueAsInteger { get; set; }

		/// <summary>
		/// The value when the data type is a date-time formatted string
		/// </summary>
		[JsonProperty("ValueAsTimestamp")]
		public Timestamp ValueAsTimestamp { get; set; }

		[JsonProperty("ValueAsAddress")]
		public Address ValueAsAddress { get; set; }

		[JsonProperty("ValueAsWeight")]
		public Weight ValueAsWeight { get; set; }

		[JsonProperty("ValueAsDimension")]
		public Length ValueAsDimension { get; set; }

		[JsonProperty("ValueAsCurrency")]
		public CurrencyAmount ValueAsCurrency { get; set; }
	}
}
