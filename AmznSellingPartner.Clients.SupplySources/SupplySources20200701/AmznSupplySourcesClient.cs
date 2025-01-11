namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using System;
	using System.Threading.Tasks;

	public class AmznSupplySourcesClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// The path to retrieve paginated supply sources.
		/// </summary>
		public async Task<AmznGetSupplySourcesResponse> GetSupplySourcesAsync(AmznGetSupplySourcesRequest request)
		    => await SendAsync<AmznGetSupplySourcesResponse>(request);

		/// <summary>
		/// Create a new supply source.
		/// </summary>
		public async Task<AmznCreateSupplySourceResponse> CreateSupplySourceAsync(AmznCreateSupplySourceRequest request)
		    => await SendAsync<AmznCreateSupplySourceResponse>(request);

		/// <summary>
		/// Archive a supply source, making it inactive. Cannot be undone.
		/// </summary>
		public async Task<AmznArchiveSupplySourceResponse> ArchiveSupplySourceAsync(AmznArchiveSupplySourceRequest request)
		    => await SendAsync<AmznArchiveSupplySourceResponse>(request);

		/// <summary>
		/// Retrieve a supply source.
		/// </summary>
		public async Task<AmznGetSupplySourceResponse> GetSupplySourceAsync(AmznGetSupplySourceRequest request)
		    => await SendAsync<AmznGetSupplySourceResponse>(request);

		/// <summary>
		/// Update the configuration and capabilities of a supply source.
		/// </summary>
		public async Task<AmznUpdateSupplySourceResponse> UpdateSupplySourceAsync(AmznUpdateSupplySourceRequest request)
		    => await SendAsync<AmznUpdateSupplySourceResponse>(request);

		/// <summary>
		/// Update the status of a supply source.
		/// </summary>
		public async Task<AmznUpdateSupplySourceStatusResponse> UpdateSupplySourceStatusAsync(AmznUpdateSupplySourceStatusRequest request)
		    => await SendAsync<AmznUpdateSupplySourceStatusResponse>(request);
	}
}
