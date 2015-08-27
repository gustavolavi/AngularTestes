using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Models;

namespace Test.Controllers
{
    public class ValuesController : ApiController
    {
        IList<Endereco> endereco = new Endereco[] 
            {
                new Endereco(){Id=1,Estado="Rio de janeiro",Rua="São jose",Bairro="Centro",UF="RJ",Numero=70},
                new Endereco(){Id=2,Estado="Duque de Caxias",Rua="De casa",Bairro="Xérem",UF="RJ",Numero=14},
                new Endereco(){Id=3,Estado="qualquer",Rua="Rua João Sem Braço",Bairro="Bota Caida",UF="SP",Numero=1000}
            };

        // GET api/values
        public IEnumerable<Endereco> Get()
        {
            return endereco;
        }

        // GET api/values/5
        public Endereco Get(int id)
        {
            return endereco.FirstOrDefault(x=>x.Id == id);
        }

        // POST api/values
        public void Post(Endereco e)
        {
            endereco.Add(e); 
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            endereco.Remove(endereco.First(x=>x.Id == id));
        }
    }
}