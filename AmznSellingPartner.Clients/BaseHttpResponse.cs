namespace AmznSellingPartner.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public class BaseHttpResponse
    {
        public BaseHttpResponse()
        {

        }

        private BaseHttpResponse(Dictionary<string, string> errors) 
            => this.ValidationErrors = errors;

        public bool Succeeded { get; set; }

        public Dictionary<string, string> ValidationErrors { get; }

        public static implicit operator BaseHttpResponse(HttpResponseMessage response)
            => throw new NotImplementedException();

        public static implicit operator BaseHttpResponse(Dictionary<string, string> errors)
            => new BaseHttpResponse(errors);
    }
}