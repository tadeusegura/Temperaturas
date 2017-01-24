using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas.Entidades
{
    public class Temperatura : ClasseBase
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        
    }
}
