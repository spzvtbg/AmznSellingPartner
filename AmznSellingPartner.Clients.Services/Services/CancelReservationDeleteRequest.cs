namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpDelete("/service/v1/reservation/{reservationId}")]
	public class CancelReservationDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// Reservation Identifier
		/// </summary>
		[InPath("reservationId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("reservationId")]
		public string ReservationId { get; set; }

		/// <summary>
		/// An identifier for the marketplace in which the resource operates
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
