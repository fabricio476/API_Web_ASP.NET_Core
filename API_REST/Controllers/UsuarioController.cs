using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc; //ApiController - ControllerBase
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>();


        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(usuarios);
        }



        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
            return Created("", usuario);
        }
       
         


    }
}