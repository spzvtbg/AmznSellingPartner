namespace AmznSellingPartner.BuildTools
{
    using System.Collections.Generic;

    internal class AmznHeaders : AmznUnhandled<AmznHeader>
    {
        internal IEnumerable<CsProperty> OnDeserialized(CsContext context)
        {
            foreach (var (name, header) in this)
            {
                yield return header.OnDeserialized(name, context);
            }
        }
    }
}