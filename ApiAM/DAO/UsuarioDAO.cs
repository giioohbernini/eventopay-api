using ApiAM.Context;
using ApiAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAM.DAO
{
    public static class UsuarioDAO
    {
        public static List<Usuario> Listar()
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                return ctx.Usuario.ToList();
            }
        }
        public static void Cadastrar(Usuario usuario)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                ctx.Usuario.Add(usuario);
                ctx.SaveChanges();
            }
        }
        public static void Editar(int Id,Usuario usuario)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                Usuario user = ctx.Usuario.Find(Id);

                user.Nome = usuario.Nome;
                user.Senha = usuario.Senha;
                user.Sexo = usuario.Sexo;
                user.Cpf = usuario.Cpf;
                user.Celular = usuario.Celular;
                user.Saldo = usuario.Saldo;
                ctx.SaveChanges();
            }
        }
        public static void Deletar(int Id)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                ctx.Usuario.Remove(ctx.Usuario.Find(Id));
                ctx.SaveChanges();
            }
        }
        public static Usuario PesquisarId(int Id)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                return ctx.Usuario.Find(Id);
            }
        }
        public static Usuario Login(string nome,string senha)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                return ctx.Usuario.Where(a => a.Nome == nome && a.Senha == senha).FirstOrDefault();
            }
        }
        public static void ComprarCredito(int IdUsuario, double Valor)
        {
            using (UsuarioContexto ctx = new UsuarioContexto())
            {
                Usuario user = ctx.Usuario.Find(IdUsuario);
                user.Saldo += Valor;
                ctx.SaveChanges();
            }
        }

    }
}