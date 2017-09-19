using ApiAM.Context;
using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAM.DAO
{
    public class EventoDAO
    {
        public static List<Evento> Listar()
        {
            using (EventoContexto ctx = new EventoContexto())
            {
                return ctx.Evento.ToList();
            }
        }
        public static void Cadastrar(Evento evento)
        {
            using (EventoContexto ctx = new EventoContexto())
            {
                ctx.Evento.Add(evento);
                ctx.SaveChanges();
            }
        }
        public static void Editar(int Id, Evento evento)
        {
            using (EventoContexto ctx = new EventoContexto())
            {
                Evento _evento = ctx.Evento.Find(Id);

                _evento.Descricao = evento.Descricao;
                _evento.Local = evento.Local;
                _evento.ValorSugerido = evento.ValorSugerido;
                _evento.ValorTotal = evento.ValorTotal;
                ctx.SaveChanges();
            }
        }
        public static void Deletar(int Id)
        {
            using (EventoContexto ctx = new EventoContexto())
            {
                ctx.Evento.Remove(ctx.Evento.Find(Id));
                ctx.SaveChanges();
            }
        }
        public static Evento PesquisarId(int Id)
        {
            using (EventoContexto ctx = new EventoContexto())
            {
                return ctx.Evento.Find(Id);
            }
        }

        public static List<Evento> ListarEventos(int Id_usuario)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                Usuario _usuario = ctx.Usuario.Find(Id_usuario);
                return _usuario.Eventos.ToList();
            }
        }

    }
}