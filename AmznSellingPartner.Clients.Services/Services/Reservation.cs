namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Reservation object reduces the capacity of a resource.
	/// </summary>
	public class Reservation : BaseClass
	{
		/// <summary>
		/// Unique identifier for a reservation. If present, it is treated as an update reservation request and will
		/// update the corresponding reservation. Otherwise, it is treated as a new create reservation request.
		/// </summary>
		[JsonProperty("reservationId")]
		public string ReservationId { get; set; } 

		/// <summary>
		/// Type of reservation.
		/// </summary>
		[JsonProperty("type")]
		[IsRequired]
		public Type Type { get; set; } 

		/// <summary>
		/// `AvailabilityRecord` to represent the capacity of a resource over a time range.
		/// </summary>
		[JsonProperty("availability")]
		[IsRequired]
		public AvailabilityRecord Availability { get; set; } 
	}
}
