namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpPost("/service/v1/reservation")]
	public class AmznCreateReservationRequest : BaseHttpRequest
	{
		/// <summary>
		/// Reservation details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateReservationRequest Body { get; set; } 

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 
	}
}
