namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request schema for the `createReservation` operation.
	/// </summary>
	public class CreateReservationRequest : BaseClass
	{
		/// <summary>
		/// Resource (store) identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("resourceId")]
		public string ResourceId { get; set; }

		/// <summary>
		/// `Reservation` object to reduce the capacity of a resource.
		/// </summary>
		[IsRequired]
		[JsonProperty("reservation")]
		public Reservation Reservation { get; set; }
	}
}
