using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserAuthenticate.Models;
using UserAuthenticate.Repositories;
using UserAuthenticate.Services;

namespace UserAuthenticate.Controllers
{
    [Route("api/v1/users")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        // PT-BR
        // Por estar utilizando um repositório estatico, não seria necessário o uso do async.
        // Porém, pensando em um uso real, envolvendo uma camada de persistencia de dados com banco de dados, esse método deve ser async.
        // É possível receber uma mensagem de Warning da IDE, compilador, etc a respeito do mé todo Authenticate... Pode ignorar, a principio.
        
        // EN-US
        // As you are using a static repository, it would not be necessary to use async.
        // However, thinking of a real use, involving a data persistence layer with database, this method should be async.
        // It is possible to receive a Warning message from the IDE, compiler, etc regarding the Authenticate method... You can ignore it at first.
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);
            if( user == null)
                return NotFound( new {message = "Invalid username or password"});
            var token = TokenService.GenerateToken(user);
            user.Password = "";
            
            return new
            {
                user = user,
                token = token
            };
        }
        // -----------------------//
        // METODOS APENAS PARA TESTAR
        // METHODS ONLY FOR TESTING
        // -----------------------//
    
        [HttpGet]
        [Route("anonymous")]
        // PERMISSÃO PARA QUALQUER UM ACESSAR
        // PERMISSION FOR ANYONE TO ACCESS
        [AllowAnonymous]
        public string Anonymous() => "Anonymous";

        [HttpGet]
        [Route("authenticated")]
        // PERMISSÃO APENAS PARA AUTENTICADOS
        // PERMISSION FOR AUTHENTICATED ONLY
        [Authorize]
        public string Authenticated() => String.Format("authenticated - {0}" , User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        // PERMISSÃO APENAS PARA AUTENTICADOS E PERTECENTES AS ROLES "employee" e "manager"
        // PERMISSION ONLY FOR AUTHENTICATED AND BELONGING TO "employee" and "manager" ROLES
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Employee";

        [HttpGet]
        [Route("manager")]
        //PERMISSÃO APENAS PARA AUTENTICADOS E PERTECENTES A ROLE "manager"
        //PERMISSION ONLY FOR AUTHENTICATED AND BELONGING TO ROLE "manager"
        [Authorize(Roles = "manager")]
        public string Manager() => "Manager";


    }
}