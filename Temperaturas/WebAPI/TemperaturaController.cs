using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Temperaturas.Base;
using Temperaturas.Entidades;

namespace Temperaturas.Web.WebAPI
{
    public class TemperaturaController : ApiController
    {
        [System.Web.Http.HttpGet]
        public Cidade getCidade(string nomeCidade)
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            Cidade cidade = cidadeRep.getCidade(nomeCidade);
            return cidade;
        }

        [System.Web.Http.HttpPost]
        public bool salvaCidade(string nomeCidade)
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            bool foiSalva = cidadeRep.salvaCidade(nomeCidade);
            return foiSalva;
        }

        [System.Web.Http.HttpGet]
        public List<Cidade> getTop3CidadesComMaiorTemperatura()
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            List<Cidade> cidades = cidadeRep.top3MaximaTemperatura();
            return cidades;
        }

        [System.Web.Http.HttpDelete]
        public bool deletaCidade(string nomeCidade)
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            bool foiDeletada = cidadeRep.deletaCidade(nomeCidade);
            return foiDeletada;
        }

        [System.Web.Http.HttpPatch]
        public bool limpaHistoricoCidade(string nomeCidade)
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            bool foiLimpado = cidadeRep.limparHistoricoDeTemperaturas(nomeCidade);
            return foiLimpado;
        }
    }
}
