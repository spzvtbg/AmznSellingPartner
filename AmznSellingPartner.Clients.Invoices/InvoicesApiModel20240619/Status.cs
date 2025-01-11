namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Status
	{
		/// <summary>
		/// The export request was created, but has not started yet.
		/// </summary>
		[EnumMember(Value = "REQUESTED")]
		REQUESTED,

		/// <summary>
		/// The export request is being processed
		/// </summary>
		[EnumMember(Value = "PROCESSING")]
		PROCESSING,

		/// <summary>
		/// The export request is finished with success. Use the document IDs to download the output d
		/// ocuments.
		/// </summary>
		[EnumMember(Value = "DONE")]
		DONE,

		/// <summary>
		/// The export request resulted in an error. Check the `errorMessage` attribute for more detai
		/// ls.
		/// </summary>
		[EnumMember(Value = "ERROR")]
		ERROR,
	}
}
