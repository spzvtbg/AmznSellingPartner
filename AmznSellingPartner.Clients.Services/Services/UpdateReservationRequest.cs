namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request schema for the `updateReservation` operation.
	/// </summary>
	public class UpdateReservationRequest : BaseClass
	{
		/// <summary>
		/// Resource (store) identifier.
		/// </summary>
		[JsonProperty("resourceId")]
		[IsRequired]
		public string ResourceId { get; set; }

		/// <summary>
		/// `Reservation` object to reduce the capacity of a resource.
		/// </summary>
		[JsonProperty("reservation")]
		[IsRequired]
		public Reservation Reservation { get; set; }
	}
}
