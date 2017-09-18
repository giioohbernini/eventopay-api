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
        // GET: api/Transacao
        public IEnumerable<Transacao> Get()
        {

            return DAO.TransacaoDAO.Listar();
        }

        // GET: api/Transacao/5
        public Transacao Get(int id)
        {

            return DAO.TransacaoDAO.PesquisarId(id);
        }

        // POST: api/Transacao
        public IHttpActionResult Post(Transacao transacao)
        {
            DAO.TransacaoDAO.Cadastrar(transacao);
            var uri = Url.Link("DefaultApi", new { id = transacao.Id });
            return Created<Transacao>(new Uri(uri), transacao);
        }

         // PUT: api/Transacao/5
        public IHttpActionResult Put(int id, Transacao transacao)
        {
           /* DAO.TransacaoDAO.Editar(id, transacao);
            transacao.Id = id;*/
            return Ok("ok ok ");
        }

        // DELETE: api/Transacao/5
        public void Delete(int id)
        {
            DAO.TransacaoDAO.Deletar(id);
        }
    }
}
