using System;
using System.Collections.Generic;
using System.Text;
using CadastroEscolar.Entidades.Design;
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
        #region "CADASTRO INFORMAÇÔES PROFESSORES"
        override public object Cadastrar()
        {
            Professor p = new Professor();
            Designs d = new Designs();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE O NOME DO PROFESSOR");
            Console.WriteLine("");
            d.MudarCores1();
            p.Nome = Console.ReadLine();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE A IDADE DO PROFESSOR:");
            Console.WriteLine("");
            d.MudarCores1();
            p.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("QUAL O SEXO DO PROFESSOR?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
            Console.WriteLine("");
            d.MudarCores1();
            p.Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE O CPF DO PROFESSOR:");
            Console.WriteLine("");
            d.MudarCores1();
            p.Cpf = Console.ReadLine().ToUpper();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("CRIE UMA IDENTIFICAÇÃO PARA O PROFESSOR: ");
            Console.WriteLine("");
            d.MudarCores1();
            p.Identificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("CADASTRE AS MATERIAS QUE O PROFESSOR DA AULA");
            Console.WriteLine("QUANTAS MATERIAS DESEJA CADASTRAR PARA ESTE PROFESSOR?");
            Console.WriteLine("");
            d.MudarCores1();
            int num = int.Parse(Console.ReadLine());

            for ( i = 0; i < num; i++)
            {
                Materias m = new Materias();

                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine($"DIGITE 1 PARA MATEMATICA\nDIGITE 2 PARA PORTUGUES\nDIGITE 3 PARA BIOLOGIA\nDIGITE 4 PARA GEOGRAFIA\nDIGITE 5 PARA INGLES");
                Console.WriteLine("");
                d.MudarCores1();
                int decisao = int.Parse(Console.ReadLine());

                switch (decisao)
                {
                    case 1:
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("MATEMATICA");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        Console.WriteLine("");       
                        break;

                    case 2:
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("PORTUGUES");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("BIOLOGIA");
                            m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("GEOGRAFIA");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("INGLES");
                        m.DefinirMateria(decisao);
                        lstMaterias.Add(m);
                        Console.WriteLine("");
                        break;

                    default:
                        break;
                }  
            }
            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("ESSE PROFESSOR DA AULA PARA QUANTAS TURMAS?");
            Console.WriteLine("");
            d.MudarCores1();
            num = int.Parse(Console.ReadLine());
            
            


            for (i = 0; i <num; i++)
            {
                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine("QUAL É A TURMA DO PROFESSOR? A,B,C,D ou E");
                Console.WriteLine("");
                d.MudarCores1();
                Classes C = Enum.Parse<Classes>(Console.ReadLine().ToUpper());
                lstCodTurmas.Add(C);

                Console.Clear();
             
            }
            
            return p;
            #endregion
        }

    }
}
