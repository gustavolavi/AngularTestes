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
    public class OperadoraController : ApiController
    {
        Context db = new Context();
        // GET api/controle
        public IEnumerable<Operadora> Get()
        {
            return db.Operadora.ToList();
        }

        // GET api/controle/5
        public Operadora Get(int id)
        {
            return db.Operadora.Find(id);
        }

        // POST api/controle
        public void Post(Operadora value)
        {
            db.Operadora.Add(value);
            db.SaveChanges();
        }

        // PUT api/controle/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/controle/5
        public void Delete(int id)
        {
            var d = db.Operadora.Find(id);
            db.Operadora.Remove(d);
            db.SaveChanges();
        }
    }
}
