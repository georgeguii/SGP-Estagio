using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace SpgEstagioTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("CorsApi")]
    public class HomeController : ControllerBase
    {
        [HttpGet("employee")]
        [Authorize(Roles = "EMPLOYEE")]

        public string Employee() => "Voc� � um empregado";


        [HttpGet("manager")]
        [Authorize(Roles = "MANAGER")]

        public string Manager() => "Voc� � um gerente";       
    }
}