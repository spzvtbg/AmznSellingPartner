namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Repeated occurrence of an event in a time range.
	/// </summary>
	public class Recurrence : BaseClass
	{
		/// <summary>
		/// End time of the recurrence.
		/// </summary>
		[IsRequired]
		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; }

		/// <summary>
		/// Days of the week when recurrence is valid. If the schedule is valid every Monday, input will only contain `MON
		/// AY` in the list.
		/// </summary>
		[JsonProperty("daysOfWeek")]
		public List<DayOfWeek> DaysOfWeek { get; set; }

		/// <summary>
		/// Days of the month when recurrence is valid.
		/// </summary>
		[JsonProperty("daysOfMonth")]
		public List<int> DaysOfMonth { get; set; }
	}
}
