namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/tokens/2021-03-01/restrictedDataToken")]
	public class CreateRestrictedDataTokenPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The restricted data token request details.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateRestrictedDataTokenRequest Body { get; set; }
	}
}
