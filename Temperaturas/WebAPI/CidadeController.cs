using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Temperaturas.Base;
using Temperaturas.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Temperaturas.Web.WebAPI
{
    public class CidadeController : ApiController
    {
        [System.Web.Http.HttpGet]
        public List<Cidade> getCidades()
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            List<Cidade> cidades = cidadeRep.getCidades();
            return cidades;
        }

        [System.Web.Http.HttpGet]
        public Cidade getCidade(string nomeCidade)
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            Cidade cidade = cidadeRep.getCidade(nomeCidade);
            return cidade;
        }

        [System.Web.Http.HttpPost]
        public bool salvaCidade([FromBody]string nomeCidade)
        {
            try
            {
                CidadeRepositorio cidadeRep = new CidadeRepositorio();
                bool foiSalva = cidadeRep.salvaCidade(nomeCidade);
                return foiSalva;
            }
            catch
            {
                return false;
            }
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
        public bool limpaHistoricoCidade([FromBody]string nomeCidade)
        {
            CidadeRepositorio cidadeRep = new CidadeRepositorio();
            bool foiLimpado = cidadeRep.limparHistoricoDeTemperaturas(nomeCidade);
            return foiLimpado;
        }

        [System.Web.Http.HttpPost]
        public bool criaCidadePorCEP([FromBody]string CEP)
        {
            //string objJSON = GET("https://viacep.com.br/ws/" + CEP + "/json/");

            //CidadeRepositorio cidadeRep = new CidadeRepositorio();
            bool foiLimpado = true;//cidadeRep.limparHistoricoDeTemperaturas(nomeCidade);
            return foiLimpado;
        }
    }
}
