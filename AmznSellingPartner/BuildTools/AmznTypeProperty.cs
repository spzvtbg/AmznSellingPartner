namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    internal class AmznTypeProperty
    {
        [JsonProperty]
        private readonly Dictionary<string, string> attributes = [];
        [JsonProperty]
        private readonly ICollection<string> usings = [];
        [JsonProperty]
        private string summary;

        public string Name { get; set; }

        public string Type { get; set; }

        public string DefaultValue { get; set; }

        internal AmznTypeProperty AddAttribute(string attribute)
        {
            this.attributes[attribute] = default;

            return this;
        }

        internal AmznTypeProperty HasAttribute(string attribute, object value)
        {
            if (value is not null)
            {
                this.attributes[attribute] = value.ToString();
            }

            return this;
        }

        internal AmznTypeProperty HasSummary(string summary)
        {
            this.summary = $"{this.summary} {summary}";

            return this;
        }

        internal AmznTypeProperty HasDefaultValue(string defaultValue)
        {
            if (!string.IsNullOrWhiteSpace(defaultValue))
            {
                this.DefaultValue = defaultValue;
            }

            return this;
        }

        internal AmznTypeProperty HasName(string name)
        {
            this.Name = name;

            return this;
        }

        internal AmznTypeProperty HasType(string type, string _using = default)
        {
            this.Type = type;

            if (!string.IsNullOrWhiteSpace(_using))
            {
                this.usings.Add(_using);
            }

            return this;
        }
    }
}