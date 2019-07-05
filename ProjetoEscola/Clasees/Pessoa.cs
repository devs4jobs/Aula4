using System.Collections.Generic;

namespace ProjetoEscola.Clasees
{
    abstract class Pessoa 
    {

        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Nacionaliddade { get; set; }
        public string DataNasc { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }

        

        #region Construtores
        public Pessoa(string nome, string sexo, string nacionaliddade, string dataNasc, string pais, string cidade, int idade)
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

        public abstract void Cadastrar(List<Turma> lstTurmas,Turma turma);
        public abstract void Cadastrar();
        public abstract void CadastrarCodigoTurma(string codTurma);

    }
}
