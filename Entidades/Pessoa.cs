using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
   public abstract class Pessoa 
    {
        public string Nome { get; set; }
        public int Idade { get;  set; }
        public string Sexo { get;  set; }
        public long Cpf { get;  set; }


        public Pessoa(List<Turma> lstTurmas, Turma turma)
        {

        }
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade, string sexo, long cpf)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Cpf = cpf;
        }

        public abstract void Cadastrar(List<Turma> lstTurmas);

     
    }
    
}
