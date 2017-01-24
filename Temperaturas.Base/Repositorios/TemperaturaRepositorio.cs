using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas.Entidades;

namespace Temperaturas.Base
{
    public class TemperaturaRepositorio
    {
        private TemperaturasContexto contexto = new TemperaturasContexto();

        public void adicionaTemperatura(string nomeCidade, float valor)
        {
            Cidade cidade = contexto.Cidades.Where(c => c.Nome == nomeCidade).SingleOrDefault();

            Temperatura temperatura = new Temperatura();
            temperatura.Data = DateTime.Now;
            temperatura.Valor = valor;

            cidade.Temperaturas.Add(temperatura);
            contexto.SaveChanges();
        }
    }
}
