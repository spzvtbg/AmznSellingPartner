namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using System;
	using System.Threading.Tasks;

	public class MessagingClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns a list of message types that are available for an order that you specify. A message type is represented
		/// by an actions object, which contains a path and query parameter(s). You can use the path and parameter(s)
		/// to call an operation that sends a message.  **Usage Plan:**  | Rate (requests per second) | Burst | |
		/// ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits
		/// for the operation, when available. The preceding table contains the default rate and burst values for
		/// this operation. Selling partners whose business demands require higher throughput might have higher rate
		/// and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetMessagingActionsForOrderGetResponse> GetMessagingActionsForOrderAsync(GetMessagingActionsForOrderGetRequest request)
		    => await SendAsync<GetMessagingActionsForOrderGetResponse>(request);

		/// <summary>
		/// Sends a message asking a buyer to provide or verify customization details such as name spelling, images,
		/// initials, etc.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The
		/// `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when
		/// available. The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput might have higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmCustomizationDetailsPostResponse> ConfirmCustomizationDetailsAsync(ConfirmCustomizationDetailsPostRequest request)
		    => await SendAsync<ConfirmCustomizationDetailsPostResponse>(request);

		/// <summary>
		/// Sends a message to a buyer to arrange a delivery or to confirm contact information for making a delivery.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header contains the usage plan rate limits for the operation, when available. The preceding
		/// table contains the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput might have higher rate and burst values than those shown here. For
		/// more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/do
		/// cs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateConfirmDeliveryDetailsPostResponse> CreateConfirmDeliveryDetailsAsync(CreateConfirmDeliveryDetailsPostRequest request)
		    => await SendAsync<CreateConfirmDeliveryDetailsPostResponse>(request);

		/// <summary>
		/// Sends a critical message that contains documents that a seller is legally obligated to provide to the
		/// buyer. This message should only be used to deliver documents that are required by law.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response
		/// header contains the usage plan rate limits for the operation, when available. The preceding table contains
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput might have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and
		/// -rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateLegalDisclosurePostResponse> CreateLegalDisclosureAsync(CreateLegalDisclosurePostRequest request)
		    => await SendAsync<CreateLegalDisclosurePostResponse>(request);

		/// <summary>
		/// Sends a non-critical message that asks a buyer to remove their negative feedback. This message should
		/// only be sent after the seller has resolved the buyer's problem.  **Usage Plan:**  | Rate (requests per
		/// second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the
		/// usage plan rate limits for the operation, when available. The preceding table contains the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput
		/// might have higher rate and burst values than those shown here. For more information, refer to [Usage
		/// Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
		/// the-sp-api).
		/// </summary>
		public async Task<CreateNegativeFeedbackRemovalPostResponse> CreateNegativeFeedbackRemovalAsync(CreateNegativeFeedbackRemovalPostRequest request)
		    => await SendAsync<CreateNegativeFeedbackRemovalPostResponse>(request);

		/// <summary>
		/// Sends a message to ask a buyer an order-related question prior to shipping their order.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response
		/// header contains the usage plan rate limits for the operation, when available. The preceding table contains
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput might have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and
		/// -rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateConfirmOrderDetailsPostResponse> CreateConfirmOrderDetailsAsync(CreateConfirmOrderDetailsPostRequest request)
		    => await SendAsync<CreateConfirmOrderDetailsPostResponse>(request);

		/// <summary>
		/// Sends a message to contact a Home Service customer to arrange a service call or to gather information
		/// prior to a service call.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1
		/// | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation,
		/// when available. The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput might have higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateConfirmServiceDetailsPostResponse> CreateConfirmServiceDetailsAsync(CreateConfirmServiceDetailsPostRequest request)
		    => await SendAsync<CreateConfirmServiceDetailsPostResponse>(request);

		/// <summary>
		/// Sends a message to a buyer to provide details about an Amazon Motors order. This message can only be
		/// sent by Amazon Motors sellers.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the
		/// operation, when available. The preceding table contains the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput might have higher rate and burst values
		/// than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://develope
		/// r-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateAmazonMotorsPostResponse> CreateAmazonMotorsAsync(CreateAmazonMotorsPostRequest request)
		    => await SendAsync<CreateAmazonMotorsPostResponse>(request);

		/// <summary>
		/// Sends a message to a buyer to provide details about warranty information on a purchase in their order.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header contains the usage plan rate limits for the operation, when available. The preceding
		/// table contains the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput might have higher rate and burst values than those shown here. For
		/// more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/do
		/// cs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateWarrantyPostResponse> CreateWarrantyAsync(CreateWarrantyPostRequest request)
		    => await SendAsync<CreateWarrantyPostResponse>(request);

		/// <summary>
		/// Returns a response containing attributes related to an order. This includes buyer preferences.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |
		/// </summary>
		public async Task<GetAttributesGetResponse> GetAttributesAsync(GetAttributesGetRequest request)
		    => await SendAsync<GetAttributesGetResponse>(request);

		/// <summary>
		/// Sends a buyer a message to share a digital access key that is required to utilize digital content in
		/// their order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The
		/// `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when
		/// available. The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput might have higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateDigitalAccessKeyPostResponse> CreateDigitalAccessKeyAsync(CreateDigitalAccessKeyPostRequest request)
		    => await SendAsync<CreateDigitalAccessKeyPostResponse>(request);

		/// <summary>
		/// Sends a critical message to a buyer that an unexpected problem was encountered affecting the completion
		/// of the order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The
		/// `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when
		/// available. The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput might have higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateUnexpectedProblemPostResponse> CreateUnexpectedProblemAsync(CreateUnexpectedProblemPostRequest request)
		    => await SendAsync<CreateUnexpectedProblemPostResponse>(request);

		/// <summary>
		/// Sends a message providing the buyer an invoice
		/// </summary>
		public async Task<SendInvoicePostResponse> SendInvoiceAsync(SendInvoicePostRequest request)
		    => await SendAsync<SendInvoicePostResponse>(request);
	}
}
