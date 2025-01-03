namespace AmznSellingPartner.Clients
{
    using System;
    using System.Net.Http;

    public class BaseHttpRequest
    {
        public static implicit operator HttpRequestMessage(BaseHttpRequest request)
            => throw new NotImplementedException();
    }
}