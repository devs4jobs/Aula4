using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
    // classe abstrata contendo metodo abstrato
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public long Cpf { get; set; }

      
   
        public abstract void Cadastrar(List<Turma> lstTurmas);
    }

}
