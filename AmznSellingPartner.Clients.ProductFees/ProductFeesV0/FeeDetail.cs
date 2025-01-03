namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The type of fee, fee amount, and other details
	/// </summary>
	public class FeeDetail : BaseClass
	{
		/// <summary>
		/// The type of fee charged to a seller
		/// </summary>
		[IsRequired]
		[JsonProperty("FeeType")]
		public string FeeType { get; set; }

		/// <summary>
		/// The amount charged for a given fee
		/// </summary>
		[IsRequired]
		[JsonProperty("FeeAmount")]
		public MoneyType FeeAmount { get; set; }

		/// <summary>
		/// The promotion amount for a given fee
		/// </summary>
		[JsonProperty("FeePromotion")]
		public MoneyType FeePromotion { get; set; }

		/// <summary>
		/// The tax amount for a given fee
		/// </summary>
		[JsonProperty("TaxAmount")]
		public MoneyType TaxAmount { get; set; }

		/// <summary>
		/// The final fee amount for a given fee
		/// </summary>
		[IsRequired]
		[JsonProperty("FinalFee")]
		public MoneyType FinalFee { get; set; }

		[JsonProperty("IncludedFeeDetailList")]
		public IncludedFeeDetailList IncludedFeeDetailList { get; set; }
	}
}
