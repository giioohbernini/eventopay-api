using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAM.Controllers
{
    public class EventoController : ApiController
    {
        // GET: api/Evento
        public IEnumerable<Evento> Get()
        {

            return DAO.EventoDAO.Listar();
        }

        // GET: api/Evento/5
        public Evento Get(int id)
        {

            return DAO.EventoDAO.PesquisarId(id);
        }

        // POST: api/Evento
        public IHttpActionResult Post(Evento evento)
        {
            DAO.EventoDAO.Cadastrar(evento);
            var uri = Url.Link("DefaultApi", new { id = evento.Id });
            return Created<Evento>(new Uri(uri), evento);
        }

        // PUT: api/Evento/5
        public IHttpActionResult Put(int id, Evento evento)
        {
            DAO.EventoDAO.Editar(id, evento);
            evento.Id = id;
            return Ok(evento);
        }

        // DELETE: api/Evento/5
        public void Delete(int id)
        {
            DAO.EventoDAO.Deletar(id);
        }
    }
}
