namespace AmznSellingPartner
{
    internal class AmznDefinitions : AmznUnhandled<AmznDefinition>
    {
        internal void OnDeserialized(CsContext context)
        {
            foreach (var (name, definition) in this)
            {
                definition.OnDeserialized(name, context);
            }
        }
    }
}