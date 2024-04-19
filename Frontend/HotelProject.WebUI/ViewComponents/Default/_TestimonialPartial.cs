using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        { 
            var client=_httpClientFactory.CreateClient();
            var responseMessage= await client.GetAsync("http://localhost:5111/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

