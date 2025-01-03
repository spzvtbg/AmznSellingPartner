namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpPost("/service/v1/reservation")]
	public class CreateReservationPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Reservation details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateReservationRequest Body { get; set; }

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
