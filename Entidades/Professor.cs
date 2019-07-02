using System;
using System.Collections.Generic;
using System.Text;
using CadastroEscolar.Entidades.Enums;
namespace CadastroEscolar.Entidades
{
    class Professor : Pessoa
    {
        public int Identificacao { get; private set; }
        public int Salario { get; set; }
        public List<Materias> lstMaterias { get; set; } = new List<Materias>();
        public List<Classes> lstCodTurmas { get; set; } = new List<Classes>();
        int i = 0;
        public Professor()
        {

        }

        public Professor(int identificacao, int salario)
        {
            Identificacao = identificacao;
            Salario = salario;
        }

        override public object Cadastrar()
        {
            Professor p = new Professor();

            Console.WriteLine("DIGITE O NOME DO PROFESSOR");
            p.Nome = Console.ReadLine();

            Console.WriteLine("DIGITE A IDADE DO PROFESSOR:");
            p.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("QUAL O SEXO DO PROFESSOR?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
            p.Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("DIGITE O CPF DO PROFESSOR:");
            p.Cpf = Console.ReadLine().ToUpper();

            Console.WriteLine("CRIE UMA IDENTIFICAÇÃO PARA O PROFESSOR: ");
            p.Identificacao = int.Parse(Console.ReadLine());


            Console.WriteLine("CADASTRE AS MATERIAS QUE O PROFESSOR DA AULA");
            Console.WriteLine("QUANTAS MATERIAS DESEJA CADASTRAR PARA ESTE PROFESSOR?");
            int num = int.Parse(Console.ReadLine());

            for ( i = 0; i < num; i++)
            {
                Materias m = new Materias();

                Console.WriteLine($"DIGITE 1 PARA MATEMATICA\nDIGITE 2 PARA PORTUGUES\nDIGITE 3 PARA BIOLOGIA\nDIGITE 4 PARA GEOGRAFIA\nDIGITE 5 PARA INGLES");
                int decisao = int.Parse(Console.ReadLine());

                switch (decisao)
                {
                    case 1: Console.WriteLine("MATEMATICA");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        break;

                    case 2: Console.WriteLine("PORTUGUES");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        break;

                    case 3: Console.WriteLine("BIOLOGIA");
                            m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                            break;

                    case 4: Console.WriteLine("GEOGRAFIA");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        break;

                    case 5: Console.WriteLine("INGLES");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        break;

                    default:
                        break;
                }  
            }
            Console.WriteLine("ESSE PROFESSOR DA AULA PARA QUANTAS TURMAS?");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i <num; i++)
            {
                Console.WriteLine("QUAL É A TURMA DO PROFESSOR? A,B,C,D ou E");
                Classes C = Enum.Parse<Classes>(Console.ReadLine().ToUpper());
                lstCodTurmas.Add(C);
            }
            return p;
        }

    }
}
