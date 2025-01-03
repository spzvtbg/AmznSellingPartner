namespace AmznSellingPartner
{
    using Newtonsoft.Json;

    using System;

    internal class AmznParameterItem : AmznUnhandled
    {
        internal virtual CsProperty OnDeserialized(string name, CsContext context) 
            => throw new NotImplementedException();
    }

    internal class AmznParameterItemString : AmznParameterItem
    {
        public string Type { get; set; }

        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
        {
            var csProperty = new CsProperty
            {
                Name = name
            };

            csProperty.HasType("CsvValue<string>", "AmznSellingPartner.Clients.Values");

            if (this.MinLength is not null)
            {
                csProperty.HasAttribute(nameof(this.MinLength), this.MinLength);
            }

            if (this.MaxLength is not null)
            {
                csProperty.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            return csProperty;
        }
    }

    internal class AmznParameterItemEnum : AmznParameterItem
    {
        public string Type { get; set; }

        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public AmznEnum[] EnumDefinitions { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
        {
            var csEnum = new AmznDefinitionEnum
            { 
                Enum = this.Enum,
                EnumDefinitions = this.EnumDefinitions
            }
            .OnDeserialized(name, context);


            return new CsProperty
            { 
                Name = name,
                Type = $"CsvValue<{csEnum.GetTypeName()}>"
            }
            .HasType($"CsvValue<{csEnum.GetTypeName()}>", "AmznSellingPartner.Clients.Values");
        }
    }
}