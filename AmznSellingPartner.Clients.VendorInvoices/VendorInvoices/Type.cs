namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
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

		/// <summary>
		/// The total number of cartons invoiced.
		/// </summary>
		[EnumMember(Value = "CartonCount")]
		CartonCount,

		/// <summary>
		/// Freight charges.
		/// </summary>
		[EnumMember(Value = "Freight")]
		Freight,

		/// <summary>
		/// Packing fee.
		/// </summary>
		[EnumMember(Value = "Packing")]
		Packing,

		/// <summary>
		/// Duty charges.
		/// </summary>
		[EnumMember(Value = "Duty")]
		Duty,

		/// <summary>
		/// Service fee.
		/// </summary>
		[EnumMember(Value = "Service")]
		Service,

		/// <summary>
		/// Small order fee.
		/// </summary>
		[EnumMember(Value = "SmallOrder")]
		SmallOrder,

		/// <summary>
		/// Insurance placement cost.
		/// </summary>
		[EnumMember(Value = "InsurancePlacementCost")]
		InsurancePlacementCost,

		/// <summary>
		/// Insurance fee.
		/// </summary>
		[EnumMember(Value = "InsuranceFee")]
		InsuranceFee,

		/// <summary>
		/// Special handling service fee.
		/// </summary>
		[EnumMember(Value = "SpecialHandlingService")]
		SpecialHandlingService,

		/// <summary>
		/// Collection and recycling service fee.
		/// </summary>
		[EnumMember(Value = "CollectionAndRecyclingService")]
		CollectionAndRecyclingService,

		/// <summary>
		/// Environmental protection service fee.
		/// </summary>
		[EnumMember(Value = "EnvironmentalProtectionService")]
		EnvironmentalProtectionService,

		/// <summary>
		/// Tax collected at source.
		/// </summary>
		[EnumMember(Value = "TaxCollectedAtSource")]
		TaxCollectedAtSource,

		/// <summary>
		/// Discount allowance.
		/// </summary>
		[EnumMember(Value = "Discount")]
		Discount,

		/// <summary>
		/// Discount incentive allowance.
		/// </summary>
		[EnumMember(Value = "DiscountIncentive")]
		DiscountIncentive,

		/// <summary>
		/// Allowance applied for defective item.
		/// </summary>
		[EnumMember(Value = "Defective")]
		Defective,

		/// <summary>
		/// Promotional allowance.
		/// </summary>
		[EnumMember(Value = "Promotional")]
		Promotional,

		/// <summary>
		/// Allowance applied due to unsaleable merchandise.
		/// </summary>
		[EnumMember(Value = "UnsaleableMerchandise")]
		UnsaleableMerchandise,

		/// <summary>
		/// Special allowances.
		/// </summary>
		[EnumMember(Value = "Special")]
		Special,

		/// <summary>
		/// Payment term that buyer and seller have agreed to.
		/// </summary>
		[EnumMember(Value = "Basic")]
		Basic,

		/// <summary>
		/// Payment term where seller gets paid end of month.
		/// </summary>
		[EnumMember(Value = "EndOfMonth")]
		EndOfMonth,

		/// <summary>
		/// Payment term where seller gets paid on a fixed date as agreed with buyer.
		/// </summary>
		[EnumMember(Value = "FixedDate")]
		FixedDate,

		/// <summary>
		/// Payment term where seller gets paid end of following month.
		/// </summary>
		[EnumMember(Value = "Proximo")]
		Proximo,

		/// <summary>
		/// Payment term where seller gets paid upon receipt of the invoice by the buyer.
		/// </summary>
		[EnumMember(Value = "PaymentDueUponReceiptOfInvoice")]
		PaymentDueUponReceiptOfInvoice,

		/// <summary>
		/// A payment undertaking given by a bank to the seller and is issued on behalf of the applicant i.e. the
		/// buyer.
		/// </summary>
		[EnumMember(Value = "LetterofCredit")]
		LetterofCredit,
	}
}
