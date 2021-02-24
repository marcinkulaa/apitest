using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using testApi.TestData;
using testApi.Models;

namespace testApi
{
    public class Tests
    {
        private const string uri = "https://jsonplaceholder.typicode.com/";
        private RestClient client;
        
        [SetUp]
        public void Setup()  
        {
            client = new RestClient(uri);
        }

        [Test]
        public async Task GetAllUsers()
        {
            var expected = JsonSerializer.Deserialize<List<User>>(TestInputData.JsonTestData, new JsonSerializerOptions
            { 
                PropertyNameCaseInsensitive = true
            });
            var restRequest = new RestRequest("users", Method.GET);
            
            var response = await client.ExecuteAsync(restRequest);  
            var responseContent = response.Content;
            var actual = JsonSerializer.Deserialize<List<User>>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public async Task VerifyIfUserExists()
        {
            var restRequest = new RestRequest("users", Method.GET);

            var response = await client.ExecuteAsync(restRequest);
            var responseContent = response.Content;
            var actual = JsonSerializer.Deserialize<List<User>>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Assert.IsTrue(actual.Any(u => u.Username == "Bret"));
        }

        [Test]
        public async Task AddUser()
        {
            var restRequest = new RestRequest("posts", Method.POST);
            restRequest.AddJsonBody(new { name = "Tester", username = "Tester User", email = "testeruser@testeruser.testeruser" });

            var response = await client.ExecuteAsync(restRequest);
            int StatusCode = (int)response.StatusCode;


           Assert.AreEqual(201, StatusCode, "Status code is not 201, something went wrong - user was not created" );

        }
    }
}