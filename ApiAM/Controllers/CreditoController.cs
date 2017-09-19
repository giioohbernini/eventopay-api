using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAM.Controllers
{
    public class CreditoController : ApiController
    {
        // POST: api/Credito
        public IHttpActionResult Post(int IdUsuario, double Valor)
        {
            DAO.UsuarioDAO.ComprarCredito(IdUsuario,Valor);
            return Ok(Valor);
        }
    }
}
