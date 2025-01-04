namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using System;
	using System.Threading.Tasks;

	public class SupplySourcesClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// The path to retrieve paginated supply sources.
		/// </summary>
		public async Task<GetSupplySourcesGetResponse> GetSupplySourcesAsync(GetSupplySourcesGetRequest request)
		    => await this.SendAsync<GetSupplySourcesGetResponse>(request);

		/// <summary>
		/// Create a new supply source.
		/// </summary>
		public async Task<CreateSupplySourcePostResponse> CreateSupplySourceAsync(CreateSupplySourcePostRequest request)
		    => await this.SendAsync<CreateSupplySourcePostResponse>(request);

		/// <summary>
		/// Archive a supply source, making it inactive. Cannot be undone.
		/// </summary>
		public async Task<ArchiveSupplySourceDeleteResponse> ArchiveSupplySourceAsync(ArchiveSupplySourceDeleteRequest request)
		    => await this.SendAsync<ArchiveSupplySourceDeleteResponse>(request);

		/// <summary>
		/// Retrieve a supply source.
		/// </summary>
		public async Task<GetSupplySourceGetResponse> GetSupplySourceAsync(GetSupplySourceGetRequest request)
		    => await this.SendAsync<GetSupplySourceGetResponse>(request);

		/// <summary>
		/// Update the configuration and capabilities of a supply source.
		/// </summary>
		public async Task<UpdateSupplySourcePutResponse> UpdateSupplySourceAsync(UpdateSupplySourcePutRequest request)
		    => await this.SendAsync<UpdateSupplySourcePutResponse>(request);

		/// <summary>
		/// Update the status of a supply source.
		/// </summary>
		public async Task<UpdateSupplySourceStatusPutResponse> UpdateSupplySourceStatusAsync(UpdateSupplySourceStatusPutRequest request)
		    => await this.SendAsync<UpdateSupplySourceStatusPutResponse>(request);
	}
}
