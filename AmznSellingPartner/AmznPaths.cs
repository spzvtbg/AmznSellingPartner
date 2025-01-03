namespace AmznSellingPartner
{
    internal class AmznPaths : AmznUnhandled<AmznPath>
    {
        internal void OnDeserialized(CsContext context, AmznParameters parameters)
        {
            foreach (var (route, path) in this)
            {
                path.OnDeserialized(route, context, parameters);
            }
        }
    }
}