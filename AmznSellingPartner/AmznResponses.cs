namespace AmznSellingPartner
{
    using System.Collections.Generic;

    internal class AmznResponses : AmznUnhandled<AmznResponse>
    {
        internal IEnumerable<CsProperty> OnDeserialized(CsContext context)
        {
            foreach (var (status, response) in this)
            {
                yield return new CsProperty
                {
                    Name = $"Is{status}",
                    Type = "bool"
                };

                foreach (var csProperty in response.OnDeserialized(status, context))
                {
                    yield return csProperty;
                }
            }
        }
    }
}