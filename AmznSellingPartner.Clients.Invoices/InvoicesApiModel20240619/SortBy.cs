namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortBy
	{
		/// <summary>
		/// Sort by date time
		/// </summary>
		[EnumMember(Value = "START_DATE_TIME")]
		START_DATE_TIME,
	}
}
