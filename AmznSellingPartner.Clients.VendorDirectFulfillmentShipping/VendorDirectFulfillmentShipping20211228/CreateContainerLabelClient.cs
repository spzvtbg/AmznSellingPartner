namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using System;
	using System.Threading.Tasks;

	public class CreateContainerLabelClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Creates a container (pallet) label for the associated shipment package
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-L
		/// mit` response header returns the usage plan rate limits that were applied to the requested operation, when ava
		/// lable
		/// The preceding table contains the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CreateContainerLabelPostResponse> CreateContainerLabelAsync(CreateContainerLabelPostRequest request)
		    => await this.SendAsync<CreateContainerLabelPostResponse>(request);
	}
}
