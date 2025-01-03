namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Information about the prescription that is used to verify a regulated product. This must be provided
	/// once per order and reflect the seller’s own records. Only approved orders can have prescriptions.
	/// </summary>
	public class PrescriptionDetail : BaseClass
	{
		/// <summary>
		/// The identifier for the prescription used to verify the regulated product.
		/// </summary>
		[IsRequired]
		[JsonProperty("prescriptionId")]
		public string PrescriptionId { get; set; }

		/// <summary>
		/// The expiration date of the prescription used to verify the regulated product, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date time format.
		/// </summary>
		[IsRequired]
		[JsonProperty("expirationDate")]
		public DateTime ExpirationDate { get; set; }

		/// <summary>
		/// The number of units in each fill as provided in the prescription.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[JsonProperty("writtenQuantity")]
		public int WrittenQuantity { get; set; }

		/// <summary>
		/// The total number of refills written in the original prescription used to verify the regulated product.
		/// If a prescription originally had no refills, this value must be 0.
		/// </summary>
		[IsRequired]
		[Minimum(0)]
		[JsonProperty("totalRefillsAuthorized")]
		public int TotalRefillsAuthorized { get; set; }

		/// <summary>
		/// The number of refills remaining for the prescription used to verify the regulated product. If a prescription
		/// originally had 10 total refills, this value must be `10` for the first order, `9` for the second order,
		/// and `0` for the eleventh order. If a prescription originally had no refills, this value must be 0.
		/// </summary>
		[IsRequired]
		[Minimum(0)]
		[JsonProperty("refillsRemaining")]
		public int RefillsRemaining { get; set; }

		/// <summary>
		/// The identifier for the clinic which provided the prescription used to verify the regulated product.
		/// </summary>
		[IsRequired]
		[JsonProperty("clinicId")]
		public string ClinicId { get; set; }

		/// <summary>
		/// The instructions for the prescription as provided by the approver of the regulated product.
		/// </summary>
		[IsRequired]
		[JsonProperty("usageInstructions")]
		public string UsageInstructions { get; set; }
	}
}
