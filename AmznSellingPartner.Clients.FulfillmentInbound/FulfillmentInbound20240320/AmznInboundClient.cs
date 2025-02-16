namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using System;
    using System.Threading.Tasks;

    public class AmznInboundClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Provides a list of inbound plans with minimal information.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznListInboundPlansResponse> ListInboundPlansAsync(AmznListInboundPlansRequest request)
            => await SendAsync<AmznListInboundPlansResponse>(request);

        /// <summary>
        /// Creates an inbound plan. An inbound plan contains all the necessary information to send shipments
        /// into Amazon's fufillment network.  **Usage Plan:**  | Rate (requests per second) | Burst |
        /// | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
        /// rate limits that were applied to the requested operation, when available. The preceding table
        /// contains the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may have higher rate and burst values than those shown here.
        /// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](ht
        /// tps://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateInboundPlanResponse> CreateInboundPlanAsync(AmznCreateInboundPlanRequest request)
            => await SendAsync<AmznCreateInboundPlanResponse>(request);

        /// <summary>
        /// Fetches the top level information about an inbound plan.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznGetInboundPlanResponse> GetInboundPlanAsync(AmznGetInboundPlanRequest request)
            => await SendAsync<AmznGetInboundPlanResponse>(request);

        /// <summary>
        /// Provides a paginated list of box packages in an inbound plan.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznListInboundPlanBoxesResponse> ListInboundPlanBoxesAsync(AmznListInboundPlanBoxesRequest request)
            => await SendAsync<AmznListInboundPlanBoxesResponse>(request);

        /// <summary>
        /// Cancels an Inbound Plan. Charges may apply if the cancellation is performed outside of a void
        /// window. The window for Amazon Partnered Carriers is 24 hours for Small Parcel Delivery (SPD)
        /// and one hour for Less-Than-Truckload (LTL) carrier shipments.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznCancelInboundPlanResponse> CancelInboundPlanAsync(AmznCancelInboundPlanRequest request)
            => await SendAsync<AmznCancelInboundPlanResponse>(request);

        /// <summary>
        /// Provides a paginated list of item packages in an inbound plan.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznListInboundPlanItemsResponse> ListInboundPlanItemsAsync(AmznListInboundPlanItemsRequest request)
            => await SendAsync<AmznListInboundPlanItemsResponse>(request);

        /// <summary>
        /// Updates the name of an existing inbound plan.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// preceding table contains the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may have higher rate and burst values than
        /// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznUpdateInboundPlanNameResponse> UpdateInboundPlanNameAsync(AmznUpdateInboundPlanNameRequest request)
            => await SendAsync<AmznUpdateInboundPlanNameResponse>(request);

        /// <summary>
        /// Retrieves a page of boxes from a given packing group. These boxes were previously provided
        /// through the `setPackingInformation` operation. This API is used for workflows where boxes are
        /// packed before Amazon determines shipment splits.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// preceding table contains the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may have higher rate and burst values than
        /// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznListPackingGroupBoxesResponse> ListPackingGroupBoxesAsync(AmznListPackingGroupBoxesRequest request)
            => await SendAsync<AmznListPackingGroupBoxesResponse>(request);

        /// <summary>
        /// Retrieves a page of items in a given packing group. Packing options must first be generated
        /// by the corresponding operation before packing group items can be listed.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListPackingGroupItemsResponse> ListPackingGroupItemsAsync(AmznListPackingGroupItemsRequest request)
            => await SendAsync<AmznListPackingGroupItemsResponse>(request);

        /// <summary>
        /// Sets packing information for an inbound plan. This should be called after an inbound plan is
        /// created to populate the box level information required for planning and transportation estimates.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznSetPackingInformationResponse> SetPackingInformationAsync(AmznSetPackingInformationRequest request)
            => await SendAsync<AmznSetPackingInformationResponse>(request);

        /// <summary>
        /// Retrieves a list of all packing options for an inbound plan. Packing options must first be
        /// generated by the corresponding operation before becoming available.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListPackingOptionsResponse> ListPackingOptionsAsync(AmznListPackingOptionsRequest request)
            => await SendAsync<AmznListPackingOptionsResponse>(request);

        /// <summary>
        /// Generates available packing options for the inbound plan.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznGeneratePackingOptionsResponse> GeneratePackingOptionsAsync(AmznGeneratePackingOptionsRequest request)
            => await SendAsync<AmznGeneratePackingOptionsResponse>(request);

        /// <summary>
        /// Confirms the packing option for an inbound plan.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The preceding
        /// table contains the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may have higher rate and burst values than those
        /// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznConfirmPackingOptionResponse> ConfirmPackingOptionAsync(AmznConfirmPackingOptionRequest request)
            => await SendAsync<AmznConfirmPackingOptionResponse>(request);

        /// <summary>
        /// Provides a paginated list of pallet packages in an inbound plan. An inbound plan will have
        /// pallets when the related details are provided after generating Less-Than-Truckload (LTL) carrier
        /// shipments.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 6
        /// |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
        /// applied to the requested operation, when available. The preceding table contains the default
        /// rate and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may have higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListInboundPlanPalletsResponse> ListInboundPlanPalletsAsync(AmznListInboundPlanPalletsRequest request)
            => await SendAsync<AmznListInboundPlanPalletsResponse>(request);

        /// <summary>
        /// Provides a list of all placement options for an inbound plan. Placement options must first
        /// be generated by the corresponding operation before becoming available.  **Usage Plan:**  |
        /// Rate (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListPlacementOptionsResponse> ListPlacementOptionsAsync(AmznListPlacementOptionsRequest request)
            => await SendAsync<AmznListPlacementOptionsResponse>(request);

        /// <summary>
        /// Generates placement options for the inbound plan.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The preceding
        /// table contains the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may have higher rate and burst values than those
        /// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznGeneratePlacementOptionsResponse> GeneratePlacementOptionsAsync(AmznGeneratePlacementOptionsRequest request)
            => await SendAsync<AmznGeneratePlacementOptionsResponse>(request);

        /// <summary>
        /// Confirms the placement option for an inbound plan. Once confirmed, it cannot be changed for
        /// the Inbound Plan.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- |
        /// | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The preceding table contains
        /// the default rate and burst values for this operation. Selling partners whose business demands
        /// require higher throughput may have higher rate and burst values than those shown here. For
        /// more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
        /// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznConfirmPlacementOptionResponse> ConfirmPlacementOptionAsync(AmznConfirmPlacementOptionRequest request)
            => await SendAsync<AmznConfirmPlacementOptionResponse>(request);

        /// <summary>
        /// Provides the full details for a specific shipment within an inbound plan. The `transportationOptionId`
        /// inside `acceptedTransportationSelection` can be used to retrieve the transportation details
        /// for the shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- |
        /// | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The preceding table contains
        /// the default rate and burst values for this operation. Selling partners whose business demands
        /// require higher throughput may have higher rate and burst values than those shown here. For
        /// more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
        /// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetShipmentResponse> GetShipmentAsync(AmznGetShipmentRequest request)
            => await SendAsync<AmznGetShipmentResponse>(request);

        /// <summary>
        /// Provides a paginated list of box packages in a shipment.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznListShipmentBoxesResponse> ListShipmentBoxesAsync(AmznListShipmentBoxesRequest request)
            => await SendAsync<AmznListShipmentBoxesResponse>(request);

        /// <summary>
        /// Retrieve a paginated list of shipment content update previews for a given shipment. The shipment
        /// content update preview is a summary of the requested shipment content changes along with the
        /// transportation cost implications of the change that can only be confirmed prior to the expiry
        /// date specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | |
        /// 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
        /// were applied to the requested operation, when available. The preceding table contains the default
        /// rate and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may have higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListShipmentContentUpdatePreviewsResponse> ListShipmentContentUpdatePreviewsAsync(AmznListShipmentContentUpdatePreviewsRequest request)
            => await SendAsync<AmznListShipmentContentUpdatePreviewsResponse>(request);

        /// <summary>
        /// Generate a shipment content update preview given a set of intended boxes and/or items for a
        /// shipment with a confirmed carrier. The shipment content update preview will be viewable with
        /// the updated costs and contents prior to confirmation.  **Usage Plan:**  | Rate (requests per
        /// second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznGenerateShipmentContentUpdatePreviewsResponse> GenerateShipmentContentUpdatePreviewsAsync(AmznGenerateShipmentContentUpdatePreviewsRequest request)
            => await SendAsync<AmznGenerateShipmentContentUpdatePreviewsResponse>(request);

        /// <summary>
        /// Retrieve a shipment content update preview which provides a summary of the requested shipment
        /// content changes along with the transportation cost implications of the change that can only
        /// be confirmed prior to the expiry date specified.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// preceding table contains the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may have higher rate and burst values than
        /// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznGetShipmentContentUpdatePreviewResponse> GetShipmentContentUpdatePreviewAsync(AmznGetShipmentContentUpdatePreviewRequest request)
            => await SendAsync<AmznGetShipmentContentUpdatePreviewResponse>(request);

        /// <summary>
        /// Confirm a shipment content update preview and accept the changes in transportation cost.  **Usage
        /// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznConfirmShipmentContentUpdatePreviewResponse> ConfirmShipmentContentUpdatePreviewAsync(AmznConfirmShipmentContentUpdatePreviewRequest request)
            => await SendAsync<AmznConfirmShipmentContentUpdatePreviewResponse>(request);

        /// <summary>
        /// Provide delivery challan document for PCP transportation in IN marketplace.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetDeliveryChallanDocumentResponse> GetDeliveryChallanDocumentAsync(AmznGetDeliveryChallanDocumentRequest request)
            => await SendAsync<AmznGetDeliveryChallanDocumentResponse>(request);

        /// <summary>
        /// Retrieves all delivery window options for a shipment. Delivery window options must first be
        /// generated by the `generateDeliveryWindowOptions` operation before becoming available.  **Usage
        /// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListDeliveryWindowOptionsResponse> ListDeliveryWindowOptionsAsync(AmznListDeliveryWindowOptionsRequest request)
            => await SendAsync<AmznListDeliveryWindowOptionsResponse>(request);

        /// <summary>
        /// Generates available delivery window options for a given shipment.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGenerateDeliveryWindowOptionsResponse> GenerateDeliveryWindowOptionsAsync(AmznGenerateDeliveryWindowOptionsRequest request)
            => await SendAsync<AmznGenerateDeliveryWindowOptionsResponse>(request);

        /// <summary>
        /// Confirms the delivery window option for chosen shipment within an inbound plan. A placement
        /// option must be confirmed prior to use of this API. Once confirmed, new delivery window options
        /// cannot be generated, but the chosen delivery window option can be updated before shipment closure.
        /// The window is used to provide the expected time when a shipment will arrive at the warehouse.
        /// All transportation options which have the program `CONFIRMED_DELIVERY_WINDOW` require a delivery
        /// window to be confirmed prior to transportation option confirmation.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznConfirmDeliveryWindowOptionsResponse> ConfirmDeliveryWindowOptionsAsync(AmznConfirmDeliveryWindowOptionsRequest request)
            => await SendAsync<AmznConfirmDeliveryWindowOptionsResponse>(request);

        /// <summary>
        /// Provides a paginated list of item packages in a shipment.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznListShipmentItemsResponse> ListShipmentItemsAsync(AmznListShipmentItemsRequest request)
            => await SendAsync<AmznListShipmentItemsResponse>(request);

        /// <summary>
        /// Updates the name of an existing shipment.  **Usage Plan:**  | Rate (requests per second) |
        /// Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The preceding
        /// table contains the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may have higher rate and burst values than those
        /// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznUpdateShipmentNameResponse> UpdateShipmentNameAsync(AmznUpdateShipmentNameRequest request)
            => await SendAsync<AmznUpdateShipmentNameResponse>(request);

        /// <summary>
        /// Provides a paginated list of pallet packages in a shipment. A palletized shipment will have
        /// pallets when the related details are provided after generating Less-Than-Truckload (LTL) carrier
        /// shipments.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30
        /// |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
        /// applied to the requested operation, when available. The preceding table contains the default
        /// rate and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may have higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListShipmentPalletsResponse> ListShipmentPalletsAsync(AmznListShipmentPalletsRequest request)
            => await SendAsync<AmznListShipmentPalletsResponse>(request);

        /// <summary>
        /// Cancels a self-ship appointment slot against a shipment. Only available in the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids):
        /// MX, BR, EG, SA, AE, IN.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCancelSelfShipAppointmentResponse> CancelSelfShipAppointmentAsync(AmznCancelSelfShipAppointmentRequest request)
            => await SendAsync<AmznCancelSelfShipAppointmentResponse>(request);

        /// <summary>
        /// Retrieves a list of available self-ship appointment slots used to drop off a shipment at a
        /// warehouse. Only available in the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids):
        /// MX, BR, EG, SA, AE, IN.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetSelfShipAppointmentSlotsResponse> GetSelfShipAppointmentSlotsAsync(AmznGetSelfShipAppointmentSlotsRequest request)
            => await SendAsync<AmznGetSelfShipAppointmentSlotsResponse>(request);

        /// <summary>
        /// Initiates the process of generating the appointment slots list. Only available in the following
        /// [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids): MX, BR, EG,
        /// SA, AE, IN.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 |
        /// 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
        /// applied to the requested operation, when available. The table above indicates the default rate
        /// and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may see higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGenerateSelfShipAppointmentSlotsResponse> GenerateSelfShipAppointmentSlotsAsync(AmznGenerateSelfShipAppointmentSlotsRequest request)
            => await SendAsync<AmznGenerateSelfShipAppointmentSlotsResponse>(request);

        /// <summary>
        /// Confirms or reschedules a self-ship appointment slot against a shipment. Only available in
        /// the following [marketplaces](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids):
        /// MX, BR, EG, SA, AE, IN.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznScheduleSelfShipAppointmentResponse> ScheduleSelfShipAppointmentAsync(AmznScheduleSelfShipAppointmentRequest request)
            => await SendAsync<AmznScheduleSelfShipAppointmentResponse>(request);

        /// <summary>
        /// Updates the source address of an existing shipment. The shipment source address can only be
        /// updated prior to the confirmation of the shipment carriers. As a result of the updated source
        /// address, existing transportation options will be invalidated and will need to be regenerated
        /// to capture the potential difference in transportation options and quotes due to the new source
        /// address.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30
        /// |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
        /// applied to the requested operation, when available. The preceding table contains the default
        /// rate and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may have higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznUpdateShipmentSourceAddressResponse> UpdateShipmentSourceAddressAsync(AmznUpdateShipmentSourceAddressRequest request)
            => await SendAsync<AmznUpdateShipmentSourceAddressResponse>(request);

        /// <summary>
        /// Updates a shipment's tracking details.  **Usage Plan:**  | Rate (requests per second) | Burst
        /// | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The preceding
        /// table contains the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may have higher rate and burst values than those
        /// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznUpdateShipmentTrackingDetailsResponse> UpdateShipmentTrackingDetailsAsync(AmznUpdateShipmentTrackingDetailsRequest request)
            => await SendAsync<AmznUpdateShipmentTrackingDetailsResponse>(request);

        /// <summary>
        /// Retrieves all transportation options for a shipment. Transportation options must first be generated
        /// by the `generateTransportationOptions` operation before becoming available.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListTransportationOptionsResponse> ListTransportationOptionsAsync(AmznListTransportationOptionsRequest request)
            => await SendAsync<AmznListTransportationOptionsResponse>(request);

        /// <summary>
        /// Generates available transportation options for a given placement option.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGenerateTransportationOptionsResponse> GenerateTransportationOptionsAsync(AmznGenerateTransportationOptionsRequest request)
            => await SendAsync<AmznGenerateTransportationOptionsResponse>(request);

        /// <summary>
        /// Confirms all the transportation options for an inbound plan. A placement option must be confirmed
        /// prior to use of this API. Once confirmed, new transportation options can not be generated or
        /// confirmed for the Inbound Plan.  **Usage Plan:**  | Rate (requests per second) | Burst | |
        /// ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
        /// rate limits that were applied to the requested operation, when available. The preceding table
        /// contains the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may have higher rate and burst values than those shown here.
        /// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](ht
        /// tps://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznConfirmTransportationOptionsResponse> ConfirmTransportationOptionsAsync(AmznConfirmTransportationOptionsRequest request)
            => await SendAsync<AmznConfirmTransportationOptionsResponse>(request);

        /// <summary>
        /// List the inbound compliance details for MSKUs in a given marketplace.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListItemComplianceDetailsResponse> ListItemComplianceDetailsAsync(AmznListItemComplianceDetailsRequest request)
            => await SendAsync<AmznListItemComplianceDetailsResponse>(request);

        /// <summary>
        /// Update compliance details for a list of MSKUs. The details provided here are only used for
        /// the India (IN - A21TJRUUN4KGV) marketplace compliance validation.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznUpdateItemComplianceDetailsResponse> UpdateItemComplianceDetailsAsync(AmznUpdateItemComplianceDetailsRequest request)
            => await SendAsync<AmznUpdateItemComplianceDetailsResponse>(request);

        /// <summary>
        /// For a given marketplace - creates labels for a list of MSKUs.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznCreateMarketplaceItemLabelsResponse> CreateMarketplaceItemLabelsAsync(AmznCreateMarketplaceItemLabelsRequest request)
            => await SendAsync<AmznCreateMarketplaceItemLabelsResponse>(request);

        /// <summary>
        /// Get preparation details for a list of MSKUs in a specified marketplace.  **Usage Plan:**  |
        /// Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListPrepDetailsResponse> ListPrepDetailsAsync(AmznListPrepDetailsRequest request)
            => await SendAsync<AmznListPrepDetailsResponse>(request);

        /// <summary>
        /// Set the preparation details for a list of MSKUs in a specified marketplace.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznSetPrepDetailsResponse> SetPrepDetailsAsync(AmznSetPrepDetailsRequest request)
            => await SendAsync<AmznSetPrepDetailsResponse>(request);

        /// <summary>
        /// Gets the status of the processing of an asynchronous API call.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table contains the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznGetInboundOperationStatusResponse> GetInboundOperationStatusAsync(AmznGetInboundOperationStatusRequest request)
            => await SendAsync<AmznGetInboundOperationStatusResponse>(request);
    }
}
