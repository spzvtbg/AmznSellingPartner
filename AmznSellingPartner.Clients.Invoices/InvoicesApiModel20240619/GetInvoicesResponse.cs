namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Success
	/// </summary>
	public class GetInvoicesResponse : BaseClass
	{
		/// <summary>
		/// A list of invoices
		/// </summary>
		[MaxItems(100)]
		[JsonProperty("invoices")]
		public List<Invoice> Invoices { get; set; }

		/// <summary>
		/// This token is returned when the number of results exceeds the specified `pageSize` value
		/// To get the next page of results, call the `getInvoices` operation and include this token with the previous ca
		/// l parameters
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
