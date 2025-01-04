namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// A packing option contains a set of pack groups plus additional information about the packing option,
	/// such as any discounts or fees if it's selected.
	/// </summary>
	public class PackingOption : BaseClass
	{
		/// <summary>
		/// Discount for the offered option.
		/// </summary>
		[JsonProperty("discounts")]
		[IsRequired]
		public List<Incentive> Discounts { get; set; }

		/// <summary>
		/// The time at which this packing option is no longer valid. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mm:ss.sssZ`.
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; }

		/// <summary>
		/// Fee for the offered option.
		/// </summary>
		[JsonProperty("fees")]
		[IsRequired]
		public List<Incentive> Fees { get; set; }

		/// <summary>
		/// Packing group IDs.
		/// </summary>
		[JsonProperty("packingGroups")]
		[IsRequired]
		public List<string> PackingGroups { get; set; }

		/// <summary>
		/// Identifier of a packing option.
		/// </summary>
		[JsonProperty("packingOptionId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string PackingOptionId { get; set; }

		/// <summary>
		/// The status of the packing option. Possible values: `OFFERED`, `ACCEPTED`, `EXPIRED`.
		/// </summary>
		[JsonProperty("status")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Status { get; set; }

		/// <summary>
		/// List of supported shipping modes.
		/// </summary>
		[JsonProperty("supportedShippingConfigurations")]
		[IsRequired]
		public List<ShippingConfiguration> SupportedShippingConfigurations { get; set; }
	}
}
