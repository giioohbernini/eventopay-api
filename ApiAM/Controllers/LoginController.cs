using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAM.Controllers
{
    public class LoginController : ApiController
    {
        // POST: api/Login
        public Usuario Post(string Nome, string Senha)
        {
            return DAO.UsuarioDAO.Login(Nome, Senha);
        }
    }
}
