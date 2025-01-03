namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema for the `createReservation` operation
	/// </summary>
	public class CreateReservationResponse : BaseClass
	{
		/// <summary>
		/// `CreateReservationRecord` contains only the new `reservationId` if the operation was successful
		/// Otherwise it will contain the reservation entity with warnings/errors
		/// </summary>
		[JsonProperty("payload")]
		public CreateReservationRecord Payload { get; set; }

		/// <summary>
		/// Errors encountered, if any
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
