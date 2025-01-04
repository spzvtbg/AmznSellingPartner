namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using System;
	using System.Threading.Tasks;

	public class VendorDFSandboxtransactionstatusClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns the status of the transaction indicated by the specified transactionId. If the transaction was
		/// successful, also returns the requested test order data.
		/// </summary>
		public async Task<GetOrderScenariosGetResponse> GetOrderScenariosAsync(GetOrderScenariosGetRequest request)
		    => await this.SendAsync<GetOrderScenariosGetResponse>(request);
	}
}
