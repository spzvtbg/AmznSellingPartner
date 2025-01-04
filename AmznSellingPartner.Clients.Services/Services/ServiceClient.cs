namespace AmznSellingPartner.Clients.Services.Services
{
	using System;
	using System.Threading.Tasks;

	public class ServiceClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Gets details of service job indicated by the provided `serviceJobID`.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-
		/// sp-api).
		/// </summary>
		public async Task<GetServiceJobByServiceJobIdGetResponse> GetServiceJobByServiceJobIdAsync(GetServiceJobByServiceJobIdGetRequest request)
		    => await SendAsync<GetServiceJobByServiceJobIdGetResponse>(request);

		/// <summary>
		/// Cancels the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-
		/// sp-api).
		/// </summary>
		public async Task<CancelServiceJobByServiceJobIdPutResponse> CancelServiceJobByServiceJobIdAsync(CancelServiceJobByServiceJobIdPutRequest request)
		    => await SendAsync<CancelServiceJobByServiceJobIdPutResponse>(request);

		/// <summary>
		/// Completes the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate
		/// (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available. The
		/// table above indicates the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput may see higher rate and burst values than those shown here. For more
		/// information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// imits-in-the-sp-api).
		/// </summary>
		public async Task<CompleteServiceJobByServiceJobIdPutResponse> CompleteServiceJobByServiceJobIdAsync(CompleteServiceJobByServiceJobIdPutRequest request)
		    => await SendAsync<CompleteServiceJobByServiceJobIdPutResponse>(request);

		/// <summary>
		/// Gets service job details for the specified filter query.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 10 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The table above indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput may see higher rate and burst values than those shown here. For more information, see
		/// [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-a
		/// pi).
		/// </summary>
		public async Task<GetServiceJobsGetResponse> GetServiceJobsAsync(GetServiceJobsGetRequest request)
		    => await SendAsync<GetServiceJobsGetResponse>(request);

		/// <summary>
		/// Adds an appointment to the service job indicated by the service job identifier specified.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-a
		/// nd-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AddAppointmentForServiceJobByServiceJobIdPostResponse> AddAppointmentForServiceJobByServiceJobIdAsync(AddAppointmentForServiceJobByServiceJobIdPostRequest request)
		    => await SendAsync<AddAppointmentForServiceJobByServiceJobIdPostResponse>(request);

		/// <summary>
		/// Reschedules an appointment for the service job indicated by the service job identifier specified.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than those shown
		/// here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-p
		/// lans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<RescheduleAppointmentForServiceJobByServiceJobIdPostResponse> RescheduleAppointmentForServiceJobByServiceJobIdAsync(RescheduleAppointmentForServiceJobByServiceJobIdPostRequest request)
		    => await SendAsync<RescheduleAppointmentForServiceJobByServiceJobIdPostResponse>(request);

		/// <summary>
		/// Assigns new resource(s) or overwrite/update the existing one(s) to a service job appointment.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 2 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than those shown
		/// here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-p
		/// lans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AssignAppointmentResourcesPutResponse> AssignAppointmentResourcesAsync(AssignAppointmentResourcesPutRequest request)
		    => await SendAsync<AssignAppointmentResourcesPutResponse>(request);

		/// <summary>
		/// Updates the appointment fulfillment data related to a given `jobID` and `appointmentID`.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-a
		/// nd-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SetAppointmentFulfillmentDataPutResponse> SetAppointmentFulfillmentDataAsync(SetAppointmentFulfillmentDataPutRequest request)
		    => await SendAsync<SetAppointmentFulfillmentDataPutResponse>(request);

		/// <summary>
		/// Provides capacity slots in a format similar to availability records.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-
		/// sp-api).
		/// </summary>
		public async Task<GetRangeSlotCapacityPostResponse> GetRangeSlotCapacityAsync(GetRangeSlotCapacityPostRequest request)
		    => await SendAsync<GetRangeSlotCapacityPostResponse>(request);

		/// <summary>
		/// Provides capacity in fixed-size slots.   **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The table above indicates the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may see higher rate and burst values than those shown here. For more information, see [Usage Plans and
		/// Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFixedSlotCapacityPostResponse> GetFixedSlotCapacityAsync(GetFixedSlotCapacityPostRequest request)
		    => await SendAsync<GetFixedSlotCapacityPostResponse>(request);

		/// <summary>
		/// Update the schedule of the given resource.  **Usage Plan:**  | Rate (requests per second) | Burst | |
		/// ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The table above indicates the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may see higher rate and burst values than those shown here. For more information, see [Usage Plans and
		/// Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateSchedulePutResponse> UpdateScheduleAsync(UpdateSchedulePutRequest request)
		    => await SendAsync<UpdateSchedulePutResponse>(request);

		/// <summary>
		/// Create a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 |
		/// 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher
		/// rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in
		/// the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateReservationPostResponse> CreateReservationAsync(CreateReservationPostRequest request)
		    => await SendAsync<CreateReservationPostResponse>(request);

		/// <summary>
		/// Cancel a reservation.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 |
		/// 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher
		/// rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in
		/// the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelReservationDeleteResponse> CancelReservationAsync(CancelReservationDeleteRequest request)
		    => await SendAsync<CancelReservationDeleteResponse>(request);

		/// <summary>
		/// Update a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 |
		/// 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher
		/// rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in
		/// the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateReservationPutResponse> UpdateReservationAsync(UpdateReservationPutRequest request)
		    => await SendAsync<UpdateReservationPutResponse>(request);

		/// <summary>
		/// Gets appointment slots for the service associated with the service job id specified.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-a
		/// nd-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetAppointmmentSlotsByJobIdGetResponse> GetAppointmmentSlotsByJobIdAsync(GetAppointmmentSlotsByJobIdGetRequest request)
		    => await SendAsync<GetAppointmmentSlotsByJobIdGetResponse>(request);

		/// <summary>
		/// Gets appointment slots as per the service context specified.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The table above indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput may see higher rate and burst values than those shown here. For more information, see
		/// [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-a
		/// pi).
		/// </summary>
		public async Task<GetAppointmentSlotsGetResponse> GetAppointmentSlotsAsync(GetAppointmentSlotsGetRequest request)
		    => await SendAsync<GetAppointmentSlotsGetResponse>(request);

		/// <summary>
		/// Creates an upload destination.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
		/// applied to the requested operation, when available. The table above indicates the default rate and burst
		/// values for this operation. Selling partners whose business demands require higher throughput may see
		/// higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits
		/// in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateServiceDocumentUploadDestinationPostResponse> CreateServiceDocumentUploadDestinationAsync(CreateServiceDocumentUploadDestinationPostRequest request)
		    => await SendAsync<CreateServiceDocumentUploadDestinationPostResponse>(request);
	}
}
