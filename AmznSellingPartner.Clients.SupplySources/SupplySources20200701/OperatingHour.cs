namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The operating hour schema
	/// </summary>
	public class OperatingHour : BaseClass
	{
		/// <summary>
		/// The opening time, ISO 8601 formatted timestamp without date, HH:mm.
		/// </summary>
		[JsonProperty("startTime")]
		public string StartTime { get; set; }

		/// <summary>
		/// The closing time, ISO 8601 formatted timestamp without date, HH:mm.
		/// </summary>
		[JsonProperty("endTime")]
		public string EndTime { get; set; }
	}
}
