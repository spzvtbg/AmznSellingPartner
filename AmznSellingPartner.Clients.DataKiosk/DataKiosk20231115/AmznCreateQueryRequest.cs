namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/dataKiosk/2023-11-15/queries")]
	public class AmznCreateQueryRequest : BaseHttpRequest
	{
		/// <summary>
		/// The body of the request.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateQuerySpecification Body { get; set; } 
	}
}
