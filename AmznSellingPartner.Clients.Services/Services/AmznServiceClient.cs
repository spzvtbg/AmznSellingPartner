namespace AmznSellingPartner.Clients.Services.Services
{
    using System;
    using System.Threading.Tasks;

    public class AmznServiceClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Gets details of service job indicated by the provided `serviceJobID`.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetServiceJobByServiceJobIdResponse> GetServiceJobByServiceJobIdAsync(AmznGetServiceJobByServiceJobIdRequest request)
            => await SendAsync<AmznGetServiceJobByServiceJobIdResponse>(request);

        /// <summary>
        /// Cancels the service job indicated by the service job identifier specified.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCancelServiceJobByServiceJobIdResponse> CancelServiceJobByServiceJobIdAsync(AmznCancelServiceJobByServiceJobIdRequest request)
            => await SendAsync<AmznCancelServiceJobByServiceJobIdResponse>(request);

        /// <summary>
        /// Completes the service job indicated by the service job identifier specified.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCompleteServiceJobByServiceJobIdResponse> CompleteServiceJobByServiceJobIdAsync(AmznCompleteServiceJobByServiceJobIdRequest request)
            => await SendAsync<AmznCompleteServiceJobByServiceJobIdResponse>(request);

        /// <summary>
        /// Gets service job details for the specified filter query.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 10 | 40 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetServiceJobsResponse> GetServiceJobsAsync(AmznGetServiceJobsRequest request)
            => await SendAsync<AmznGetServiceJobsResponse>(request);

        /// <summary>
        /// Adds an appointment to the service job indicated by the service job identifier specified.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznAddAppointmentForServiceJobByServiceJobIdResponse> AddAppointmentForServiceJobByServiceJobIdAsync(AmznAddAppointmentForServiceJobByServiceJobIdRequest request)
            => await SendAsync<AmznAddAppointmentForServiceJobByServiceJobIdResponse>(request);

        /// <summary>
        /// Reschedules an appointment for the service job indicated by the service job identifier specified.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznRescheduleAppointmentForServiceJobByServiceJobIdResponse> RescheduleAppointmentForServiceJobByServiceJobIdAsync(AmznRescheduleAppointmentForServiceJobByServiceJobIdRequest request)
            => await SendAsync<AmznRescheduleAppointmentForServiceJobByServiceJobIdResponse>(request);

        /// <summary>
        /// Assigns new resource(s) or overwrite/update the existing one(s) to a service job appointment.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 2 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznAssignAppointmentResourcesResponse> AssignAppointmentResourcesAsync(AmznAssignAppointmentResourcesRequest request)
            => await SendAsync<AmznAssignAppointmentResourcesResponse>(request);

        /// <summary>
        /// Updates the appointment fulfillment data related to a given `jobID` and `appointmentID`.  **Usage
        /// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznSetAppointmentFulfillmentDataResponse> SetAppointmentFulfillmentDataAsync(AmznSetAppointmentFulfillmentDataRequest request)
            => await SendAsync<AmznSetAppointmentFulfillmentDataResponse>(request);

        /// <summary>
        /// Provides capacity slots in a format similar to availability records.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetRangeSlotCapacityResponse> GetRangeSlotCapacityAsync(AmznGetRangeSlotCapacityRequest request)
            => await SendAsync<AmznGetRangeSlotCapacityResponse>(request);

        /// <summary>
        /// Provides capacity in fixed-size slots.   **Usage Plan:**  | Rate (requests per second) | Burst
        /// | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The table above
        /// indicates the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may see higher rate and burst values than those shown here.
        /// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usa
        /// ge-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetFixedSlotCapacityResponse> GetFixedSlotCapacityAsync(AmznGetFixedSlotCapacityRequest request)
            => await SendAsync<AmznGetFixedSlotCapacityResponse>(request);

        /// <summary>
        /// Update the schedule of the given resource.  **Usage Plan:**  | Rate (requests per second) |
        /// Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The table
        /// above indicates the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may see higher rate and burst values than those
        /// shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznUpdateScheduleResponse> UpdateScheduleAsync(AmznUpdateScheduleRequest request)
            => await SendAsync<AmznUpdateScheduleResponse>(request);

        /// <summary>
        /// Create a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limi
        /// ts-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateReservationResponse> CreateReservationAsync(AmznCreateReservationRequest request)
            => await SendAsync<AmznCreateReservationResponse>(request);

        /// <summary>
        /// Cancel a reservation.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limi
        /// ts-in-the-sp-api).
        /// </summary>
        public async Task<AmznCancelReservationResponse> CancelReservationAsync(AmznCancelReservationRequest request)
            => await SendAsync<AmznCancelReservationResponse>(request);

        /// <summary>
        /// Update a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limi
        /// ts-in-the-sp-api).
        /// </summary>
        public async Task<AmznUpdateReservationResponse> UpdateReservationAsync(AmznUpdateReservationRequest request)
            => await SendAsync<AmznUpdateReservationResponse>(request);

        /// <summary>
        /// Gets appointment slots for the service associated with the service job id specified.  **Usage
        /// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetAppointmmentSlotsByJobIdResponse> GetAppointmmentSlotsByJobIdAsync(AmznGetAppointmmentSlotsByJobIdRequest request)
            => await SendAsync<AmznGetAppointmmentSlotsByJobIdResponse>(request);

        /// <summary>
        /// Gets appointment slots as per the service context specified.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetAppointmentSlotsResponse> GetAppointmentSlotsAsync(AmznGetAppointmentSlotsRequest request)
            => await SendAsync<AmznGetAppointmentSlotsResponse>(request);

        /// <summary>
        /// Creates an upload destination.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
        /// | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
        /// limits that were applied to the requested operation, when available. The table above indicates
        /// the default rate and burst values for this operation. Selling partners whose business demands
        /// require higher throughput may see higher rate and burst values than those shown here. For more
        /// information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-
        /// and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateServiceDocumentUploadDestinationResponse> CreateServiceDocumentUploadDestinationAsync(AmznCreateServiceDocumentUploadDestinationRequest request)
            => await SendAsync<AmznCreateServiceDocumentUploadDestinationResponse>(request);
    }
}
