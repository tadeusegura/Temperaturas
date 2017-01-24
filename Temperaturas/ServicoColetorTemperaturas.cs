using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Temperaturas.Entidades;
using Newtonsoft.Json;
using System.Threading;
using Temperaturas.Base;

namespace Temperaturas.Web
{
    public class ServicoColetorTemperaturas
    {
        private string chaveAPI = "4ea8588b";
        
        public ServicoColetorTemperaturas()
        {
            Thread t = new Thread(threadColetor);
            t.Start();
        }

        private void threadColetor()
        {
            while (true)
            {
                Thread.Sleep(20000);
                CidadeRepositorio cidadeRep = new CidadeRepositorio();
                List<Cidade> cidades = cidadeRep.getCidades();
                
                foreach (Cidade cidade in cidades)
                {
                    coletaTemperatura(cidadeRep, cidade);
                    Thread.Sleep(1000);
                }
            }
        }

        public void coletaTemperatura(CidadeRepositorio cidadeRep, Cidade cidade)
        {
            string cidadeURL = System.Web.HttpUtility.UrlEncode(cidade.Nome);

            var stringJSON = new WebClient().DownloadString("https://api.hgbrasil.com/weather/?format=json&city_name=" + cidade.Nome + "&key=" + chaveAPI);

            dynamic objetoJSON = JsonConvert.DeserializeObject(stringJSON);

            string cidadeSTR = objetoJSON["results"]["city_name"].ToString();
            if (cidade.Nome != cidadeSTR)
            {
                //nome da cidade buscada não corresponde a cidade obtida
                return;
            }

            float valor = float.Parse(objetoJSON["results"]["temp"].ToString());
            DateTime data = DateTime.Parse(objetoJSON["results"]["date"].ToString() + " " + objetoJSON["results"]["time"].ToString());

            Temperatura temperatura = new Temperatura();
            temperatura.Valor = valor;
            temperatura.Data = data;

            cidade.Temperaturas.Add(temperatura);
            cidadeRep.salvaContexto();
        }
    }
}
