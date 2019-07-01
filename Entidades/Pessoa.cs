using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get;  set; }
        public char Sexo { get;  set; }
        public string Cpf { get;  set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, char sexo, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Cpf = cpf;
        }
    }
}
