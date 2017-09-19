using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAM.Controllers
{
    public class TransacaoController : ApiController
    {

        // GET: api/Transacao/5
        public List<Transacao> Get(int id_usuario)
        {
            return DAO.TransacaoDAO.PesquisarIdUsuario(id_usuario);
        }

        // POST: api/Transacao
        public IHttpActionResult Post(Transacao transacao)
        {
            DAO.TransacaoDAO.Cadastrar(transacao);
            var uri = Url.Link("DefaultApi", new { id = transacao.Id });
            return Created<Transacao>(new Uri(uri), transacao);
        }
    }
}
