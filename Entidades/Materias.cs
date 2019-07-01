using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
    class Materias
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
            if (opcao == 1)
                NomeMateria = "MATEMATICA";
            else if (opcao == 2)
                NomeMateria = "PORTUGUES";
            else if (opcao == 3)
                NomeMateria = "BIOLOGIA";
            else if (opcao == 4)
                NomeMateria = "GEOGRAFIA";
            else if (opcao == 5)
                NomeMateria = "INGLES";   
        }

    }
}
