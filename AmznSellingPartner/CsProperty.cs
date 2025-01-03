namespace AmznSellingPartner
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    public class CsProperty
    {
        [JsonProperty]
        protected Dictionary<string, string> attributes = [];

        [JsonProperty]
        protected ICollection<string> usings = 
        [
            "Newtonsoft.Json"
        ];

        [JsonProperty]
        protected string defaultValue;

        [JsonProperty]
        protected string description;

        [JsonProperty]
        public string Type { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        internal IDictionary<string, string> GetAttributes() 
            => this.attributes;

        internal IEnumerable<string> GetUsings() => this.usings;

        internal CsProperty HasAttribute(string name, object value = default)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.attributes[name] = value?.ToString();
                this.usings.Add("AmznSellingPartner.Clients.Attributes");
            }

            return this;
        }

        internal CsProperty HasDefaultValue(string @default)
        {
            this.defaultValue = @default;

            return this;
        }

        internal CsProperty HasDescription(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                this.description = description;
            }

            return this;
        }

        internal CsProperty HasType(string type, string @using = default)
        {
            this.Type = type;

            this.usings.Add(@using);

            return this;
        }

        public IEnumerable<string> AsEnumerable()
        {
            var lines = new List<string>();

            if (!string.IsNullOrWhiteSpace(this.description))
            {
                lines.Add($"/// <summary>");

                foreach (var line in this.description.SplitToLines())
                {
                    lines.Add($"/// {line}");
                }

                lines.Add($"/// </summary>");
            }

            foreach (var (attr, val) in this.attributes)
            {
                if (string.IsNullOrWhiteSpace(val))
                {
                    lines.Add($"[{attr}]");
                }
                else
                {
                    lines.Add($"[{attr}({val.Replace("\\", "\\\\")})]");
                }
            }

            lines.Add($"[JsonProperty(\"{this.Name}\")]");

            lines.Add($"public {this.Type} {this.Name.Capitalize()} {{ get; set; }}");

            return lines;
        }

        internal void HasUsing(string @using) 
            => this.usings.Add(@using);
    }
}