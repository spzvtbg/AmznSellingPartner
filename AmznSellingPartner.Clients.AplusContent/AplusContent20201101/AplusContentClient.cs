namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using System;
	using System.Threading.Tasks;

	public class AplusContentClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of all A+ Content documents assigned to a selling partner. This operation returns only the meta
		/// ata of the A+ Content documents. Call the getContentDocument operation to get the actual contents of the A+ Co
		/// tent documents.  **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |
		/// efault| 10 | 10 | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header
		/// returns the usage plan rate limits that were applied to the requested operation. Rate limits for some selling
		/// artners will vary from the default rate and burst shown in the table above. For more information, see "Usage P
		/// ans and Rate Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<SearchContentDocumentsGetResponse> SearchContentDocumentsAsync(SearchContentDocumentsGetRequest request)
		    => await this.SendAsync<SearchContentDocumentsGetResponse>(request);

		/// <summary>
		/// Creates a new A+ Content document.  **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---
		/// | ---- | ---- | |Default| 10 | 10 | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Li
		/// it response header returns the usage plan rate limits that were applied to the requested operation. Rate limit
		/// for some selling partners will vary from the default rate and burst shown in the table above. For more inform
		/// tion, see "Usage Plans and Rate Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<CreateContentDocumentPostResponse> CreateContentDocumentAsync(CreateContentDocumentPostRequest request)
		    => await this.SendAsync<CreateContentDocumentPostResponse>(request);

		/// <summary>
		/// Returns an A+ Content document, if available.  **Usage Plans:**  | Plan type | Rate (requests per second) | Bu
		/// st | | ---- | ---- | ---- | |Default| 10 | 10 | |Selling partner specific| Variable | Variable |  The x-amzn-R
		/// teLimit-Limit response header returns the usage plan rate limits that were applied to the requested operation.
		/// Rate limits for some selling partners will vary from the default rate and burst shown in the table above. For
		/// ore information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<GetContentDocumentGetResponse> GetContentDocumentAsync(GetContentDocumentGetRequest request)
		    => await this.SendAsync<GetContentDocumentGetResponse>(request);

		/// <summary>
		/// Updates an existing A+ Content document.  **Usage Plans:**  | Plan type | Rate (requests per second) | Burst |
		/// | ---- | ---- | ---- | |Default| 10 | 10 | |Selling partner specific| Variable | Variable |  The x-amzn-RateLi
		/// it-Limit response header returns the usage plan rate limits that were applied to the requested operation. Rate
		/// limits for some selling partners will vary from the default rate and burst shown in the table above. For more
		/// nformation, see "Usage Plans and Rate Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<UpdateContentDocumentPostResponse> UpdateContentDocumentAsync(UpdateContentDocumentPostRequest request)
		    => await this.SendAsync<UpdateContentDocumentPostResponse>(request);

		/// <summary>
		/// Returns a list of ASINs related to the specified A+ Content document, if available. If you do not include the
		/// sinSet parameter, the operation returns all ASINs related to the content document.  **Usage Plans:**  | Plan t
		/// pe | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 10 | |Selling partner specific
		/// Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the usage plan rate limits that wer
		/// applied to the requested operation. Rate limits for some selling partners will vary from the default rate and
		/// burst shown in the table above. For more information, see "Usage Plans and Rate Limits" in the Selling Partner
		/// API documentation.
		/// </summary>
		public async Task<ListContentDocumentAsinRelationsGetResponse> ListContentDocumentAsinRelationsAsync(ListContentDocumentAsinRelationsGetRequest request)
		    => await this.SendAsync<ListContentDocumentAsinRelationsGetResponse>(request);

		/// <summary>
		/// Replaces all ASINs related to the specified A+ Content document, if available. This may add or remove ASINs, d
		/// pending on the current set of related ASINs. Removing an ASIN has the side effect of suspending the content do
		/// ument from that ASIN.  **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | --
		/// - | |Default| 10 | 10 | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response
		/// eader returns the usage plan rate limits that were applied to the requested operation. Rate limits for some se
		/// ling partners will vary from the default rate and burst shown in the table above. For more information, see "U
		/// age Plans and Rate Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<PostContentDocumentAsinRelationsPostResponse> PostContentDocumentAsinRelationsAsync(PostContentDocumentAsinRelationsPostRequest request)
		    => await this.SendAsync<PostContentDocumentAsinRelationsPostResponse>(request);

		/// <summary>
		/// Checks if the A+ Content document is valid for use on a set of ASINs.  **Usage Plans:**  | Plan type | Rate (r
		/// quests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 10 | |Selling partner specific| Variable |
		/// ariable |  The x-amzn-RateLimit-Limit response header returns the usage plan rate limits that were applied to
		/// he requested operation. Rate limits for some selling partners will vary from the default rate and burst shown
		/// n the table above. For more information, see "Usage Plans and Rate Limits" in the Selling Partner API document
		/// tion.
		/// </summary>
		public async Task<ValidateContentDocumentAsinRelationsPostResponse> ValidateContentDocumentAsinRelationsAsync(ValidateContentDocumentAsinRelationsPostRequest request)
		    => await this.SendAsync<ValidateContentDocumentAsinRelationsPostResponse>(request);

		/// <summary>
		/// Searches for A+ Content publishing records, if available.  **Usage Plans:**  | Plan type | Rate (requests per
		/// econd) | Burst | | ---- | ---- | ---- | |Default| 10 | 10 | |Selling partner specific| Variable | Variable |
		/// he x-amzn-RateLimit-Limit response header returns the usage plan rate limits that were applied to the requeste
		/// operation. Rate limits for some selling partners will vary from the default rate and burst shown in the table
		/// above. For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<SearchContentPublishRecordsGetResponse> SearchContentPublishRecordsAsync(SearchContentPublishRecordsGetRequest request)
		    => await this.SendAsync<SearchContentPublishRecordsGetResponse>(request);

		/// <summary>
		/// Submits an A+ Content document for review, approval, and publishing.  **Usage Plans:**  | Plan type | Rate (re
		/// uests per second) | Burst | | ---- | ---- | ---- | |Default| 10 | 10 | |Selling partner specific| Variable | V
		/// riable |  The x-amzn-RateLimit-Limit response header returns the usage plan rate limits that were applied to t
		/// e requested operation. Rate limits for some selling partners will vary from the default rate and burst shown i
		/// the table above. For more information, see "Usage Plans and Rate Limits" in the Selling Partner API documenta
		/// ion.
		/// </summary>
		public async Task<PostContentDocumentApprovalSubmissionPostResponse> PostContentDocumentApprovalSubmissionAsync(PostContentDocumentApprovalSubmissionPostRequest request)
		    => await this.SendAsync<PostContentDocumentApprovalSubmissionPostResponse>(request);

		/// <summary>
		/// Submits a request to suspend visible A+ Content. This neither deletes the content document nor the ASIN relati
		/// ns.  **Usage Plans:**  | Plan type | Rate (requests per second) | Burst | | ---- | ---- | ---- | |Default| 10
		/// 10 | |Selling partner specific| Variable | Variable |  The x-amzn-RateLimit-Limit response header returns the
		/// usage plan rate limits that were applied to the requested operation. Rate limits for some selling partners wil
		/// vary from the default rate and burst shown in the table above. For more information, see "Usage Plans and Rat
		/// Limits" in the Selling Partner API documentation.
		/// </summary>
		public async Task<PostContentDocumentSuspendSubmissionPostResponse> PostContentDocumentSuspendSubmissionAsync(PostContentDocumentSuspendSubmissionPostRequest request)
		    => await this.SendAsync<PostContentDocumentSuspendSubmissionPostResponse>(request);
	}
}
