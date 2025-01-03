namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createProductReviewAndSellerFeedbackSolicitation operation
	/// </summary>
	public class CreateProductReviewAndSellerFeedbackSolicitationResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
