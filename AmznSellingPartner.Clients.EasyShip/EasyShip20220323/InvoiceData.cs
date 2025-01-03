namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Invoice number and date
	/// </summary>
	public class InvoiceData : BaseClass
	{
		/// <summary>
		/// The invoice number
		/// </summary>
		[IsRequired]
		[JsonProperty("invoiceNumber")]
		public String InvoiceNumber { get; set; }

		/// <summary>
		/// The date that the invoice was generated
		/// </summary>
		[JsonProperty("invoiceDate")]
		public DateTime InvoiceDate { get; set; }
	}
}
