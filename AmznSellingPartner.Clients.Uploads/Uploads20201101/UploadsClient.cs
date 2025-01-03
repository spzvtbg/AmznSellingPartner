namespace AmznSellingPartner.Clients.Uploads.Uploads20201101
{
	using System;
	using System.Threading.Tasks;

	public class UploadsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Creates an upload destination, returning the information required to upload a file to the destination and to p
		/// ogrammatically access the file
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-L
		/// mit` response header returns the usage plan rate limits that were applied to the requested operation, when ava
		/// lable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CreateUploadDestinationForResourcePostResponse> CreateUploadDestinationForResourceAsync(CreateUploadDestinationForResourcePostRequest request)
		    => await this.SendAsync<CreateUploadDestinationForResourcePostResponse>(request);
	}
}
