using ApiAM.Context;
using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAM.DAO
{
    public class TransacaoDAO
    {
        public static List<Transacao> Listar()
        {
            using (TransacaoContexto ctx = new TransacaoContexto())
            {
                return ctx.Transacao.ToList();
            }
        }
        public static void Cadastrar(Transacao transacao)
        {
            Usuario _usuario = DAO.UsuarioDAO.PesquisarId(transacao.Id_Usuario);
            Evento _evento = DAO.EventoDAO.PesquisarId(transacao.Id_Evento);
            Usuario _adm = DAO.UsuarioDAO.PesquisarId(_evento.Id_adm);

            if ((_usuario.Saldo-transacao.Valor)>=0)
            {
                _adm.Saldo += transacao.Valor;
                _usuario.Saldo -= transacao.Valor;
                DAO.UsuarioDAO.Editar(_usuario.Id, _usuario);
                DAO.UsuarioDAO.Editar(_adm.Id, _adm);
                using (TransacaoContexto ctx = new TransacaoContexto())
                {
                    ctx.Transacao.Add(transacao);
                    ctx.SaveChanges();
                }
            }
        }
       /* 
        public static void Editar(int Id, Transacao transacao)
        {
            using (TransacaoContexto ctx = new TransacaoContexto())
            {
                Transacao _transacao = ctx.Transacao.Find(Id);
                _transacao.Id_Evento = transacao.Id_Evento;
                _transacao.Id_Usuario = transacao.Id_Usuario;
                _transacao.Valor = transacao.Valor;
                ctx.SaveChanges();
            }
        }
        */
        public static void Deletar(int Id)
        {
            using (TransacaoContexto ctx = new TransacaoContexto())
            {
                ctx.Transacao.Remove(ctx.Transacao.Find(Id));
                ctx.SaveChanges();
            }
        }
        public static List<Transacao> PesquisarIdUsuario(int Id_usuario)
        {
            using (TransacaoContexto ctx = new TransacaoContexto())
            {
                return ctx.Transacao.Where(a => a.Id_Usuario == Id_usuario).ToList();
            }
        }
    }
}