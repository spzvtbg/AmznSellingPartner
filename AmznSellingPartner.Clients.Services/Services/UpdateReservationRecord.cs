namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// `UpdateReservationRecord` entity contains the `Reservation` if there is an error/warning while performing the
	/// equested operation on it, otherwise it will contain the new `reservationId`
	/// </summary>
	public class UpdateReservationRecord : BaseClass
	{
		/// <summary>
		/// Reservation record if the operation failed
		/// It will only contain the new `reservationId` if the operation is successful
		/// </summary>
		[JsonProperty("reservation")]
		public Reservation Reservation { get; set; }

		/// <summary>
		/// Warnings encountered, if any
		/// </summary>
		[JsonProperty("warnings")]
		public WarningList Warnings { get; set; }

		/// <summary>
		/// Errors encountered, if any
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
