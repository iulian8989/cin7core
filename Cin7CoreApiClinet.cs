using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using log4net;
namespace CIN7Core_MFT_EDI
{
    public class Cin7CoreApiClinet : IDisposable
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Cin7CoreApiClinet));
        private HttpClient client;
        private bool disposed = false;
        private string baseUrl = "https://inventory.dearsystems.com/ExternalApi/v2/";
        public Cin7CoreApiClinet(string accountId, string accessKeyId)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("api-auth-accountid", accountId);
            client.DefaultRequestHeaders.Add("api-auth-applicationkey", accessKeyId);
            log.Info("Cin7CoreApiClient initialized.");
        }
        public async Task<string> GetListAsync(string endPoint, Dictionary<string, string> filters)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            foreach (var filter in filters)
            {
                if (!string.IsNullOrEmpty(filter.Value))
                {
                    query[filter.Key] = filter.Value;
                }
            }
            string url = $"{baseUrl}{endPoint}?{query}";
            log.Debug($"Sending GET request to {url}");
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throws an exception if the HTTP response status is not a success code
                log.Info($"Received response from {url}");
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                // Handle HTTP request specific errors here
                log.Error($"HTTP request error: {e.Message}");
                return $"Error: {e.Message}";
            }
            catch (Exception e)
            {
                // Handle other unanticipated errors here
                log.Error($"Unexpected error: {e.Message}");
                return $"Error: {e.Message}";
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed state (managed objects).
                    client.Dispose();
                    log.Info("HTTP client disposed.");
                }
                // Set large fields to null.
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Cin7CoreApiClinet()
        {
            Dispose(false);
        }
    }
}
