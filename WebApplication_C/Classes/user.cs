using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_C.Classes
{
    public class user
    {
        public string cpf {get; set; }
        public string senha { get;set;}
    }

    public class fornecedor
    {
        public string cnpj { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }

    public class cliente
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
    }
}