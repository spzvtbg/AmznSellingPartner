namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A reference to an image, hosted in the A+ Content media library.
    /// </summary>
    public class ImageComponent : BaseClass
    {
        /// <summary>
        /// This identifier is provided by the Selling Partner API for Uploads.
        /// </summary>
        [JsonProperty("uploadDestinationId")]
        [IsRequired]
        [MinLength(1)]
        public string UploadDestinationId { get; set; }

        [JsonProperty("imageCropSpecification")]
        [IsRequired]
        public ImageCropSpecification ImageCropSpecification { get; set; }

        /// <summary>
        /// The alternative text for the image.
        /// </summary>
        [JsonProperty("altText")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(100)]
        public string AltText { get; set; }
    }
}
