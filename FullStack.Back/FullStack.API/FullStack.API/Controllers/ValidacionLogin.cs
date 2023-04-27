using Microsoft.AspNetCore.Mvc;

namespace FullStack.API.Controllers
{
    public class ValidacionLogin : Controller
    {
        private readonly ILogger<ValidacionLogin> _logger;

        public ValidacionLogin(ILogger<ValidacionLogin> logger)
        {
            _logger = logger;
        }
        //http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?usuario=5001&password=5001u
        [HttpGet(Name = "getUser")]

        public async Task<string> Get(string usuario, string password)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?usuario=" + usuario + "&password=" + password;

                
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("Emisores")]

        public async Task<string> Get()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/GetEmisor";

                    HttpResponseMessage response = await httpClient.GetAsync(url);

                 
                    string responseBody = await response.Content.ReadAsStringAsync();

                 
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

   
    }
}
