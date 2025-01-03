namespace AmznSellingPartner.Clients
{
    using System.Net.Http;
    using System;

    public class BaseHttpResponse<T>
    {
        public T Value { get; private set; }

        public static implicit operator BaseHttpResponse<T>(HttpResponseMessage response)
            => throw new NotImplementedException();
    }
}