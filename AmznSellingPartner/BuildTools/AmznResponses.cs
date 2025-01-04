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

            foreach (var property in properties.DistinctBy(x => x.Type))
            {
                yield return property;
            }
        }
    }
}