using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace Temperaturas.Web.WebAPI
{
    public class HgBrasilController : ApiController
    {
        [HttpGet]
        public void comecaColetor()
        {
            ServicoColetorTemperaturas servico = new ServicoColetorTemperaturas();
        }
    }
}
