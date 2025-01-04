namespace AmznSellingPartner.Clients
{
    using AmznSellingPartner.Clients.Attributes;

    using System;
    using System.Net.Http;

    public class BaseHttpRequest
    {
        private HttpRequestMessage CreateRequestMessage()
        {
            var httpRequestMessage = default(HttpRequestMessage);
            var type = this.GetType();

            foreach (var attribute in type.GetCustomAttributes(true))
            {
                if (attribute is HttpMethodAttribute httpAttribute)
                {
                    httpRequestMessage = new HttpRequestMessage(httpAttribute.Method, httpAttribute.Path);

                    break;
                }
            }

            if (httpRequestMessage is null)
            {
                throw new InvalidOperationException($"Http attribute was not found on type: {type.Name}");
            }

            return httpRequestMessage;
        }

        public static implicit operator HttpRequestMessage(BaseHttpRequest request)
            => request?.CreateRequestMessage();
    }
}