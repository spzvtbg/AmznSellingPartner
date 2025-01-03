namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using System;
	using System.Threading.Tasks;

	public class VendorDFSandboxClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Submits a request to generate test order data for Vendor Direct Fulfillment API entities.
		/// </summary>
		public async Task<GenerateOrderScenariosPostResponse> GenerateOrderScenariosAsync(GenerateOrderScenariosPostRequest request)
		    => await this.SendAsync<GenerateOrderScenariosPostResponse>(request);
	}
}
