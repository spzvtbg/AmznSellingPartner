namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using System;
	using System.Threading.Tasks;

	public class FulfillmentInboundClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Provides a list of inbound plans with minimal information.  **Usage Plan:**  | Rate (requests per second) | Bu
		/// st | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limit
		/// that were applied to the requested operation, when available. The preceding table contains the default rate a
		/// d burst values for this operation. Selling partners whose business demands require higher throughput may have
		/// igher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-s
		/// -api).
		/// </summary>
		public async Task<ListInboundPlansGetResponse> ListInboundPlansAsync(ListInboundPlansGetRequest request)
		    => await this.SendAsync<ListInboundPlansGetResponse>(request);

		/// <summary>
		/// Creates an inbound plan. An inbound plan contains all the necessary information to send shipments into Amazon'
		/// fufillment network.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `
		/// -amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested o
		/// eration, when available. The preceding table contains the default rate and burst values for this operation. Se
		/// ling partners whose business demands require higher throughput may have higher rate and burst values than thos
		/// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://d
		/// veloper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateInboundPlanPostResponse> CreateInboundPlanAsync(CreateInboundPlanPostRequest request)
		    => await this.SendAsync<CreateInboundPlanPostResponse>(request);

		/// <summary>
		/// Fetches the top level information about an inbound plan.  **Usage Plan:**  | Rate (requests per second) | Burs
		/// | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// hat were applied to the requested operation, when available. The preceding table contains the default rate and
		/// burst values for this operation. Selling partners whose business demands require higher throughput may have hi
		/// her rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits i
		/// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-
		/// pi).
		/// </summary>
		public async Task<GetInboundPlanGetResponse> GetInboundPlanAsync(GetInboundPlanGetRequest request)
		    => await this.SendAsync<GetInboundPlanGetResponse>(request);

		/// <summary>
		/// Provides a paginated list of box packages in an inbound plan.  **Usage Plan:**  | Rate (requests per second) |
		/// Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate li
		/// its that were applied to the requested operation, when available. The preceding table contains the default rat
		/// and burst values for this operation. Selling partners whose business demands require higher throughput may ha
		/// e higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Lim
		/// ts in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-th
		/// -sp-api).
		/// </summary>
		public async Task<ListInboundPlanBoxesGetResponse> ListInboundPlanBoxesAsync(ListInboundPlanBoxesGetRequest request)
		    => await this.SendAsync<ListInboundPlanBoxesGetResponse>(request);

		/// <summary>
		/// Cancels an Inbound Plan. Charges may apply if the cancellation is performed outside of a void window. The wind
		/// w for Amazon Partnered Carriers is 24 hours for Small Parcel Delivery (SPD) and one hour for Less-Than-Trucklo
		/// d (LTL) carrier shipments.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |
		/// The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the reque
		/// ted operation, when available. The preceding table contains the default rate and burst values for this operati
		/// n. Selling partners whose business demands require higher throughput may have higher rate and burst values tha
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](htt
		/// s://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelInboundPlanPutResponse> CancelInboundPlanAsync(CancelInboundPlanPutRequest request)
		    => await this.SendAsync<CancelInboundPlanPutResponse>(request);

		/// <summary>
		/// Provides a paginated list of item packages in an inbound plan.  **Usage Plan:**  | Rate (requests per second)
		/// Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate l
		/// mits that were applied to the requested operation, when available. The preceding table contains the default ra
		/// e and burst values for this operation. Selling partners whose business demands require higher throughput may h
		/// ve higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Li
		/// its in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-t
		/// e-sp-api).
		/// </summary>
		public async Task<ListInboundPlanItemsGetResponse> ListInboundPlanItemsAsync(ListInboundPlanItemsGetRequest request)
		    => await this.SendAsync<ListInboundPlanItemsGetResponse>(request);

		/// <summary>
		/// Updates the name of an existing inbound plan.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
		/// pplied to the requested operation, when available. The preceding table contains the default rate and burst val
		/// es for this operation. Selling partners whose business demands require higher throughput may have higher rate
		/// nd burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Sell
		/// ng Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateInboundPlanNamePutResponse> UpdateInboundPlanNameAsync(UpdateInboundPlanNamePutRequest request)
		    => await this.SendAsync<UpdateInboundPlanNamePutResponse>(request);

		/// <summary>
		/// Retrieves a page of boxes from a given packing group. These boxes were previously provided through the `setPac
		/// ingInformation` operation. This API is used for workflows where boxes are packed before Amazon determines ship
		/// ent splits.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-R
		/// teLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation
		/// when available. The preceding table contains the default rate and burst values for this operation. Selling pa
		/// tners whose business demands require higher throughput may have higher rate and burst values than those shown
		/// ere. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer
		/// docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListPackingGroupBoxesGetResponse> ListPackingGroupBoxesAsync(ListPackingGroupBoxesGetRequest request)
		    => await this.SendAsync<ListPackingGroupBoxesGetResponse>(request);

		/// <summary>
		/// Retrieves a page of items in a given packing group. Packing options must first be generated by the correspondi
		/// g operation before packing group items can be listed.  **Usage Plan:**  | Rate (requests per second) | Burst |
		/// | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits th
		/// t were applied to the requested operation, when available. The preceding table contains the default rate and b
		/// rst values for this operation. Selling partners whose business demands require higher throughput may have high
		/// r rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
		/// he Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-ap
		/// ).
		/// </summary>
		public async Task<ListPackingGroupItemsGetResponse> ListPackingGroupItemsAsync(ListPackingGroupItemsGetRequest request)
		    => await this.SendAsync<ListPackingGroupItemsGetResponse>(request);

		/// <summary>
		/// Sets packing information for an inbound plan. This should be called after an inbound plan is created to popula
		/// e the box level information required for planning and transportation estimates.  **Usage Plan:**  | Rate (requ
		/// sts per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// sage plan rate limits that were applied to the requested operation, when available. The preceding table contai
		/// s the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage
		/// lans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SetPackingInformationPostResponse> SetPackingInformationAsync(SetPackingInformationPostRequest request)
		    => await this.SendAsync<SetPackingInformationPostResponse>(request);

		/// <summary>
		/// Retrieves a list of all packing options for an inbound plan. Packing options must first be generated by the co
		/// responding operation before becoming available.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---
		/// | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
		/// applied to the requested operation, when available. The preceding table contains the default rate and burst va
		/// ues for this operation. Selling partners whose business demands require higher throughput may have higher rate
		/// and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Sel
		/// ing Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListPackingOptionsGetResponse> ListPackingOptionsAsync(ListPackingOptionsGetRequest request)
		    => await this.SendAsync<ListPackingOptionsGetResponse>(request);

		/// <summary>
		/// Generates available packing options for the inbound plan.  **Usage Plan:**  | Rate (requests per second) | Bur
		/// t | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The preceding table contains the default rate an
		/// burst values for this operation. Selling partners whose business demands require higher throughput may have h
		/// gher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// n the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// api).
		/// </summary>
		public async Task<GeneratePackingOptionsPostResponse> GeneratePackingOptionsAsync(GeneratePackingOptionsPostRequest request)
		    => await this.SendAsync<GeneratePackingOptionsPostResponse>(request);

		/// <summary>
		/// Confirms the packing option for an inbound plan.  **Usage Plan:**  | Rate (requests per second) | Burst | | --
		/// - | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that wer
		/// applied to the requested operation, when available. The preceding table contains the default rate and burst v
		/// lues for this operation. Selling partners whose business demands require higher throughput may have higher rat
		/// and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Se
		/// ling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmPackingOptionPostResponse> ConfirmPackingOptionAsync(ConfirmPackingOptionPostRequest request)
		    => await this.SendAsync<ConfirmPackingOptionPostResponse>(request);

		/// <summary>
		/// Provides a paginated list of pallet packages in an inbound plan. An inbound plan will have pallets when the re
		/// ated details are provided after generating Less-Than-Truckload (LTL) carrier shipments.  **Usage Plan:**  | Ra
		/// e (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header retu
		/// ns the usage plan rate limits that were applied to the requested operation, when available. The preceding tabl
		/// contains the default rate and burst values for this operation. Selling partners whose business demands requir
		/// higher throughput may have higher rate and burst values than those shown here. For more information, refer to
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-p
		/// ans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListInboundPlanPalletsGetResponse> ListInboundPlanPalletsAsync(ListInboundPlanPalletsGetRequest request)
		    => await this.SendAsync<ListInboundPlanPalletsGetResponse>(request);

		/// <summary>
		/// Provides a list of all placement options for an inbound plan. Placement options must first be generated by the
		/// corresponding operation before becoming available.  **Usage Plan:**  | Rate (requests per second) | Burst | |
		/// --- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that w
		/// re applied to the requested operation, when available. The preceding table contains the default rate and burst
		/// values for this operation. Selling partners whose business demands require higher throughput may have higher r
		/// te and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the
		/// elling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListPlacementOptionsGetResponse> ListPlacementOptionsAsync(ListPlacementOptionsGetRequest request)
		    => await this.SendAsync<ListPlacementOptionsGetResponse>(request);

		/// <summary>
		/// Generates placement options for the inbound plan.  **Usage Plan:**  | Rate (requests per second) | Burst | | -
		/// -- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that we
		/// e applied to the requested operation, when available. The preceding table contains the default rate and burst
		/// alues for this operation. Selling partners whose business demands require higher throughput may have higher ra
		/// e and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the S
		/// lling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GeneratePlacementOptionsPostResponse> GeneratePlacementOptionsAsync(GeneratePlacementOptionsPostRequest request)
		    => await this.SendAsync<GeneratePlacementOptionsPostResponse>(request);

		/// <summary>
		/// Confirms the placement option for an inbound plan. Once confirmed, it cannot be changed for the Inbound Plan.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit
		/// response header returns the usage plan rate limits that were applied to the requested operation, when availab
		/// e. The preceding table contains the default rate and burst values for this operation. Selling partners whose b
		/// siness demands require higher throughput may have higher rate and burst values than those shown here. For more
		/// information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.c
		/// m/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmPlacementOptionPostResponse> ConfirmPlacementOptionAsync(ConfirmPlacementOptionPostRequest request)
		    => await this.SendAsync<ConfirmPlacementOptionPostResponse>(request);

		/// <summary>
		/// Provides the full details for a specific shipment within an inbound plan. The `transportationOptionId` inside
		/// acceptedTransportationSelection` can be used to retrieve the transportation details for the shipment.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` respon
		/// e header returns the usage plan rate limits that were applied to the requested operation, when available. The
		/// receding table contains the default rate and burst values for this operation. Selling partners whose business
		/// emands require higher throughput may have higher rate and burst values than those shown here. For more informa
		/// ion, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// /docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetShipmentGetResponse> GetShipmentAsync(GetShipmentGetRequest request)
		    => await this.SendAsync<GetShipmentGetResponse>(request);

		/// <summary>
		/// Provides a paginated list of box packages in a shipment.  **Usage Plan:**  | Rate (requests per second) | Burs
		/// | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The preceding table contains the default rate an
		/// burst values for this operation. Selling partners whose business demands require higher throughput may have h
		/// gher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// n the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// api).
		/// </summary>
		public async Task<ListShipmentBoxesGetResponse> ListShipmentBoxesAsync(ListShipmentBoxesGetRequest request)
		    => await this.SendAsync<ListShipmentBoxesGetResponse>(request);

		/// <summary>
		/// Retrieve a paginated list of shipment content update previews for a given shipment. The shipment content updat
		/// preview is a summary of the requested shipment content changes along with the transportation cost implication
		/// of the change that can only be confirmed prior to the expiry date specified.  **Usage Plan:**  | Rate (reques
		/// s per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the u
		/// age plan rate limits that were applied to the requested operation, when available. The preceding table contain
		/// the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// hroughput may have higher rate and burst values than those shown here. For more information, refer to [Usage P
		/// ans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
		/// ate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListShipmentContentUpdatePreviewsGetResponse> ListShipmentContentUpdatePreviewsAsync(ListShipmentContentUpdatePreviewsGetRequest request)
		    => await this.SendAsync<ListShipmentContentUpdatePreviewsGetResponse>(request);

		/// <summary>
		/// Generate a shipment content update preview given a set of intended boxes and/or items for a shipment with a co
		/// firmed carrier. The shipment content update preview will be viewable with the updated costs and contents prior
		/// to confirmation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-a
		/// zn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested oper
		/// tion, when available. The preceding table contains the default rate and burst values for this operation. Selli
		/// g partners whose business demands require higher throughput may have higher rate and burst values than those s
		/// own here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// oper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GenerateShipmentContentUpdatePreviewsPostResponse> GenerateShipmentContentUpdatePreviewsAsync(GenerateShipmentContentUpdatePreviewsPostRequest request)
		    => await this.SendAsync<GenerateShipmentContentUpdatePreviewsPostResponse>(request);

		/// <summary>
		/// Retrieve a shipment content update preview which provides a summary of the requested shipment content changes
		/// long with the transportation cost implications of the change that can only be confirmed prior to the expiry da
		/// e specified.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-
		/// ateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operatio
		/// , when available. The preceding table contains the default rate and burst values for this operation. Selling p
		/// rtners whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://develope
		/// -docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetShipmentContentUpdatePreviewGetResponse> GetShipmentContentUpdatePreviewAsync(GetShipmentContentUpdatePreviewGetRequest request)
		    => await this.SendAsync<GetShipmentContentUpdatePreviewGetResponse>(request);

		/// <summary>
		/// Confirm a shipment content update preview and accept the changes in transportation cost.  **Usage Plan:**  | R
		/// te (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header re
		/// urns the usage plan rate limits that were applied to the requested operation, when available. The preceding ta
		/// le contains the default rate and burst values for this operation. Selling partners whose business demands requ
		/// re higher throughput may have higher rate and burst values than those shown here. For more information, refer
		/// o [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage
		/// plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmShipmentContentUpdatePreviewPostResponse> ConfirmShipmentContentUpdatePreviewAsync(ConfirmShipmentContentUpdatePreviewPostRequest request)
		    => await this.SendAsync<ConfirmShipmentContentUpdatePreviewPostResponse>(request);

		/// <summary>
		/// Provide delivery challan document for PCP transportation in IN marketplace.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usag
		/// plan rate limits that were applied to the requested operation, when available. The preceding table contains t
		/// e default rate and burst values for this operation. Selling partners whose business demands require higher thr
		/// ughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plan
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
		/// -limits-in-the-sp-api).
		/// </summary>
		public async Task<GetDeliveryChallanDocumentGetResponse> GetDeliveryChallanDocumentAsync(GetDeliveryChallanDocumentGetRequest request)
		    => await this.SendAsync<GetDeliveryChallanDocumentGetResponse>(request);

		/// <summary>
		/// Retrieves all delivery window options for a shipment. Delivery window options must first be generated by the `
		/// enerateDeliveryWindowOptions` operation before becoming available.  **Usage Plan:**  | Rate (requests per seco
		/// d) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan r
		/// te limits that were applied to the requested operation, when available. The preceding table contains the defau
		/// t rate and burst values for this operation. Selling partners whose business demands require higher throughput
		/// ay have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Ra
		/// e Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits
		/// in-the-sp-api).
		/// </summary>
		public async Task<ListDeliveryWindowOptionsGetResponse> ListDeliveryWindowOptionsAsync(ListDeliveryWindowOptionsGetRequest request)
		    => await this.SendAsync<ListDeliveryWindowOptionsGetResponse>(request);

		/// <summary>
		/// Generates available delivery window options for a given shipment.  **Usage Plan:**  | Rate (requests per secon
		/// ) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan ra
		/// e limits that were applied to the requested operation, when available. The preceding table contains the defaul
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput m
		/// y have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rat
		/// Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-
		/// n-the-sp-api).
		/// </summary>
		public async Task<GenerateDeliveryWindowOptionsPostResponse> GenerateDeliveryWindowOptionsAsync(GenerateDeliveryWindowOptionsPostRequest request)
		    => await this.SendAsync<GenerateDeliveryWindowOptionsPostResponse>(request);

		/// <summary>
		/// Confirms the delivery window option for chosen shipment within an inbound plan. A placement option must be con
		/// irmed prior to use of this API. Once confirmed, new delivery window options cannot be generated, but the chose
		/// delivery window option can be updated before shipment closure. The window is used to provide the expected tim
		/// when a shipment will arrive at the warehouse. All transportation options which have the program `CONFIRMED_DE
		/// IVERY_WINDOW` require a delivery window to be confirmed prior to transportation option confirmation.  **Usage
		/// lan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` respon
		/// e header returns the usage plan rate limits that were applied to the requested operation, when available. The
		/// receding table contains the default rate and burst values for this operation. Selling partners whose business
		/// emands require higher throughput may have higher rate and burst values than those shown here. For more informa
		/// ion, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// /docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmDeliveryWindowOptionsPostResponse> ConfirmDeliveryWindowOptionsAsync(ConfirmDeliveryWindowOptionsPostRequest request)
		    => await this.SendAsync<ConfirmDeliveryWindowOptionsPostResponse>(request);

		/// <summary>
		/// Provides a paginated list of item packages in a shipment.  **Usage Plan:**  | Rate (requests per second) | Bur
		/// t | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limit
		/// that were applied to the requested operation, when available. The preceding table contains the default rate a
		/// d burst values for this operation. Selling partners whose business demands require higher throughput may have
		/// igher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-s
		/// -api).
		/// </summary>
		public async Task<ListShipmentItemsGetResponse> ListShipmentItemsAsync(ListShipmentItemsGetRequest request)
		    => await this.SendAsync<ListShipmentItemsGetResponse>(request);

		/// <summary>
		/// Updates the name of an existing shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | --
		/// - | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were appl
		/// ed to the requested operation, when available. The preceding table contains the default rate and burst values
		/// or this operation. Selling partners whose business demands require higher throughput may have higher rate and
		/// urst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
		/// artner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateShipmentNamePutResponse> UpdateShipmentNameAsync(UpdateShipmentNamePutRequest request)
		    => await this.SendAsync<UpdateShipmentNamePutResponse>(request);

		/// <summary>
		/// Provides a paginated list of pallet packages in a shipment. A palletized shipment will have pallets when the r
		/// lated details are provided after generating Less-Than-Truckload (LTL) carrier shipments.  **Usage Plan:**  | R
		/// te (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header re
		/// urns the usage plan rate limits that were applied to the requested operation, when available. The preceding ta
		/// le contains the default rate and burst values for this operation. Selling partners whose business demands requ
		/// re higher throughput may have higher rate and burst values than those shown here. For more information, refer
		/// o [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage
		/// plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListShipmentPalletsGetResponse> ListShipmentPalletsAsync(ListShipmentPalletsGetRequest request)
		    => await this.SendAsync<ListShipmentPalletsGetResponse>(request);

		/// <summary>
		/// Cancels a self-ship appointment slot against a shipment.  **Usage Plan:**  | Rate (requests per second) | Burs
		/// | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The preceding table contains the default rate an
		/// burst values for this operation. Selling partners whose business demands require higher throughput may have h
		/// gher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// n the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// api).
		/// </summary>
		public async Task<CancelSelfShipAppointmentPutResponse> CancelSelfShipAppointmentAsync(CancelSelfShipAppointmentPutRequest request)
		    => await this.SendAsync<CancelSelfShipAppointmentPutResponse>(request);

		/// <summary>
		/// Retrieves a list of available self-ship appointment slots used to drop off a shipment at a warehouse.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` respon
		/// e header returns the usage plan rate limits that were applied to the requested operation, when available. The
		/// receding table contains the default rate and burst values for this operation. Selling partners whose business
		/// emands require higher throughput may have higher rate and burst values than those shown here. For more informa
		/// ion, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// /docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetSelfShipAppointmentSlotsGetResponse> GetSelfShipAppointmentSlotsAsync(GetSelfShipAppointmentSlotsGetRequest request)
		    => await this.SendAsync<GetSelfShipAppointmentSlotsGetResponse>(request);

		/// <summary>
		/// Initiates the process of generating the appointment slots list.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// imits that were applied to the requested operation, when available. The preceding table contains the default r
		/// te and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// ave higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate L
		/// mits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
		/// he-sp-api).
		/// </summary>
		public async Task<GenerateSelfShipAppointmentSlotsPostResponse> GenerateSelfShipAppointmentSlotsAsync(GenerateSelfShipAppointmentSlotsPostRequest request)
		    => await this.SendAsync<GenerateSelfShipAppointmentSlotsPostResponse>(request);

		/// <summary>
		/// Confirms or reschedules a self-ship appointment slot against a shipment.  **Usage Plan:**  | Rate (requests pe
		/// second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage p
		/// an rate limits that were applied to the requested operation, when available. The preceding table contains the
		/// efault rate and burst values for this operation. Selling partners whose business demands require higher throug
		/// put may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans a
		/// d Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-l
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<ScheduleSelfShipAppointmentPostResponse> ScheduleSelfShipAppointmentAsync(ScheduleSelfShipAppointmentPostRequest request)
		    => await this.SendAsync<ScheduleSelfShipAppointmentPostResponse>(request);

		/// <summary>
		/// Updates the source address of an existing shipment. The shipment source address can only be updated prior to t
		/// e confirmation of the shipment carriers. As a result of the updated source address, existing transportation op
		/// ions will be invalidated and will need to be regenerated to capture the potential difference in transportation
		/// options and quotes due to the new source address.  **Usage Plan:**  | Rate (requests per second) | Burst | | -
		/// -- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that w
		/// re applied to the requested operation, when available. The preceding table contains the default rate and burst
		/// values for this operation. Selling partners whose business demands require higher throughput may have higher r
		/// te and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the
		/// elling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateShipmentSourceAddressPutResponse> UpdateShipmentSourceAddressAsync(UpdateShipmentSourceAddressPutRequest request)
		    => await this.SendAsync<UpdateShipmentSourceAddressPutResponse>(request);

		/// <summary>
		/// Updates a shipment's tracking details.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available. The preceding table contains the default rate and burst values for
		/// his operation. Selling partners whose business demands require higher throughput may have higher rate and burs
		/// values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Part
		/// er API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateShipmentTrackingDetailsPutResponse> UpdateShipmentTrackingDetailsAsync(UpdateShipmentTrackingDetailsPutRequest request)
		    => await this.SendAsync<UpdateShipmentTrackingDetailsPutResponse>(request);

		/// <summary>
		/// Retrieves all transportation options for a shipment. Transportation options must first be generated by the `ge
		/// erateTransportationOptions` operation before becoming available.  **Usage Plan:**  | Rate (requests per second
		/// | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that were applied to the requested operation, when available. The preceding table contains the default
		/// ate and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate
		/// imits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in
		/// the-sp-api).
		/// </summary>
		public async Task<ListTransportationOptionsGetResponse> ListTransportationOptionsAsync(ListTransportationOptionsGetRequest request)
		    => await this.SendAsync<ListTransportationOptionsGetResponse>(request);

		/// <summary>
		/// Generates available transportation options for a given placement option.  **Usage Plan:**  | Rate (requests pe
		/// second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage p
		/// an rate limits that were applied to the requested operation, when available. The preceding table contains the
		/// efault rate and burst values for this operation. Selling partners whose business demands require higher throug
		/// put may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans a
		/// d Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-l
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<GenerateTransportationOptionsPostResponse> GenerateTransportationOptionsAsync(GenerateTransportationOptionsPostRequest request)
		    => await this.SendAsync<GenerateTransportationOptionsPostResponse>(request);

		/// <summary>
		/// Confirms all the transportation options for an inbound plan. A placement option must be confirmed prior to use
		/// of this API. Once confirmed, new transportation options can not be generated or confirmed for the Inbound Plan
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Lim
		/// t` response header returns the usage plan rate limits that were applied to the requested operation, when avail
		/// ble. The preceding table contains the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values than those shown here. For mo
		/// e information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmTransportationOptionsPostResponse> ConfirmTransportationOptionsAsync(ConfirmTransportationOptionsPostRequest request)
		    => await this.SendAsync<ConfirmTransportationOptionsPostResponse>(request);

		/// <summary>
		/// List the inbound compliance details for MSKUs in a given marketplace.  **Usage Plan:**  | Rate (requests per s
		/// cond) | Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// rate limits that were applied to the requested operation, when available. The preceding table contains the def
		/// ult rate and burst values for this operation. Selling partners whose business demands require higher throughpu
		/// may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans and
		/// ate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limi
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<ListItemComplianceDetailsGetResponse> ListItemComplianceDetailsAsync(ListItemComplianceDetailsGetRequest request)
		    => await this.SendAsync<ListItemComplianceDetailsGetResponse>(request);

		/// <summary>
		/// Update compliance details for a list of MSKUs. The details provided here are only used for the India (IN - A21
		/// JRUUN4KGV) marketplace compliance validation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were a
		/// plied to the requested operation, when available. The preceding table contains the default rate and burst valu
		/// s for this operation. Selling partners whose business demands require higher throughput may have higher rate a
		/// d burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selli
		/// g Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateItemComplianceDetailsPutResponse> UpdateItemComplianceDetailsAsync(UpdateItemComplianceDetailsPutRequest request)
		    => await this.SendAsync<UpdateItemComplianceDetailsPutResponse>(request);

		/// <summary>
		/// For a given marketplace - creates labels for a list of MSKUs.  **Usage Plan:**  | Rate (requests per second) |
		/// Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate l
		/// mits that were applied to the requested operation, when available. The preceding table contains the default ra
		/// e and burst values for this operation. Selling partners whose business demands require higher throughput may h
		/// ve higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Li
		/// its in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-t
		/// e-sp-api).
		/// </summary>
		public async Task<CreateMarketplaceItemLabelsPostResponse> CreateMarketplaceItemLabelsAsync(CreateMarketplaceItemLabelsPostRequest request)
		    => await this.SendAsync<CreateMarketplaceItemLabelsPostResponse>(request);

		/// <summary>
		/// Get preparation details for a list of MSKUs in a specified marketplace.  **Usage Plan:**  | Rate (requests per
		/// second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage p
		/// an rate limits that were applied to the requested operation, when available. The preceding table contains the
		/// efault rate and burst values for this operation. Selling partners whose business demands require higher throug
		/// put may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans a
		/// d Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-l
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<ListPrepDetailsGetResponse> ListPrepDetailsAsync(ListPrepDetailsGetRequest request)
		    => await this.SendAsync<ListPrepDetailsGetResponse>(request);

		/// <summary>
		/// Set the preparation details for a list of MSKUs in a specified marketplace.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usa
		/// e plan rate limits that were applied to the requested operation, when available. The preceding table contains
		/// he default rate and burst values for this operation. Selling partners whose business demands require higher th
		/// oughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Pla
		/// s and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-ra
		/// e-limits-in-the-sp-api).
		/// </summary>
		public async Task<SetPrepDetailsPostResponse> SetPrepDetailsAsync(SetPrepDetailsPostRequest request)
		    => await this.SendAsync<SetPrepDetailsPostResponse>(request);

		/// <summary>
		/// Gets the status of the processing of an asynchronous API call.  **Usage Plan:**  | Rate (requests per second)
		/// Burst | | ---- | ---- | | 2 | 6 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate l
		/// mits that were applied to the requested operation, when available. The preceding table contains the default ra
		/// e and burst values for this operation. Selling partners whose business demands require higher throughput may h
		/// ve higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Li
		/// its in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-t
		/// e-sp-api).
		/// </summary>
		public async Task<GetInboundOperationStatusGetResponse> GetInboundOperationStatusAsync(GetInboundOperationStatusGetRequest request)
		    => await this.SendAsync<GetInboundOperationStatusGetResponse>(request);
	}
}
