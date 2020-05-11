using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickJobsMVC.Models
{
    public class CadastroUsuarioBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public DateTime DataNasc { get; set; }

        public CadastroUsuarioBase() { }

        public CadastroUsuarioBase(string nome, string sobrenome, int cpf, string endereco, string complemento, DateTime dataNasc)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Endereco = endereco;
            Complemento = complemento;
            DataNasc = dataNasc;
        }
    }
}
