using System.Collections.Generic;

namespace ProjetoEscola.Clasees
{
    abstract class Pessoa : Turma
    {

        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string Nacionaliddade { get; set; }
        public string DataNasc { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }

        #region Construtores
        public Pessoa(string nome, char sexo, string nacionaliddade, string dataNasc, string pais, string cidade, int idade)
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

        public abstract void ExibirListas( List<object> list);

        public abstract object Cadastrar();
        
    }
}
