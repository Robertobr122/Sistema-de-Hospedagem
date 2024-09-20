using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(){
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
    
        public Pessoa (string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome {get; set;}
        public string Sobrenome {get; set;}
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    
    }
}