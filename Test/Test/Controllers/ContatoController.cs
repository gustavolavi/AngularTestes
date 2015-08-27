using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Models;
using Test.Dao;

namespace Test.Controllers
{
    public class ContatoController : ApiController
    {
        Context db = new Context();
        // GET api/controle
        public IEnumerable<Contato> Get()
        {
            var lista = db.Contato.ToList();
            return lista;
        }

        // GET api/controle/5
        public Contato Get(int id)
        {
            return db.Contato.Find(id);
        }

        // POST api/controle
        public void Post(Contato value)
        {
            db.Contato.Add(value);
            db.SaveChanges();
        }

        // PUT api/controle/5
        public void Put(int id, [FromBody]string value)
        {
            db.Contato.ToList();
            db.SaveChanges();
        }

        // DELETE api/controle/5
        public void Delete(int id)
        {
            var d = db.Contato.Find(id);
            db.Contato.Remove(d);
            db.SaveChanges();
        }
    }
}
