using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas.Entidades;

namespace Temperaturas.Base
{
    public class CidadeRepositorio
    {
        private TemperaturasContexto contexto = new TemperaturasContexto();

        public Cidade getCidade(string nome)
        {
            Cidade cidade = contexto.Cidades.Where(c => c.Nome == nome).SingleOrDefault();
            return cidade;
        }

        public bool salvaCidade(string nomeCidade)
        {
            Cidade cidade = new Cidade();
            cidade.Nome = nomeCidade;

            Cidade novaCidade = contexto.Cidades.Add(cidade);
            contexto.SaveChanges();
            if (novaCidade != null)
            {
                return true;
            }
            return false;
        }

        public List<Cidade> getCidades()
        {
            List<Cidade> cidades = contexto.Cidades.ToList();
            return cidades;
        }

        public bool deletaCidade(string nomeCidade)
        {
            Cidade cidade = contexto.Cidades.SingleOrDefault(c => c.Nome == nomeCidade);

            if (cidade != null)
            {
                contexto.Cidades.Remove(cidade);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool limparHistoricoDeTemperaturas(string nomeCidade)
        {
            Cidade cidade = contexto.Cidades.SingleOrDefault(c => c.Nome == nomeCidade);

            if (cidade != null)
            {
                for(int i = 0; i < cidade.Temperaturas.Count; i++)
                {
                    contexto.Temperaturas.Remove(cidade.Temperaturas.ElementAt(i));
                }
                contexto.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Cidade> top3MaximaTemperatura()
        {
            List<Cidade> cidades = contexto.Cidades.Where(c => c.Temperaturas.Any())
                                                   .OrderByDescending(c => c.Temperaturas.OrderByDescending(t => t.Valor).Select(t => t.Valor).FirstOrDefault())
                                                   .Take(3)
                                                   .ToList();
            
            return cidades;
        }

        public void salvaContexto()
        {
            contexto.SaveChanges();
        }
    }
}
