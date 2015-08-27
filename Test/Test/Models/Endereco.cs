using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string UF { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}