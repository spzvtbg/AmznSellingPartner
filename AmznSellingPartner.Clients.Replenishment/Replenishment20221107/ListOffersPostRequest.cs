namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/replenishment/2022-11-07/offers/search")]
	public class ListOffersPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `listOffers` operation.
		/// </summary>
		[InBody("body")]
		public ListOffersRequest Body { get; set; } 
	}
}
