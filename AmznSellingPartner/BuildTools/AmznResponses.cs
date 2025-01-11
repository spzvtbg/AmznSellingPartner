namespace AmznSellingPartner.BuildTools
{
    using System.Collections.Generic;
    using System.Linq;

    internal class AmznResponses : AmznUnhandled<AmznResponse>
    {
        internal IEnumerable<CsProperty> OnDeserialized(CsContext context)
        {
            foreach (var (name, header) in this.Values.SelectMany(x => x.Headers))
            {
                yield return header.OnDeserialized(name, context);
            }

            var properties = new List<CsProperty>();

            foreach (var (status, response) in this)
            {
                var csProperty = response.OnDeserialized(status, context);

                properties.Add(csProperty);
            }

            var groupedProperties = properties
                .GroupBy(x => x.Type)
                .ToDictionary(x => x.Key, x => x.ToList());
            var responseProperties = new List<CsProperty>();

            foreach (var (type, csProperties) in groupedProperties)
            {
                var csProperty = new CsProperty
                {
                    Name = type.Capitalize(),
                    Type = type,
                };

                foreach (var _csProperty in csProperties)
                {
                    csProperty.HasDescription(_csProperty)
                              .HasAttribute(_csProperty);
                }

                responseProperties.Add(csProperty);
            }

            foreach (var property in responseProperties)
            {
                yield return property;
            }
        }
    }
}