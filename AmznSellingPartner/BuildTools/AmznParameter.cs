namespace AmznSellingPartner.BuildTools
{
    using AmznSellingPartner;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class AmznParameter : AmznUnhandled
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required")]
        public bool? IsRequired { get; set; }

        public string In { get; set; }

        [JsonProperty("x-example")]
        public JToken Example { get; set; }

        internal virtual CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csProperty = new CsProperty
            {
                Name = this.Name
            };

            csProperty
                .HasDescription(this.Description)
                .HasAttribute($"In{this.In.Capitalize()}", $"\"{this.Name}\"");

            if (this.IsRequired == true)
            {
                csProperty.HasAttribute(nameof(IsRequired));
            }

            return csProperty;
        }
    }

    internal class AmznParameterRef : AmznParameter
    {
        public string Ref { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var type = this.Ref.GetReferenceType();

            if (this.Name is null)
            {
                var parameter = parameters[type];

                this.Name = parameter.Name;
                this.In = parameter.In;
                this.Description = parameter.Description;
                this.IsRequired = parameter.IsRequired;

                var json = JsonConvert.SerializeObject(parameter);
                var def = JsonConvert.DeserializeObject<AmznDefinition>(json);
                def.OnDeserialized(parameter.Name, context);
            }

            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType(this.Ref.GetReferenceType());

            csProperty.Name ??= csProperty.Type;

            return csProperty;
        }
    }

    internal class AmznParameterBoolean : AmznParameter
    {
        public string Format { get; set; }

        public bool? Default { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
              => base.OnDeserialized(csRequest, context, parameters)
                     .HasType("bool")
                     .HasDefaultValue(this.Default?.ToString()?.ToLower());
    }

    internal class AmznParameterDateTime : AmznParameter
    {
        public string Format { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
              => base.OnDeserialized(csRequest, context, parameters)
                     .HasType(nameof(DateTimeValue), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznParameterInt : AmznParameter
    {
        public string Format { get; set; }

        public int? Minimum { get; set; }

        public int? Maximum { get; set; }

        public int? Default { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType("int")
                                 .HasDefaultValue(this.Default?.ToString());

            if (this.Minimum is not null)
            {
                csProperty.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                csProperty.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return csProperty;
        }
    }

    internal class AmznParameterLong : AmznParameter
    {
        public string Format { get; set; }

        public long? Minimum { get; set; }

        public long? Maximum { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType("long");

            if (this.Minimum is not null)
            {
                csProperty.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                csProperty.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return csProperty;
        }
    }

    internal class AmznParameterFloat : AmznParameter
    {
        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
              => base.OnDeserialized(csRequest, context, parameters)
                     .HasType("float");
    }

    internal class AmznParameterDouble : AmznParameter
    {
        public double? Default { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
              => base.OnDeserialized(csRequest, context, parameters)
                     .HasType("double")
                     .HasDefaultValue(this.Default?.ToString());
    }

    internal class AmznParameterString : AmznParameter
    {
        public string Format { get; set; }

        public string Pattern { get; set; }

        public string Default { get; set; }

        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        [JsonProperty("x-amazon-spds-greedy-path-parameter")]
        public bool? IsGreedy { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType("string")
                                 .HasDefaultValue(this.Default is not null ? $"\"{this.Default}\"" : null);

            if (this.MinLength is not null)
            {
                csProperty.HasAttribute(nameof(this.MinLength), this.MinLength);
            }

            if (this.MaxLength is not null)
            {
                csProperty.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            if (this.Pattern is not null)
            {
                csProperty.HasAttribute(nameof(this.Pattern), $"\"{this.Pattern}\"");
            }

            return csProperty;
        }
    }

    internal class AmznParameterItems : AmznParameter
    {
        public string CollectionFormat { get; set; }

        public int? MaxItems { get; set; }

        public int? MinItems { get; set; }

        public bool? UniqueItems { get; set; }

        public AmznParameterItem Items { get; set; }

        public JToken Default { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csItem = this.Items.OnDeserialized(this.Name, context);
            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType(csItem.Type, "AmznSellingPartner.Clients.Values");

            if (this.MinItems is not null)
            {
                csProperty.HasAttribute(nameof(this.MinItems), this.MinItems);
            }

            if (this.MaxItems is not null)
            {
                csProperty.HasAttribute(nameof(this.MaxItems), this.MaxItems);
            }

            if (this.UniqueItems == true)
            {
                csProperty.HasAttribute(nameof(this.UniqueItems));
            }

            return csProperty;
        }
    }

    internal class AmznParameterItemsEnum : AmznParameterEnum
    {
        public string CollectionFormat { get; set; }

        public AmznParameterItem Items { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csItem = this.Items.OnDeserialized(this.Name, context);
            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType(csItem.Type, "AmznSellingPartner.Clients.Values");

            return csProperty;
        }
    }

    internal class AmznParameterSchema : AmznParameter
    {
        public AmznSchema Schema { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var csProperty = base.OnDeserialized(csRequest, context, parameters)
                                 .HasType(this.Schema.Ref.GetReferenceType());

            csProperty.Name ??= csProperty.Type;

            return csProperty;
        }
    }

    internal class AmznParameterEnum : AmznParameter
    {
        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public AmznEnum[] EnumDefinitions { get; set; }

        public string Default { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
        {
            var typeName = new AmznDefinitionEnum
            {
                Enum = this.Enum,
                EnumDefinitions = this.EnumDefinitions
            }
            .OnDeserialized(this.Name, context)
            .GetTypeName();

            return base.OnDeserialized(csRequest, context, parameters)
                       .HasType(typeName)
                       .HasDefaultValue(this.Default is not null ? $"{typeName}.{this.Default.ToEnumMember()}" : null);
        }
    }

    internal class AmznParameterCsv : AmznParameter
    {
        public string CollectionFormat { get; set; }

        internal override CsProperty OnDeserialized(CsClass csRequest, CsContext context, AmznParameters parameters)
              => base.OnDeserialized(csRequest, context, parameters)
                     .HasType("CsvValue<string>", "AmznSellingPartner.Clients.Values");
    }
}