namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Success.
	/// </summary>
	public class GetInvoicesExportsResponse : BaseClass
	{
		/// <summary>
		/// A list of exports.
		/// </summary>
		[MaxItems(100)]
		[JsonProperty("exports")]
		public List<Export> Exports { get; set; }

		/// <summary>
		/// This token is returned when the number of results exceeds the specified `pageSize` value. To get the
		/// next page of results, call the `getInvoices` operation and include this token with the previous call
		/// parameters.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
