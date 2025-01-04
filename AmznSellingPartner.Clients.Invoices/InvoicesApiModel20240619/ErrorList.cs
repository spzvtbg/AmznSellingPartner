namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses that are returned when a request is unsuccessful.
	/// </summary>
	public class ErrorList : BaseClass
	{
		/// <summary>
		/// List of errors.
		/// </summary>
		[JsonProperty("errors")]
		[IsRequired]
		public List<Error> Errors { get; set; }
	}
}
