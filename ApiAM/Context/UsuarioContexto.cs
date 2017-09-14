namespace ApiAM.Context
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UsuarioContexto : DbContext
    {
        // Your context has been configured to use a 'UsuarioContexto' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ApiAM.Models.UsuarioContexto' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UsuarioContexto' 
        // connection string in the application configuration file.
        public UsuarioContexto()
            : base("name=DefaultContexto")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Usuario> Usuario { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}