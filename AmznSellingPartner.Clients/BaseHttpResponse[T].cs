namespace AmznSellingPartner.Clients
{
    using System.Net.Http;
    using System;

    public class BaseHttpResponse<T>
    {
        public static implicit operator BaseHttpResponse<T>(HttpResponseMessage response)
            => throw new NotImplementedException();
    }
}