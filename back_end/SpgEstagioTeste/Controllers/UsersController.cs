using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SpgEstagioTeste.Models.Contracts;
using SpgEstagioTeste.Models.DTOS;

namespace SpgEstagioTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("CorsApi")]
    public class UsersController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserCreateDTO userDTO,[FromServices] IUserService userService)
        {

            var user = await userService.Find(userDTO.Email);

            if (user != null) return Conflict();

            await userService.Register(userDTO.Map());
            return Ok();
        }


        [HttpPost("auth")]
        public async Task<IActionResult> Authentication([FromBody] UserAuthenticationDTO userDTO, [FromServices] IUserService userService)
        {

            var user = await userService.Find(userDTO.Email);
            if (user == null) return NotFound();
            if (userDTO.Password != user.Password) return Unauthorized();

            var token = userService.GenerateToken(user);
            
            return Ok(new {token});
        }
    }
}