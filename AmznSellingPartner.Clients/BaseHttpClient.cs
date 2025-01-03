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

        protected async Task<T> SendAsync<T>(BaseHttpRequest request)
        {
            BaseHttpResponse<T> response = await httpClient.SendAsync(request);

            return response.Value;
        }
    }
}
