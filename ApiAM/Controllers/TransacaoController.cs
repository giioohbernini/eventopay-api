using ApiAM.Models;
using ApiAM.ViewModel;
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
        public List<TransacaoViewModel> Get(int id)
        {
            return DAO.TransacaoDAO.PesquisarIdUsuario(id);
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
