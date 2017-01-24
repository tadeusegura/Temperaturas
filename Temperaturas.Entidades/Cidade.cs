using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas.Entidades
{
    public class Cidade : ClasseBase
    {
        public string Nome { get; set; }
        
        public virtual ICollection<Temperatura> Temperaturas { get; set; }
    }
}
