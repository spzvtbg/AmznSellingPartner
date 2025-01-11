namespace AmznSellingPartner.BuildTools
{
    using AmznSellingPartner;

    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CsProperty
    {
        [JsonProperty]
        protected ICollection<KeyValuePair<string, string>> attributes = [];

        [JsonProperty]
        protected ICollection<string> usings = [];

        [JsonProperty]
        protected string defaultValue;

        [JsonProperty]
        protected string description;

        [JsonProperty]
        public string Type { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        internal IEnumerable<string> GetUsings() => this.usings;

        internal CsProperty HasAttribute(string name, object value = default)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.attributes.Add(new KeyValuePair<string, string>(name, value?.ToString()));
                this.usings.Add("AmznSellingPartner.Clients.Attributes");
            }

            return this;
        }

        internal CsProperty HasAttribute(CsProperty csProperty)
        {
            foreach (var (name, parameter) in csProperty.attributes ?? [])
            {
                this.HasAttribute(name, parameter);
            }

            return this;
        }

        internal CsProperty HasDefaultValue(string @default)
        {
            if (!string.IsNullOrWhiteSpace(@default))
            {
                this.defaultValue = @default;
            }

            return this;
        }

        internal CsProperty HasDescription(string description)
        {
            this.description = $"{this.description?.Trim()} {description?.Trim()}".Trim();

            return this;
        }

        internal CsProperty HasDescription(CsProperty csProperty)
        {
            this.HasDescription(csProperty?.description);

            return this;
        }

        internal CsProperty HasJsonProperty(bool addJsonPropertyAttribute)
        {
            if (addJsonPropertyAttribute && !this.attributes.Any(x => x.Key == "JsonProperty"))
            {
                this.usings.Add("Newtonsoft.Json");
                this.attributes.Add(new KeyValuePair<string, string>("JsonProperty", $"\"{this.Name}\""));
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

            var defaultValue = !string.IsNullOrWhiteSpace(this.defaultValue)
                ? $"= {this.defaultValue};"
                : null;

            lines.Add($"public {this.Type} {this.Name.Capitalize()} {{ get; set; }} {defaultValue}");

            return lines;
        }

        internal void HasUsing(string @using)
            => this.usings.Add(@using);
    }
}