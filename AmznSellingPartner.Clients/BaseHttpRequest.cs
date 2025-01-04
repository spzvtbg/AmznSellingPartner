namespace AmznSellingPartner.Clients
{
    using AmznSellingPartner.Clients.Attributes;

    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;

    public class BaseHttpRequest
    {
        internal bool Validate(out Dictionary<string, string> errors)
        {
            errors = [];

            return true;
        }

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

            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            foreach (var property in type.GetProperties())
            {
                var parameterAttribute = property.GetCustomAttribute<ParameterAttribute>();

                if (parameterAttribute is not null)
                {
                    var value = property.GetValue(this);

                    parameterAttribute.SetValue(httpRequestMessage, value);
                }
            }

            return httpRequestMessage;
        }

        public static implicit operator HttpRequestMessage(BaseHttpRequest request)
            => request?.CreateRequestMessage();
    }
}