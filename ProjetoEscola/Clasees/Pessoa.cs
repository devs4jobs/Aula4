using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region 
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

        public abstract void ExibirListas( List<object> list);
        

    }
}
