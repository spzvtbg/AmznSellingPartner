namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using System;
    using System.Threading.Tasks;

    public class AmznAplusClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns a list of all A+ Content documents assigned to a selling partner. This operation returns
        /// only the metadata of the A+ Content documents. Call the getContentDocument operation to get
        /// the actual contents of the A+ Content documents.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznSearchContentDocumentsResponse> SearchContentDocumentsAsync(AmznSearchContentDocumentsRequest request)
            => await SendAsync<AmznSearchContentDocumentsResponse>(request);

        /// <summary>
        /// Creates a new A+ Content document.  **Usage Plan:**  | Rate (requests per second) | Burst |
        /// | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The table above
        /// indicates the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may see higher rate and burst values than those shown here.
        /// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https:/
        /// /developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateContentDocumentResponse> CreateContentDocumentAsync(AmznCreateContentDocumentRequest request)
            => await SendAsync<AmznCreateContentDocumentResponse>(request);

        /// <summary>
        /// Returns an A+ Content document, if available.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznGetContentDocumentResponse> GetContentDocumentAsync(AmznGetContentDocumentRequest request)
            => await SendAsync<AmznGetContentDocumentResponse>(request);

        /// <summary>
        /// Updates an existing A+ Content document.  **Usage Plan:**  | Rate (requests per second) | Burst
        /// | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The table above
        /// indicates the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may see higher rate and burst values than those shown here.
        /// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https:/
        /// /developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznUpdateContentDocumentResponse> UpdateContentDocumentAsync(AmznUpdateContentDocumentRequest request)
            => await SendAsync<AmznUpdateContentDocumentResponse>(request);

        /// <summary>
        /// Returns a list of ASINs related to the specified A+ Content document, if available. If you
        /// do not include the `asinSet` parameter, the operation returns all ASINs related to the content
        /// document.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10
        /// |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
        /// applied to the requested operation, when available. The table above indicates the default rate
        /// and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may see higher rate and burst values than those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon
        /// .com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListContentDocumentAsinRelationsResponse> ListContentDocumentAsinRelationsAsync(AmznListContentDocumentAsinRelationsRequest request)
            => await SendAsync<AmznListContentDocumentAsinRelationsResponse>(request);

        /// <summary>
        /// Replaces all ASINs related to the specified A+ Content document, if available. This may add
        /// or remove ASINs, depending on the current set of related ASINs. Removing an ASIN has the side
        /// effect of suspending the content document from that ASIN.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznPostContentDocumentAsinRelationsResponse> PostContentDocumentAsinRelationsAsync(AmznPostContentDocumentAsinRelationsRequest request)
            => await SendAsync<AmznPostContentDocumentAsinRelationsResponse>(request);

        /// <summary>
        /// Checks if the A+ Content document is valid for use on a set of ASINs.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznValidateContentDocumentAsinRelationsResponse> ValidateContentDocumentAsinRelationsAsync(AmznValidateContentDocumentAsinRelationsRequest request)
            => await SendAsync<AmznValidateContentDocumentAsinRelationsResponse>(request);

        /// <summary>
        /// Searches for A+ Content publishing records, if available.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznSearchContentPublishRecordsResponse> SearchContentPublishRecordsAsync(AmznSearchContentPublishRecordsRequest request)
            => await SendAsync<AmznSearchContentPublishRecordsResponse>(request);

        /// <summary>
        /// Submits an A+ Content document for review, approval, and publishing.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznPostContentDocumentApprovalSubmissionResponse> PostContentDocumentApprovalSubmissionAsync(AmznPostContentDocumentApprovalSubmissionRequest request)
            => await SendAsync<AmznPostContentDocumentApprovalSubmissionResponse>(request);

        /// <summary>
        /// Submits a request to suspend visible A+ Content. This neither deletes the content document
        /// nor the ASIN relations.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon
        /// .com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznPostContentDocumentSuspendSubmissionResponse> PostContentDocumentSuspendSubmissionAsync(AmznPostContentDocumentSuspendSubmissionRequest request)
            => await SendAsync<AmznPostContentDocumentSuspendSubmissionResponse>(request);
    }
}
