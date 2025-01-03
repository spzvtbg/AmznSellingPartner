namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using System;
	using System.Threading.Tasks;

	public class AplusContentClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of all A+ Content documents assigned to a selling partner
		/// This operation returns only the metadata of the A+ Content documents
		/// Call the getContentDocument operation to get the actual contents of the A+ Content documents
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<SearchContentDocumentsGetResponse> SearchContentDocumentsAsync(SearchContentDocumentsGetRequest request)
		    => await this.SendAsync<SearchContentDocumentsGetResponse>(request);

		/// <summary>
		/// Creates a new A+ Content document
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<CreateContentDocumentPostResponse> CreateContentDocumentAsync(CreateContentDocumentPostRequest request)
		    => await this.SendAsync<CreateContentDocumentPostResponse>(request);

		/// <summary>
		/// Returns an A+ Content document, if available
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<GetContentDocumentGetResponse> GetContentDocumentAsync(GetContentDocumentGetRequest request)
		    => await this.SendAsync<GetContentDocumentGetResponse>(request);

		/// <summary>
		/// Updates an existing A+ Content document
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<UpdateContentDocumentPostResponse> UpdateContentDocumentAsync(UpdateContentDocumentPostRequest request)
		    => await this.SendAsync<UpdateContentDocumentPostResponse>(request);

		/// <summary>
		/// Returns a list of ASINs related to the specified A+ Content document, if available
		/// If you do not include the asinSet parameter, the operation returns all ASINs related to the content document
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<ListContentDocumentAsinRelationsGetResponse> ListContentDocumentAsinRelationsAsync(ListContentDocumentAsinRelationsGetRequest request)
		    => await this.SendAsync<ListContentDocumentAsinRelationsGetResponse>(request);

		/// <summary>
		/// Replaces all ASINs related to the specified A+ Content document, if available
		/// This may add or remove ASINs, depending on the current set of related ASINs
		/// Removing an ASIN has the side effect of suspending the content document from that ASIN
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<PostContentDocumentAsinRelationsPostResponse> PostContentDocumentAsinRelationsAsync(PostContentDocumentAsinRelationsPostRequest request)
		    => await this.SendAsync<PostContentDocumentAsinRelationsPostResponse>(request);

		/// <summary>
		/// Checks if the A+ Content document is valid for use on a set of ASINs
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<ValidateContentDocumentAsinRelationsPostResponse> ValidateContentDocumentAsinRelationsAsync(ValidateContentDocumentAsinRelationsPostRequest request)
		    => await this.SendAsync<ValidateContentDocumentAsinRelationsPostResponse>(request);

		/// <summary>
		/// Searches for A+ Content publishing records, if available
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<SearchContentPublishRecordsGetResponse> SearchContentPublishRecordsAsync(SearchContentPublishRecordsGetRequest request)
		    => await this.SendAsync<SearchContentPublishRecordsGetResponse>(request);

		/// <summary>
		/// Submits an A+ Content document for review, approval, and publishing
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<PostContentDocumentApprovalSubmissionPostResponse> PostContentDocumentApprovalSubmissionAsync(PostContentDocumentApprovalSubmissionPostRequest request)
		    => await this.SendAsync<PostContentDocumentApprovalSubmissionPostResponse>(request);

		/// <summary>
		/// Submits a request to suspend visible A+ Content
		/// This neither deletes the content document nor the ASIN relations
		/// **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 1
		/// | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the us
		/// ge plan rate limits that were applied to the requested operation
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above
		/// For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation
		/// </summary>
		public async Task<PostContentDocumentSuspendSubmissionPostResponse> PostContentDocumentSuspendSubmissionAsync(PostContentDocumentSuspendSubmissionPostRequest request)
		    => await this.SendAsync<PostContentDocumentSuspendSubmissionPostResponse>(request);
	}
}
