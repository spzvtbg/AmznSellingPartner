namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using System;
	using System.Threading.Tasks;

	public class DefinitionsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Search for and return a list of Amazon product types that have definitions available
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 5 | 10
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the usa
		/// e plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<SearchDefinitionsProductTypesGetResponse> SearchDefinitionsProductTypesAsync(SearchDefinitionsProductTypesGetRequest request)
		    => await this.SendAsync<SearchDefinitionsProductTypesGetResponse>(request);

		/// <summary>
		/// Retrieve an Amazon product type definition
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 5 | 10
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the usa
		/// e plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<GetDefinitionsProductTypeGetResponse> GetDefinitionsProductTypeAsync(GetDefinitionsProductTypeGetRequest request)
		    => await this.SendAsync<GetDefinitionsProductTypeGetResponse>(request);
	}
}
