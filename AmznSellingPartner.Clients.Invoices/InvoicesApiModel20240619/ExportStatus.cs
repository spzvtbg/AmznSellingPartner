namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The current status of the request
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ExportStatus
	{
		/// <summary>
		/// The export request was created, but has not yet started
		/// </summary>
		[EnumMember(Value = "REQUESTED")]
		REQUESTED,

		/// <summary>
		/// The export request is being processed
		/// </summary>
		[EnumMember(Value = "PROCESSING")]
		PROCESSING,

		/// <summary>
		/// The export request has finished successfully
		/// Use the document IDs to download the output documents
		/// </summary>
		[EnumMember(Value = "DONE")]
		DONE,

		/// <summary>
		/// The export request resulted in an error
		/// Refer to the `errorMessage` attribute for more information
		/// </summary>
		[EnumMember(Value = "ERROR")]
		ERROR,
	}
}
