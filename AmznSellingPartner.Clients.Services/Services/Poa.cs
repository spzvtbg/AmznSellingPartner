namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Proof of Appointment (POA) details.
    /// </summary>
    public class Poa : BaseClass
    {
        /// <summary>
        /// The time of the appointment window.
        /// </summary>
        [JsonProperty("appointmentTime")]
        public AppointmentTime AppointmentTime { get; set; }

        /// <summary>
        /// A list of technicians.
        /// </summary>
        [JsonProperty("technicians")]
        [MinItems(1)]
        public List<Technician> Technicians { get; set; }

        /// <summary>
        /// The identifier of the technician who uploaded the POA.
        /// </summary>
        [JsonProperty("uploadingTechnician")]
        [Pattern("^[A-Z0-9]*")]
        public string UploadingTechnician { get; set; }

        /// <summary>
        /// The date and time when the POA was uploaded in ISO 8601 format.
        /// </summary>
        [JsonProperty("uploadTime")]
        public DateTimeValue UploadTime { get; set; }

        /// <summary>
        /// The type of POA uploaded.
        /// </summary>
        [JsonProperty("poaType")]
        public PoaType PoaType { get; set; }
    }
}
