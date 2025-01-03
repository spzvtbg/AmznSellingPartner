namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/directFulfillment/shipping/2021-12-28/containerLabel")]
	public class CreateContainerLabelPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Request body containing the container label data
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateContainerLabelRequest Body { get; set; }
	}
}
