namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// An optional enrollment program to return the estimated fees when the offer is fulfilled by Amazon (IsAmazonFul
	/// illed is set to true).
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OptionalFulfillmentProgram
	{
		/// <summary>
		/// Returns the standard Amazon fulfillment fees for the offer. This is the default.
		/// </summary>
		[EnumMember(Value = "FBA_CORE")]
		FBA_CORE,

		/// <summary>
		/// Returns the FBA Small and Light (SNL) fees for the offer. The SNL program offers reduced fulfillment costs on
		/// ualified items. To check item eligibility for the SNL program, use the getSmallAndLightEligibilityBySellerSKU
		/// peration of the FBA Small And Light API.  **Note:** The FBA Small and Light program sunset in the US and EU re
		/// ions on **September 26, 2023**. The program will be deprecated in the JP region on **March 31, 2024** and suns
		/// t on **April 1, 2024**. APIs announcing deprecation will no longer be supported after their deprecation date.
		/// alls to deprecated APIs will fail beginning on their sunset date. For more information, refer to [FBA Small an
		/// Light program deprecation](https://developer-docs.amazon.com/sp-api/changelog/fba-small-and-light-program-dep
		/// ecation).
		/// </summary>
		[EnumMember(Value = "FBA_SNL")]
		FBA_SNL,

		/// <summary>
		/// Returns the cross-border European Fulfillment Network fees across EU countries for the offer.
		/// </summary>
		[EnumMember(Value = "FBA_EFN")]
		FBA_EFN,
	}
}
