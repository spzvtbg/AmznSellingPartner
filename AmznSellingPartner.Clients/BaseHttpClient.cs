namespace AmznSellingPartner.Clients
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class BaseHttpClient
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public BaseHttpClient(Uri baseAddress) 
            => httpClient.BaseAddress = baseAddress;

        protected static async Task<T> SendAsync<T>(BaseHttpRequest request) where T : BaseHttpResponse<T>, new() 
        {
            if (!request.Validate(out var errors))
            {
                return errors as T;
            }

            var response = default(T);

            using (HttpRequestMessage httpRequestMessage = request)
            {
                using (var httpResponseMessage = await httpClient.SendAsync(request))
                {
                    response = (T)httpResponseMessage;
                }
            }

            return response;
        }
    }
}
