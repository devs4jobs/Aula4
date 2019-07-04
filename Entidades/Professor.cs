using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CadastroEscolar.Entidades.Design;

namespace CadastroEscolar.Entidades
{
    public class Professor : Pessoa
    {
        public int Identificacao { get; set; }
        //  public int Salario { get; set; }
        public List<Materias> lstMaterias { get; set; } = new List<Materias>();
  

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
        override public void Cadastrar(List<Turma> lstTurmas)
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
            Sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE O CPF DO PROFESSOR:");
            Console.WriteLine("");
            d.MudarCores1();
            Cpf = Console.ReadLine().ToUpper();
           
            Console.WriteLine("");
            d.MudarCores();
     
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
                     
                        if (lstMaterias.Where(t => t.CodMateria == decisao).ToList().Count > 0)
                        {
                            Console.WriteLine("MATEMATICA");
                        
                            lstMaterias.Where(t => t.CodMateria == decisao).FirstOrDefault().DefinirMateria(decisao);

                            lstMaterias.Add(m);
                        }
                        else
                            Console.WriteLine("MATERIAS REPETIDAS, FAVOR ADICIONAR OUTRA ");
                        Console.Clear();

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
            int turm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            d.MudarCores1();

            for (int i = 0; i < turm; i++)
            {
                Console.WriteLine("PARA QUAL TURMA ESTE PROFESSOR DARÁ AULA ?");

                var codigoTurma = Console.ReadLine().ToUpper();

                if (lstTurmas.Where(t => t.CodTurma == codigoTurma).ToList().Count > 0)
                {
                    lstTurmas.Where(t => t.CodTurma == codigoTurma).FirstOrDefault().AddProfessores(this);
                }
                else
                {
                    Console.WriteLine("ESSA TURMA NAO EXISTE, DESEJA CADASTRAR UMA NOVA TURMA?");
                    string decisaoturma = Console.ReadLine().ToUpper();
                    if (decisaoturma == "SIM")
                        d.MudarCores();
                    Console.WriteLine("QUAL TURMA DESEJA CADASTRAR? A,B,C,D OU E ?");
                    string c = Console.ReadLine().ToUpper();

                    Turma turma1 = new Turma();
                    turma1.CadastrarTurma(c);

                    lstTurmas.Add(turma1);
                    Console.WriteLine("");

                    Console.WriteLine("TURMA CRIADA, POR GENTILEZA EFETUAR O CADASTRO DO PROFESSOR NOVAMENTE !");
                    Console.WriteLine("");
                }
            }


                #endregion

            
       
        }
    }
}
