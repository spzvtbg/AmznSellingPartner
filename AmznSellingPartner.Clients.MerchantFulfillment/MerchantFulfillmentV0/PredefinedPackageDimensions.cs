namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// An enumeration of predefined parcel tokens. If you specify a `PredefinedPackageDimensions` token, you
	/// are not obligated to use a branded package from a carrier. For example, if you specify the `FedEx_Box_10kg`
	/// token, you do not have to use that particular package from FedEx. You are only obligated to use a box
	/// that matches the dimensions specified by the token. Note: Carriers can have restrictions on the type
	/// of package allowed for certain ship methods. Check the carrier website for details. Example: Flat rate
	/// pricing is available when materials are sent by USPS in a USPS-produced Flat Rate envelope or box.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PredefinedPackageDimensions
	{
		/// <summary>
		/// 15.81 x 12.94 x 10.19 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_10kg")]
		FedEx_Box_10kg,

		/// <summary>
		/// 54.80 x 42.10 x 33.50 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_25kg")]
		FedEx_Box_25kg,

		/// <summary>
		/// 11.88 x 11.00 x 10.75 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Extra_Large_1")]
		FedEx_Box_Extra_Large_1,

		/// <summary>
		/// 15.75 x 14.13 x 6.00 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Extra_Large_2")]
		FedEx_Box_Extra_Large_2,

		/// <summary>
		/// 17.50 x 12.38 x 3.00 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Large_1")]
		FedEx_Box_Large_1,

		/// <summary>
		/// 11.25 x 8.75 x 7.75 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Large_2")]
		FedEx_Box_Large_2,

		/// <summary>
		/// 13.25 x 11.50 x 2.38 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Medium_1")]
		FedEx_Box_Medium_1,

		/// <summary>
		/// 11.25 x 8.75 x 4.38 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Medium_2")]
		FedEx_Box_Medium_2,

		/// <summary>
		/// 12.38 x 10.88 x 1.50 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Small_1")]
		FedEx_Box_Small_1,

		/// <summary>
		/// 8.75 x 2.63 x 11.25 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Box_Small_2")]
		FedEx_Box_Small_2,

		/// <summary>
		/// 12.50 x 9.50 x 0.80 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Envelope")]
		FedEx_Envelope,

		/// <summary>
		/// 11.75 x 14.75 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Padded_Pak")]
		FedEx_Padded_Pak,

		/// <summary>
		/// 15.50 x 12.00 x 0.80 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Pak_1")]
		FedEx_Pak_1,

		/// <summary>
		/// 12.75 x 10.25 x 0.80 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Pak_2")]
		FedEx_Pak_2,

		/// <summary>
		/// 38.00 x 6.00 x 6.00 in.
		/// </summary>
		[EnumMember(Value = "FedEx_Tube")]
		FedEx_Tube,

		/// <summary>
		/// 17.50 x 20.75 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "FedEx_XL_Pak")]
		FedEx_XL_Pak,

		/// <summary>
		/// 41.00 x 33.50 x 26.50 cm.
		/// </summary>
		[EnumMember(Value = "UPS_Box_10kg")]
		UPS_Box_10kg,

		/// <summary>
		/// 48.40 x 43.30 x 35.00 cm.
		/// </summary>
		[EnumMember(Value = "UPS_Box_25kg")]
		UPS_Box_25kg,

		/// <summary>
		/// 46.00 x 31.50 x 9.50 cm.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Box")]
		UPS_Express_Box,

		/// <summary>
		/// 18.00 x 13.00 x 3.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Box_Large")]
		UPS_Express_Box_Large,

		/// <summary>
		/// 15.00 x 11.00 x 3.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Box_Medium")]
		UPS_Express_Box_Medium,

		/// <summary>
		/// 13.00 x 11.00 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Box_Small")]
		UPS_Express_Box_Small,

		/// <summary>
		/// 12.50 x 9.50 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Envelope")]
		UPS_Express_Envelope,

		/// <summary>
		/// 14.75 x 11.50 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Hard_Pak")]
		UPS_Express_Hard_Pak,

		/// <summary>
		/// 15.00 x 9.50 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Legal_Envelope")]
		UPS_Express_Legal_Envelope,

		/// <summary>
		/// 16.00 x 12.75 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Pak")]
		UPS_Express_Pak,

		/// <summary>
		/// 97.00 x 19.00 x 16.50 cm.
		/// </summary>
		[EnumMember(Value = "UPS_Express_Tube")]
		UPS_Express_Tube,

		/// <summary>
		/// 17.25 x 12.75 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Laboratory_Pak")]
		UPS_Laboratory_Pak,

		/// <summary>
		/// 14.75 x 11.00 x 2.00 in.
		/// </summary>
		[EnumMember(Value = "UPS_Pad_Pak")]
		UPS_Pad_Pak,

		/// <summary>
		/// 120.00 x 80.00 x 200.00 cm.
		/// </summary>
		[EnumMember(Value = "UPS_Pallet")]
		UPS_Pallet,

		/// <summary>
		/// 6.00 x 4.25 x 0.01 in.
		/// </summary>
		[EnumMember(Value = "USPS_Card")]
		USPS_Card,

		/// <summary>
		/// 15.00 x 12.00 x 0.75 in.
		/// </summary>
		[EnumMember(Value = "USPS_Flat")]
		USPS_Flat,

		/// <summary>
		/// 12.50 x 9.50 x 4.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_FlatRateCardboardEnvelope")]
		USPS_FlatRateCardboardEnvelope,

		/// <summary>
		/// 12.50 x 9.50 x 4.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_FlatRateEnvelope")]
		USPS_FlatRateEnvelope,

		/// <summary>
		/// 10.00 x 7.00 x 4.00 in
		/// </summary>
		[EnumMember(Value = "USPS_FlatRateGiftCardEnvelope")]
		USPS_FlatRateGiftCardEnvelope,

		/// <summary>
		/// 15.00 x 9.50 x 4.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_FlatRateLegalEnvelope")]
		USPS_FlatRateLegalEnvelope,

		/// <summary>
		/// 12.50 x 9.50 x 4.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_FlatRatePaddedEnvelope")]
		USPS_FlatRatePaddedEnvelope,

		/// <summary>
		/// 10.00 x 5.00 x 4.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_FlatRateWindowEnvelope")]
		USPS_FlatRateWindowEnvelope,

		/// <summary>
		/// 24.06 x 11.88 x 3.13 in.
		/// </summary>
		[EnumMember(Value = "USPS_LargeFlatRateBoardGameBox")]
		USPS_LargeFlatRateBoardGameBox,

		/// <summary>
		/// 12.25 x 12.25 x 6.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_LargeFlatRateBox")]
		USPS_LargeFlatRateBox,

		/// <summary>
		/// 11.50 x 6.13 x 0.25 in.
		/// </summary>
		[EnumMember(Value = "USPS_Letter")]
		USPS_Letter,

		/// <summary>
		/// 11.25 x 8.75 x 6.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_MediumFlatRateBox1")]
		USPS_MediumFlatRateBox1,

		/// <summary>
		/// 14.00 x 12.00 x 3.50 in.
		/// </summary>
		[EnumMember(Value = "USPS_MediumFlatRateBox2")]
		USPS_MediumFlatRateBox2,

		/// <summary>
		/// 10.13 x 7.13 x 5.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_RegionalRateBoxA1")]
		USPS_RegionalRateBoxA1,

		/// <summary>
		/// 13.06 x 11.06 x 2.50 in.
		/// </summary>
		[EnumMember(Value = "USPS_RegionalRateBoxA2")]
		USPS_RegionalRateBoxA2,

		/// <summary>
		/// 16.25 x 14.50 x 3.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_RegionalRateBoxB1")]
		USPS_RegionalRateBoxB1,

		/// <summary>
		/// 12.25 x 10.50 x 5.50 in.
		/// </summary>
		[EnumMember(Value = "USPS_RegionalRateBoxB2")]
		USPS_RegionalRateBoxB2,

		/// <summary>
		/// 15.00 x 12.00 x 12.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_RegionalRateBoxC")]
		USPS_RegionalRateBoxC,

		/// <summary>
		/// 8.69 x 5.44 x 1.75 in.
		/// </summary>
		[EnumMember(Value = "USPS_SmallFlatRateBox")]
		USPS_SmallFlatRateBox,

		/// <summary>
		/// 10.00 x 6.00 x 4.00 in.
		/// </summary>
		[EnumMember(Value = "USPS_SmallFlatRateEnvelope")]
		USPS_SmallFlatRateEnvelope,
	}
}
