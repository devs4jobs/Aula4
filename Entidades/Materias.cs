using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
    public class Materias
    {
        public string NomeMateria { get; set; }
        public int CodMateria { get; set; }


        public Materias()
        {
        }

        public Materias(string nomeMateria, int codMateria)
        {
            NomeMateria = nomeMateria;
            CodMateria = codMateria;
        }

        public void DefinirMateria(int opcao)
        {
            if (opcao == 1) { NomeMateria = "MATEMATICA"; CodMateria = 1; }
            else if (opcao == 2) { NomeMateria = "PORTUGUES"; CodMateria = 2; }
            else if (opcao == 3) { NomeMateria = "BIOLOGIA"; CodMateria = 3; }
            else if (opcao == 4) { NomeMateria = "GEOGRAFIA"; CodMateria = 4; }
            else if (opcao == 5) { NomeMateria = "INGLES"; CodMateria = 5; }

        }




    }
}
