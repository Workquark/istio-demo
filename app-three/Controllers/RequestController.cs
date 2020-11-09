using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app_three.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController: ControllerBase
    {
        private readonly IHttpClientFactory factory;
        private HttpClient httpClient;
        public RequestController(IHttpClientFactory factory)
        {
            this.factory = factory;
            this.httpClient = factory.CreateClient("request");
        }
        public async Task<IActionResult> Get()
        {
            HttpResponseMessage responseMessage = await this.httpClient.GetAsync("/request");
            string response = await responseMessage.Content.ReadAsStringAsync();
            return Ok($"{response} <= three ");
        }
    }
}