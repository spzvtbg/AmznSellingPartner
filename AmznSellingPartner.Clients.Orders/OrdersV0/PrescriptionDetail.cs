namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the prescription that is used to verify a regulated product. This must be provided
	/// once per order and reflect the seller’s own records. Only approved orders can have prescriptions.
	/// </summary>
	public class PrescriptionDetail : BaseClass
	{
		/// <summary>
		/// The identifier for the prescription used to verify the regulated product.
		/// </summary>
		[JsonProperty("prescriptionId")]
		[IsRequired]
		public string PrescriptionId { get; set; } 

		/// <summary>
		/// The expiration date of the prescription used to verify the regulated product, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date time format.
		/// </summary>
		[JsonProperty("expirationDate")]
		[IsRequired]
		public DateTimeValue ExpirationDate { get; set; } 

		/// <summary>
		/// The number of units in each fill as provided in the prescription.
		/// </summary>
		[JsonProperty("writtenQuantity")]
		[IsRequired]
		[Minimum(1)]
		public int WrittenQuantity { get; set; } 

		/// <summary>
		/// The total number of refills written in the original prescription used to verify the regulated product.
		/// If a prescription originally had no refills, this value must be 0.
		/// </summary>
		[JsonProperty("totalRefillsAuthorized")]
		[IsRequired]
		[Minimum(0)]
		public int TotalRefillsAuthorized { get; set; } 

		/// <summary>
		/// The number of refills remaining for the prescription used to verify the regulated product. If a prescription
		/// originally had 10 total refills, this value must be `10` for the first order, `9` for the second order,
		/// and `0` for the eleventh order. If a prescription originally had no refills, this value must be 0.
		/// </summary>
		[JsonProperty("refillsRemaining")]
		[IsRequired]
		[Minimum(0)]
		public int RefillsRemaining { get; set; } 

		/// <summary>
		/// The identifier for the clinic which provided the prescription used to verify the regulated product.
		/// </summary>
		[JsonProperty("clinicId")]
		[IsRequired]
		public string ClinicId { get; set; } 

		/// <summary>
		/// The instructions for the prescription as provided by the approver of the regulated product.
		/// </summary>
		[JsonProperty("usageInstructions")]
		[IsRequired]
		public string UsageInstructions { get; set; } 
	}
}
