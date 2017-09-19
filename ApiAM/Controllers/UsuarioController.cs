using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Services;
using System.Web.SessionState;

namespace ApiAM.Controllers
{

    public class UsuarioController : ApiController
    {

        public IEnumerable<Usuario> Get()
        { 
            return DAO.UsuarioDAO.Listar();
        }

        // GET: api/Usuario/5
        public Usuario Get(int id)
        {
            return DAO.UsuarioDAO.PesquisarId(id);
        }

        // POST: api/Usuario
        public IHttpActionResult Post(Usuario usuario)
        {
            DAO.UsuarioDAO.Cadastrar(usuario);
            var uri = Url.Link("DefaultApi", new { id = usuario.Id });
            return Created<Usuario>(new Uri(uri), usuario);
        }

        // PUT: api/Usuario/5
        public IHttpActionResult Put(int id, Usuario usuario)
        {
            DAO.UsuarioDAO.Editar(id, usuario);
            usuario.Id = id;
            return Ok(usuario);
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
            DAO.UsuarioDAO.Deletar(id);
        }
    }
}
