namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;

	/// <summary>
	/// Terms of the payment for the invoice. The basis of the payment terms is the invoice date.
	/// </summary>
	public class PaymentTerms : BaseClass
	{
		/// <summary>
		/// The payment term type for the invoice.
		/// </summary>
		[JsonProperty("type")]
		public Type Type { get; set; }

		/// <summary>
		/// The discount percent value, which is good until the discount due date.
		/// </summary>
		[JsonProperty("discountPercent")]
		public Decimal DiscountPercent { get; set; }

		/// <summary>
		/// The number of calendar days from the Base date (Invoice date) until the discount is no longer valid.
		/// </summary>
		[JsonProperty("discountDueDays")]
		public double DiscountDueDays { get; set; }

		/// <summary>
		/// The number of calendar days from the base date (invoice date) until the total amount on the invoice is
		/// due.
		/// </summary>
		[JsonProperty("netDueDays")]
		public double NetDueDays { get; set; }
	}
}
