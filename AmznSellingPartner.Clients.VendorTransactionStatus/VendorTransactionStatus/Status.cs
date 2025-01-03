namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Status
	{
		/// <summary>
		/// Transaction has failed
		/// </summary>
		[EnumMember(Value = "Failure")]
		Failure,

		/// <summary>
		/// Transaction is in process
		/// </summary>
		[EnumMember(Value = "Processing")]
		Processing,

		/// <summary>
		/// Transaction has completed successfully
		/// </summary>
		[EnumMember(Value = "Success")]
		Success,
	}
}
