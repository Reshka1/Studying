using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient.Get
{
    [TestClass]
    public class TestGetEndPoint
    {
        private string getUrl:"http://locahost:8080/laptop-bag/webapi/api/all" ;
        [TestMethod]
        public void TestGetAllEndPoint()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.GetAsync();
            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndPointWithUr();

        Uri getUri = new Uri (getUrl);
        Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);
        HttpResponseMessage httpResponseMessage = httpResponse.Result;
        Console.WriteLine(httpResponseMessage.ToString());
        HttpStatusCode statusCode = httpResponseMessage.StatusCode;
        Console.WriteLine("Status Code =>" + statusCode);
        Console.WriteLine("Status Code =>" + (int)statusCode);

        HttpContent responseContent = httpResponseMessage.Content;
        Task<string> responseData = responseContent.ReadAsStringAsync();
        string data = responseData.Result;
        Console.WriteLine(data);

        httpCleint.Dispose();

    }
    [TestMethod]
    public void TestGetAllEndPointWithInvalidUrl()
    {
        Uri getUri = new Uri(getUrl + "/random");
        Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);
        HttpResponseMessage httpResponseMessage = httpResponse.Result;
        Console.WriteLine(httpResponseMessage.ToString());
        HttpStatusCode statusCode = httpResponseMessage.StatusCode;
        Console.WriteLine("Status Code =>" + statusCode);
        Console.WriteLine("Status Code =>" + (int)statusCode);

        HttpContent responseContent = httpResponseMessage.Content;
        Task<string> responseData = responseContent.ReadAsStringAsync();
        string data = responseData.Result;
        Console.WriteLine(data);

        httpCleint.Dispose();
    }

    [TestMethod]
    public void TestGetAllEndPointInJsonFormat()
    {
        HttpClient httpClient = new HttpClient();
        HttpRequestHeaders requestHeaders =  httpClient.DefaultRequestHeaders;
        requestHeaders.Add("Accept", "application/json");

        httpCleint.Dispose();
    }
}

