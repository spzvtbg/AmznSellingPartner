namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortField
	{
		/// <summary>
		/// Sort on job date.
		/// </summary>
		[EnumMember(Value = "JOB_DATE")]
		JOB_DATE,

		/// <summary>
		/// Sort on job status.
		/// </summary>
		[EnumMember(Value = "JOB_STATUS")]
		JOB_STATUS,
	}
}
