using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas.Entidades;

namespace Temperaturas.Base
{
    public class TemperaturasContexto : DbContext
    {
        public TemperaturasContexto() : base("name=temperaturasDB")
        {

        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Temperatura> Temperaturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
