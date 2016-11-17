using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TestEFContext : DbContext
    {
        //public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }

        //definir cual es PK, se fija como la puede mapear con las tablas q existen. Solo hace chequeo de la consistencia no de datos
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfigurarPerfil());
        }
    }

    public class ConfigurarPerfil : EntityTypeConfiguration<Perfil>
    {
        public ConfigurarPerfil()
        {
            HasKey(p => p.ID_Perfil);    //para toda la clase
            this.Property(p => p.ID_Perfil).HasColumnName("ID_Perfil");  //para una prop de la clase. Ponemos el nombre q queremos q aparesca
            this.ToTable("Perfiles");
        }
    }
}
