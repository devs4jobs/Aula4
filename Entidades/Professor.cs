using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CadastroEscolar.Entidades.Design;
using System.Linq;
namespace CadastroEscolar.Entidades
{
    class Professor : Pessoa
    {
        public int Identificacao { get; set; }
        //  public int Salario { get; set; }
        public List<Materias> lstMaterias { get; set; } = new List<Materias>();
        public List<Turma> TurmasDoProfesor { get; set; } = new List<Turma>();


        int i = 0;
        public Professor()
        {

        }

        //public Professor(int identificacao, int salario)
        //{
        //    Identificacao = identificacao;
        //    Salario = salario;
        //}
        #region "CADASTRO INFORMAÇÔES PROFESSORES"
        override public void Cadastrar()
        {
            Random rnd = new Random();
            Designs d = new Designs();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE O NOME DO PROFESSOR");
            Console.WriteLine("");
            d.MudarCores1();
            Nome = Console.ReadLine();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE A IDADE DO PROFESSOR:");
            Console.WriteLine("");
            d.MudarCores1();
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("QUAL O SEXO DO PROFESSOR?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
            Console.WriteLine("");
            d.MudarCores1();
            Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE O CPF DO PROFESSOR:");
            Console.WriteLine("");
            d.MudarCores1();
            Cpf = Console.ReadLine().ToUpper();
           
            Console.WriteLine("");
            d.MudarCores();
            // Console.WriteLine("O NUMERO DE IDENTIFICAÇÂO PARA ESTE PROFESSOR É:" );
            Console.WriteLine("");
            d.MudarCores1();
            int codidentificado = (rnd.Next(10000, 90000));
            Identificacao = codidentificado;

            Console.WriteLine("O NUMERO DE IDENTIFICAÇÂO PARA ESTE PROFESSOR É:" + codidentificado);

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("CADASTRE AS MATERIAS QUE O PROFESSOR DA AULA");
            Console.WriteLine("QUANTAS MATERIAS DESEJA CADASTRAR PARA ESTE PROFESSOR?");
            Console.WriteLine("");
            d.MudarCores1();
            int num = int.Parse(Console.ReadLine());

            for (i = 0; i < num; i++)
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
            Console.Clear();
            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("ESSE PROFESSOR DA AULA PARA QUANTAS TURMAS?");
            Console.WriteLine("");
            d.MudarCores1();
            num = int.Parse(Console.ReadLine());


            for (i = 0; i < num; i++)
            {
                Turma turma = new Turma();

                Console.WriteLine("QUAL É A TURMA DO PROFESSOR? A,B,C,D ou E");
                Console.WriteLine("");
                int decisao = int.Parse(Console.ReadLine());
               


                switch (decisao)
                {
                    case 1:

                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("Turma A CADASTRADA");


                        turma.DefinirTurma(decisao);

                        TurmasDoProfesor.Add(turma);
                        Console.WriteLine("");

                        break;


                    case 2:

                        Console.WriteLine("");
                        d.MudarCores();
                        if (TurmasDoProfesor.Contains(turma))
                        {
                            Console.WriteLine("TURMA JA CADASTRADA PARA ESTE PROFESSOR, FAVOR CADASTRAR OUTRA TURMA ");
                            TurmasDoProfesor.Remove(turma);
                        }

                        Console.WriteLine("TURMA B CADASTRADA");
                        turma.DefinirTurma(decisao);
                        TurmasDoProfesor.Add(turma);
                        Console.WriteLine("");

                        break;

                    case 3:

                        if (TurmasDoProfesor.Contains(turma))
                        {
                            Console.WriteLine("TURMA JA CADASTRADA PARA ESTE PROFESSOR");
                        }
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("TURMA C CADASTRADA");
                        turma.DefinirTurma(decisao);
                        TurmasDoProfesor.Add(turma);
                        Console.WriteLine("");
                        break;

                    case 4:

                        if (TurmasDoProfesor.Contains(turma))
                        {
                            Console.WriteLine("TURMA JA CADASTRADA PARA ESTE PROFESSOR");
                        }
                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("TURMA D CADASTRADA");
                        turma.DefinirTurma(decisao);
                        TurmasDoProfesor.Add(turma);
                        Console.WriteLine("");
                        break;

                    case 5:

                        Console.WriteLine("");
                        d.MudarCores();
                        Console.WriteLine("TURMA E CADASTRADA");
                        turma.DefinirTurma(decisao);
                        if (turma.lstProfessors.Where(p => p.Cpf == Cpf).ToList().Count > 0) 
                        {
                            Console.WriteLine("PROFESSOR JÀ CADASTRADO PARA ESTA TURMA");
                            break;
                        }
                        turma.lstProfessors.Add(this);
                        TurmasDoProfesor.Add(turma);
                        Console.WriteLine("");
                        break;

                    default:
                        break;


                }

                #endregion

            }
            Console.WriteLine("TODAS AS TURMAS FORAM CADASTRADAS!");
        }
    }
}
