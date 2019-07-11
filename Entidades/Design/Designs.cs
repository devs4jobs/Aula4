using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades.Design
{
    // classe com metodos para manter o design
    class Designs
    {
        public void MudarCores()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public void MudarCores1()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public void MudarCores2()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public void MudarBack()
        {
            Console.Title = ("CADASTRO ESCOLAR PARA PROFESSORES E ALUNO");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
        }
        public void WriteLineCenter(string a)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
        }
    }
}
