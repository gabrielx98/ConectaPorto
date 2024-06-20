using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using ConectaPorto.Api;
using Microsoft.AspNetCore.Builder;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Legacy;

namespace ConectaPorto.Testes
{
    public class Tests
    {
        private HttpClient _client;
        private TestServer _server;

        [SetUp]
        public void Setup()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TearDown]
        public void TearDown()
        {
            _client.Dispose();
            _server.Dispose();
        }

        [Test]
        public async Task GetWeatherForecastNotFound()
        {
            // Arrange
            var requestUri = $"/WeatherForecast";

            // Act
            var response = await _client.GetAsync(requestUri);

            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            Console.WriteLine("Not Found");

            // Assert
            ClassicAssert.AreEqual(HttpStatusCode.NotFound, response.StatusCode); // Verifica se o c�digo de status � 404 (NotFound)

            
        }

        [Test]
        public async Task GetWeatherForecastOk()
        {
            // Arrange
            var requestUri = $"/WeatherForecast";

            // Act
            var response = await _client.GetAsync(requestUri);

            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            Console.WriteLine("OK");

            // Assert
            //response.EnsureSuccessStatusCode();
            ClassicAssert.AreEqual(HttpStatusCode.OK, response.StatusCode); // Verifica se o c�digo de status � 404 (NotFound)


        }
    } 
}