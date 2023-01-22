using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public static class WebUtility
    {
        // A utility method to make a POST request asynchronously and return the response.
        public static async Task<string> Post(string Url, FormUrlEncodedContent data)
        {
            string result;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(Url, data))
                {
                    using (HttpContent content = response.Content)
                    {
                        result = await content.ReadAsStringAsync();
                    }
                }
            }
            return result;
        }
    }
}