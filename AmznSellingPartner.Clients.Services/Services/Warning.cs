namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Warning returned when the request is successful, but there are important callouts based on which API
	/// clients should take defined actions.
	/// </summary>
	public class Warning : BaseClass
	{
		/// <summary>
		/// An warning code that identifies the type of warning that occurred.
		/// </summary>
		[JsonProperty("code")]
		[IsRequired]
		public string Code { get; set; } 

		/// <summary>
		/// A message that describes the warning condition in a human-readable form.
		/// </summary>
		[JsonProperty("message")]
		[IsRequired]
		public string Message { get; set; } 

		/// <summary>
		/// Additional details that can help the caller understand or address the warning.
		/// </summary>
		[JsonProperty("details")]
		public string Details { get; set; } 
	}
}
