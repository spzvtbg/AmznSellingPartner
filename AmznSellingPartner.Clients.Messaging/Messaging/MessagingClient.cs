namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using System;
	using System.Threading.Tasks;

	public class MessagingClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of message types that are available for an order that you specify. A message type is represente
		/// by an actions object, which contains a path and query parameter(s). You can use the path and parameter(s) to
		/// all an operation that sends a message.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation
		/// when available. The preceding table contains the default rate and burst values for this operation. Selling pa
		/// tners whose business demands require higher throughput might have higher rate and burst values than those show
		/// here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/d
		/// cs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetMessagingActionsForOrderGetResponse> GetMessagingActionsForOrderAsync(GetMessagingActionsForOrderGetRequest request)
		    => await this.SendAsync<GetMessagingActionsForOrderGetResponse>(request);

		/// <summary>
		/// Sends a message asking a buyer to provide or verify customization details such as name spelling, images, initi
		/// ls, etc.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateL
		/// mit-Limit` response header contains the usage plan rate limits for the operation, when available. The precedin
		/// table contains the default rate and burst values for this operation. Selling partners whose business demands
		/// equire higher throughput might have higher rate and burst values than those shown here. For more information,
		/// efer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// -in-the-sp-api).
		/// </summary>
		public async Task<ConfirmCustomizationDetailsPostResponse> ConfirmCustomizationDetailsAsync(ConfirmCustomizationDetailsPostRequest request)
		    => await this.SendAsync<ConfirmCustomizationDetailsPostResponse>(request);

		/// <summary>
		/// Sends a message to a buyer to arrange a delivery or to confirm contact information for making a delivery.  **U
		/// age Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` re
		/// ponse header contains the usage plan rate limits for the operation, when available. The preceding table contai
		/// s the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput might have higher rate and burst values than those shown here. For more information, refer to [Usag
		/// Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-ap
		/// ).
		/// </summary>
		public async Task<CreateConfirmDeliveryDetailsPostResponse> CreateConfirmDeliveryDetailsAsync(CreateConfirmDeliveryDetailsPostRequest request)
		    => await this.SendAsync<CreateConfirmDeliveryDetailsPostResponse>(request);

		/// <summary>
		/// Sends a critical message that contains documents that a seller is legally obligated to provide to the buyer. T
		/// is message should only be used to deliver documents that are required by law.  **Usage Plan:**  | Rate (reques
		/// s per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the u
		/// age plan rate limits for the operation, when available. The preceding table contains the default rate and burs
		/// values for this operation. Selling partners whose business demands require higher throughput might have highe
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits](htt
		/// s://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateLegalDisclosurePostResponse> CreateLegalDisclosureAsync(CreateLegalDisclosurePostRequest request)
		    => await this.SendAsync<CreateLegalDisclosurePostResponse>(request);

		/// <summary>
		/// Sends a non-critical message that asks a buyer to remove their negative feedback. This message should only be
		/// ent after the seller has resolved the buyer's problem.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate limits f
		/// r the operation, when available. The preceding table contains the default rate and burst values for this opera
		/// ion. Selling partners whose business demands require higher throughput might have higher rate and burst values
		/// than those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.ama
		/// on.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateNegativeFeedbackRemovalPostResponse> CreateNegativeFeedbackRemovalAsync(CreateNegativeFeedbackRemovalPostRequest request)
		    => await this.SendAsync<CreateNegativeFeedbackRemovalPostResponse>(request);

		/// <summary>
		/// Sends a message to ask a buyer an order-related question prior to shipping their order.  **Usage Plan:**  | Ra
		/// e (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header cont
		/// ins the usage plan rate limits for the operation, when available. The preceding table contains the default rat
		/// and burst values for this operation. Selling partners whose business demands require higher throughput might
		/// ave higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate L
		/// mits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateConfirmOrderDetailsPostResponse> CreateConfirmOrderDetailsAsync(CreateConfirmOrderDetailsPostRequest request)
		    => await this.SendAsync<CreateConfirmOrderDetailsPostResponse>(request);

		/// <summary>
		/// Sends a message to contact a Home Service customer to arrange a service call or to gather information prior to
		/// a service call.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amz
		/// -RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available. The p
		/// eceding table contains the default rate and burst values for this operation. Selling partners whose business d
		/// mands require higher throughput might have higher rate and burst values than those shown here. For more inform
		/// tion, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
		/// -limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateConfirmServiceDetailsPostResponse> CreateConfirmServiceDetailsAsync(CreateConfirmServiceDetailsPostRequest request)
		    => await this.SendAsync<CreateConfirmServiceDetailsPostResponse>(request);

		/// <summary>
		/// Sends a message to a buyer to provide details about an Amazon Motors order. This message can only be sent by A
		/// azon Motors sellers.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `
		/// -amzn-RateLimit-Limit` response header contains the usage plan rate limits for the operation, when available.
		/// he preceding table contains the default rate and burst values for this operation. Selling partners whose busin
		/// ss demands require higher throughput might have higher rate and burst values than those shown here. For more i
		/// formation, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-an
		/// -rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateAmazonMotorsPostResponse> CreateAmazonMotorsAsync(CreateAmazonMotorsPostRequest request)
		    => await this.SendAsync<CreateAmazonMotorsPostResponse>(request);

		/// <summary>
		/// Sends a message to a buyer to provide details about warranty information on a purchase in their order.  **Usag
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` respo
		/// se header contains the usage plan rate limits for the operation, when available. The preceding table contains
		/// he default rate and burst values for this operation. Selling partners whose business demands require higher th
		/// oughput might have higher rate and burst values than those shown here. For more information, refer to [Usage P
		/// ans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateWarrantyPostResponse> CreateWarrantyAsync(CreateWarrantyPostRequest request)
		    => await this.SendAsync<CreateWarrantyPostResponse>(request);

		/// <summary>
		/// Returns a response containing attributes related to an order. This includes buyer preferences.  **Usage Plan:*
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |
		/// </summary>
		public async Task<GetAttributesGetResponse> GetAttributesAsync(GetAttributesGetRequest request)
		    => await this.SendAsync<GetAttributesGetResponse>(request);

		/// <summary>
		/// Sends a buyer a message to share a digital access key that is required to utilize digital content in their ord
		/// r.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-L
		/// mit` response header contains the usage plan rate limits for the operation, when available. The preceding tabl
		/// contains the default rate and burst values for this operation. Selling partners whose business demands requir
		/// higher throughput might have higher rate and burst values than those shown here. For more information, refer
		/// o [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-t
		/// e-sp-api).
		/// </summary>
		public async Task<CreateDigitalAccessKeyPostResponse> CreateDigitalAccessKeyAsync(CreateDigitalAccessKeyPostRequest request)
		    => await this.SendAsync<CreateDigitalAccessKeyPostResponse>(request);

		/// <summary>
		/// Sends a critical message to a buyer that an unexpected problem was encountered affecting the completion of the
		/// order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLim
		/// t-Limit` response header contains the usage plan rate limits for the operation, when available. The preceding
		/// able contains the default rate and burst values for this operation. Selling partners whose business demands re
		/// uire higher throughput might have higher rate and burst values than those shown here. For more information, re
		/// er to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-
		/// n-the-sp-api).
		/// </summary>
		public async Task<CreateUnexpectedProblemPostResponse> CreateUnexpectedProblemAsync(CreateUnexpectedProblemPostRequest request)
		    => await this.SendAsync<CreateUnexpectedProblemPostResponse>(request);

		/// <summary>
		/// Sends a message providing the buyer an invoice
		/// </summary>
		public async Task<SendInvoicePostResponse> SendInvoiceAsync(SendInvoicePostRequest request)
		    => await this.SendAsync<SendInvoicePostResponse>(request);
	}
}
