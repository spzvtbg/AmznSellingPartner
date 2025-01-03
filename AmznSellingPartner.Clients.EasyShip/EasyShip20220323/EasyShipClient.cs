namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using System;
	using System.Threading.Tasks;

	public class EasyShipClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns time slots available for Easy Ship orders to be scheduled based on the package weight and dimensions t
		/// at the seller specifies.  This operation is available for scheduled and unscheduled orders based on marketplac
		/// support. See **Get Time Slots** in the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guid
		/// #marketplace-support-table).  This operation can return time slots that have either pickup or drop-off handove
		/// methods - see **Supported Handover Methods** in the [Marketplace Support Table](doc:easyship-api-v2022-03-23-
		/// se-case-guide#marketplace-support-table).  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | --
		/// - | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were appli
		/// d to the requested operation, when available. The table above indicates the default rate and burst values for
		/// his operation. Selling partners whose business demands require higher throughput may see higher rate and burst
		/// values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner AP
		/// ](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListHandoverSlotsPostResponse> ListHandoverSlotsAsync(ListHandoverSlotsPostRequest request)
		    => await this.SendAsync<ListHandoverSlotsPostResponse>(request);

		/// <summary>
		/// Returns information about a package, including dimensions, weight, time slot information for handover, invoice
		/// and item information, and status.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1
		/// | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to th
		/// requested operation, when available. The table above indicates the default rate and burst values for this ope
		/// ation. Selling partners whose business demands require higher throughput may see higher rate and burst values
		/// han those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:u
		/// age-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetScheduledPackageGetResponse> GetScheduledPackageAsync(GetScheduledPackageGetRequest request)
		    => await this.SendAsync<GetScheduledPackageGetResponse>(request);

		/// <summary>
		/// Updates the time slot for handing over the package indicated by the specified `scheduledPackageId`. You can ge
		/// the new `slotId` value for the time slot by calling the `listHandoverSlots` operation before making another `
		/// atch` call.  See the **Update Package** column in the [Marketplace Support Table](doc:easyship-api-v2022-03-23
		/// use-case-guide#marketplace-support-table) to see which marketplaces this operation is supported in.  **Usage P
		/// an:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available. The ta
		/// le above indicates the default rate and burst values for this operation. Selling partners whose business deman
		/// s require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// ee [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateScheduledPackagesPatchResponse> UpdateScheduledPackagesAsync(UpdateScheduledPackagesPatchRequest request)
		    => await this.SendAsync<UpdateScheduledPackagesPatchResponse>(request);

		/// <summary>
		/// Schedules an Easy Ship order and returns the scheduled package information.  This operation does the following
		/// *  Specifies the time slot and handover method for the order to be scheduled for delivery.  * Updates the Ea
		/// y Ship order status.  * Generates a shipping label and an invoice. Calling `createScheduledPackage` also gener
		/// tes a warranty document if you specify a `SerialNumber` value. To get these documents, see [How to get invoice
		/// shipping label, and warranty documents](doc:easyship-api-v2022-03-23-use-case-guide).  * Shows the status of
		/// asy Ship orders when you call the `getOrders` operation of the Selling Partner API for Orders and examine the
		/// EasyShipShipmentStatus` property in the response body.  See the **Shipping Label**, **Invoice**, and **Warrant
		/// ** columns in the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-
		/// able) to see which documents are supported in each marketplace.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// imits that were applied to the requested operation, when available. The table above indicates the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput may see
		/// higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in
		/// he Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateScheduledPackagePostResponse> CreateScheduledPackageAsync(CreateScheduledPackagePostRequest request)
		    => await this.SendAsync<CreateScheduledPackagePostResponse>(request);

		/// <summary>
		/// This operation automatically schedules a time slot for all specified `amazonOrderId` values and generates the
		/// ssociated shipping labels and compliance documents based on the marketplace. For more information, refer to th
		/// [marketplace support table](https://developer-docs.amazon.com/sp-api/docs/easyship-api-v2022-03-23-use-case-g
		/// ide#marketplace-support-table).  You can optionally assign a `packageDetails` object to input a preferred time
		/// slot for each order in your request. In such cases, Amazon schedules the respective packages using the specifi
		/// d optional settings. If you don't specify a time slot, Amazon assigns the earliest available time slot.   You
		/// an choose PDF or ZPL for your shipping label's file format and Amazon creates the label accordingly.  This ope
		/// ation returns an array that contains the scheduled packages, and a temporary URL that you can use to access a
		/// IP file. The ZIP file includes the generated shipping labels and any other documents that are required for you
		/// marketplace. If an order can't be scheduled, Amazon adds the `rejectedOrders` list in the response. The respo
		/// se contains an entry for each order that could not be processed. Each entry contains an error message that des
		/// ribes the reason for the failure.  The following table contains the supported request and burst maximum rates:
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limi
		/// ` response header returns the usage plan rate limits that are applied to the requested operation, when availab
		/// e. The preceding table contains the default rate and burst values for this operation. Selling partners whose b
		/// siness demands require higher throughput might have higher rate and burst values than those shown here. For mo
		/// e information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateScheduledPackageBulkPostResponse> CreateScheduledPackageBulkAsync(CreateScheduledPackageBulkPostRequest request)
		    => await this.SendAsync<CreateScheduledPackageBulkPostResponse>(request);
	}
}
