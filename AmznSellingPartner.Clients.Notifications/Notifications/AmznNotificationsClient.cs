namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using System;
	using System.Threading.Tasks;

	public class AmznNotificationsClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns information about subscription of the specified notification type and payload version.
		/// `payloadVersion` is an optional parameter. When `payloadVersion` is not provided, it will return
		/// latest payload version subscription's information. You can use this API to get subscription
		/// information when you do not have a subscription identifier.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may observe higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
		/// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
		/// the-sp-api).
		/// </summary>
		public async Task<AmznGetSubscriptionResponse> GetSubscriptionAsync(AmznGetSubscriptionRequest request)
		    => await SendAsync<AmznGetSubscriptionResponse>(request);

		/// <summary>
		/// Creates a subscription for the specified notification type to be delivered to the specified
		/// destination. Before you can subscribe, you must first create the destination by calling the
		/// `createDestination` operation. In cases where the specified notification type supports multiple
		/// payload versions, you can utilize this API to subscribe to a different payload version if you
		/// already have an existing subscription for a different payload version.  **Usage Plan:**  |
		/// Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznCreateSubscriptionResponse> CreateSubscriptionAsync(AmznCreateSubscriptionRequest request)
		    => await SendAsync<AmznCreateSubscriptionResponse>(request);

		/// <summary>
		/// Deletes the subscription indicated by the subscription identifier and notification type that
		/// you specify. The subscription identifier can be for any subscription associated with your application.
		/// After you successfully call this operation, notifications will stop being sent for the associated
		/// subscription. The `deleteSubscriptionById` operation is grantless. For more information, refer
		/// to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznDeleteSubscriptionByIdResponse> DeleteSubscriptionByIdAsync(AmznDeleteSubscriptionByIdRequest request)
		    => await SendAsync<AmznDeleteSubscriptionByIdResponse>(request);

		/// <summary>
		/// Returns information about a subscription for the specified notification type. The `getSubscriptionById`
		/// operation is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetSubscriptionByIdResponse> GetSubscriptionByIdAsync(AmznGetSubscriptionByIdRequest request)
		    => await SendAsync<AmznGetSubscriptionByIdResponse>(request);

		/// <summary>
		/// Returns information about all destinations. The `getDestinations` operation is grantless. For
		/// more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetDestinationsResponse> GetDestinationsAsync(AmznGetDestinationsRequest request)
		    => await SendAsync<AmznGetDestinationsResponse>(request);

		/// <summary>
		/// Creates a destination resource to receive notifications. The `createDestination` operation
		/// is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznCreateDestinationResponse> CreateDestinationAsync(AmznCreateDestinationRequest request)
		    => await SendAsync<AmznCreateDestinationResponse>(request);

		/// <summary>
		/// Deletes the destination that you specify. The `deleteDestination` operation is grantless. For
		/// more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznDeleteDestinationResponse> DeleteDestinationAsync(AmznDeleteDestinationRequest request)
		    => await SendAsync<AmznDeleteDestinationResponse>(request);

		/// <summary>
		/// Returns information about the destination that you specify. The `getDestination` operation
		/// is grantless. For more information, refer to [Grantless operations](https://developer-docs.amazon.com/sp-api/docs/grantless-operations).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may observe higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetDestinationResponse> GetDestinationAsync(AmznGetDestinationRequest request)
		    => await SendAsync<AmznGetDestinationResponse>(request);
	}
}
