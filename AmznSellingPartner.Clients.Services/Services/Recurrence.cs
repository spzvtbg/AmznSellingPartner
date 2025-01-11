namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Repeated occurrence of an event in a time range.
	/// </summary>
	public class Recurrence : BaseClass
	{
		/// <summary>
		/// End time of the recurrence.
		/// </summary>
		[JsonProperty("endTime")]
		[IsRequired]
		public DateTimeValue EndTime { get; set; } 

		/// <summary>
		/// Days of the week when recurrence is valid. If the schedule is valid every Monday, input will
		/// only contain `MONDAY` in the list.
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
