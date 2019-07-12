using System;
using System.Collections.Generic;

namespace ProjetoEscola.Clasees
{
    abstract class Pessoa 
    {

        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Nacionaliddade { get; set; }
        public DateTime DataNasc { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public uint Idade { get; set; }

        

        #region Construtores
        public Pessoa(string nome, string sexo, string nacionaliddade, DateTime dataNasc, string pais, string cidade, uint idade)
        {
            Nome = nome;
            Sexo = sexo;
            Nacionaliddade = nacionaliddade;
            DataNasc = dataNasc;
            Pais = pais;
            Cidade = cidade;
            Idade = idade;

        }

        public Pessoa() { }

        #endregion

        public abstract object Cadastrar(List<Turma> lstTurmas);
        public abstract void CadastrarCodigoTurma( List<Turma> lstTurma);

     

    }
}
