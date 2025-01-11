namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpPut("/service/v1/reservation/{reservationId}")]
	public class AmznUpdateReservationRequest : BaseHttpRequest
	{
		/// <summary>
		/// Reservation Identifier
		/// </summary>
		[InPath("reservationId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string ReservationId { get; set; } 

		/// <summary>
		/// Reservation details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public UpdateReservationRequest Body { get; set; } 

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 
	}
}
