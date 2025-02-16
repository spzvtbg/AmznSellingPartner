namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
    using System;
    using System.Threading.Tasks;

    public class AmznVendorClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Submits a request to generate test order data for Vendor Direct Fulfillment API entities.
        /// </summary>
        public async Task<AmznGenerateOrderScenariosResponse> GenerateOrderScenariosAsync(AmznGenerateOrderScenariosRequest request)
            => await SendAsync<AmznGenerateOrderScenariosResponse>(request);

        /// <summary>
        /// Returns the status of the transaction indicated by the specified transactionId. If the transaction
        /// was successful, also returns the requested test order data.
        /// </summary>
        public async Task<AmznGetOrderScenariosResponse> GetOrderScenariosAsync(AmznGetOrderScenariosRequest request)
            => await SendAsync<AmznGetOrderScenariosResponse>(request);
    }
}
