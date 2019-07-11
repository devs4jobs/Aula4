using System;
using CadastroEscolar.Entidades;
using CadastroEscolar.Entidades.Design;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace CadastroEscolar

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Turma> lstTurmas = new List<Turma>();

            Turma turma = new Turma();
            Designs d = new Designs();

            d.MudarBack();

            #region "HORA"
            DateTime tempo = DateTime.Now;
            tempo.ToString();
            Console.WriteLine("");
            d.MudarCores2();


            if (tempo.Hour >= 6 && tempo.Hour <= 12)
            {
                d.WriteLineCenter($"                               BOM DIA E SEJA BEM VINDO(A) AO SISTEMA, DIA: {DateTime.Now }                         ");

            }
            else if (tempo.Hour > 12 && tempo.Hour < 18)
            {
                d.WriteLineCenter($"                               BOA TARDE E SEJA BEM VINDO(A) AO SISTEMA DIA: {    tempo.ToString()}                         ");
            }

            else
                d.WriteLineCenter($"                               BOA NOITE E SEJA BEM VINDO(A) AO SISTEMA DIA: {DateTime.Now}                         ");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion



            #region "Lógica"
            int decisao = 1, i = 0, N = 0;

            d.MudarCores();
            d.WriteLineCenter("                                           QUANTAS TURMAS DESEJA CADASTRAR?                                             ");
            Console.WriteLine("");
            d.MudarCores1();

            while (N <= 0 || N > 5)
            {
                try
                {
                    Console.WriteLine("DIGITE UM NUMERO INTEIRO ENTRE 1 e 5"); N = int.Parse(Console.ReadLine());
                    Console.WriteLine("");



                }
                catch (Exception)
                {
                    Console.WriteLine("");
                    Console.WriteLine("  XXX    DIGITE APENAS NUMEROS INTEIROS    XXX  ");
                    Console.WriteLine("");

                }

            }

            for (i = 0; i < N; i++)
            {

                d.WriteLineCenter("                                   QUAL TURMA DESEJA CADASTAR ? A,B,C,D OU E ?                                         ");
                string c = Console.ReadLine().ToUpper();
                while (c != "A" && c != "B" && c != "C" && c != "D" && c != "E")
                {
                    Console.WriteLine("OPCAO INVÁLIDA, FAVOR DIGITAR NOVAMENTE!");
                    c = Console.ReadLine().ToUpper();
                }
                Turma turma1 = new Turma();
                if (lstTurmas.Where(t => t.CodTurma == c).ToList().Count == 0)
                {
                    turma1.CadastrarTurma(c);
                    Console.WriteLine($"TURMA {c} CADASTRADA");
                    lstTurmas.Add(turma1);


                }
                else
                {
                    Console.WriteLine("TURMA JA CADASTRADA, FAVOR ADICIONAR OUTRA");
                    i--;

                }
                if (lstTurmas.Count > 5)
                {
                    Console.WriteLine("TURMA JA REGISTADA");
                }

            }

        inicio:
            while (decisao == 2 || decisao == 1 || decisao == 3 || decisao == 4)
            {
                Console.WriteLine("");
                d.MudarCores2();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

                d.WriteLineCenter("                DIGITE 1 PARA ALUNO / DIGITE 2 PARA PROFESSOR  / 3 PARA CADASDASTRAR TURMA / 4 PARA SAIR               \n");

                d.WriteLineCenter("------------------------------------------------------------------------------------------------------------------------");
                d.WriteLineCenter("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");

                {
                    try
                    {
                        decisao = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("OPCAO ERRADA, ABRA O PROGRAMA NOVAMENTE");
                        Console.ReadKey();
                        break;

                    }


                    if (decisao != 1 || decisao != 2 || decisao != 3 || decisao != 4)
                    {


                        Console.WriteLine("OPÇÃO INVALIDA, PRESSIONE ENTER E REINICIE O CONSOLE! ");
                        Console.ReadKey();
                        break;

                         

                    }





                    if (decisao == 1)
                    {
                        d.MudarCores();

                        Console.WriteLine("QUANTOS ALUNOS DESEJA CADASTRAR?");

                        Console.WriteLine("");
                        d.MudarCores1();

                        try
                        {
                            N = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("ERRO, SERÁ FEITO O CADASTRO DE APENAS UM ALUNO");
                        }




                        for (i = 0; i < N; i++)
                        {
                            try
                            {
                                Aluno aluno = new Aluno();
                                aluno.Cadastrar(lstTurmas);
                                turma.AddAlunos(aluno);


                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Erro, insira informações validas!");
                                i--;

                            }

                        }
                    }

                    else if (decisao == 2)
                    {

                        d.MudarCores();
                        Console.WriteLine("QUANTOS PROFESSORES DESEJA CADASTRAR? ");
                        Console.WriteLine("");
                        d.MudarCores1();
                        try
                        {
                            N = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("ERRO, SERÁ FEITO O CADASTRO DE APENAS UM PROFESSOR");
                        }


                        for (i = 0; i < N; i++)
                        {
                            try
                            {
                                Professor professor = new Professor();
                                professor.Cadastrar(lstTurmas);

                                turma.AddProfessores(professor);

                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Erro, insira informações validas!");
                                i--;
                            }

                        }


                    }
                    else if (decisao == 3)
                    {

                        d.MudarCores();
                        Console.WriteLine("QUANTAS TURMAS DESEJA CADASTRAR? ");
                        Console.WriteLine("");
                        d.MudarCores1();
                        try
                        {
                            N = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("ERRO, SERÁ FEITO O CADASTRO DE APENAS UMA TURMA");
                        }

                        while (N != 1 && N != 2 && N != 3 && N != 4 && N != 5)
                        {
                            Console.WriteLine("OPCAO INVÁLIDA, FAVOR DIGITAR NOVAMENTE!");
                            N = int.Parse(Console.ReadLine());

                        }


                        while (N > 5)
                        {
                            Console.WriteLine("QUANTIDADE DE TURMAS INVALIDAS!");
                            N = int.Parse(Console.ReadLine());

                        }


                        for (i = 0; i < N; i++)
                        {
                            Console.WriteLine("QUAL TURMA DESEJA CADASTAR ? A,B,C,D OU E ?");
                            string c = Console.ReadLine().ToUpper();

                            while (c != "A" && c != "B" && c != "C" && c != "D" && c != "E")
                            {
                                Console.WriteLine("OPCAO INVÁLIDA, FAVOR DIGITAR NOVAMENTE!");
                                c = Console.ReadLine().ToUpper();
                            }

                            Turma turma1 = new Turma();
                            if (lstTurmas.Where(t => t.CodTurma == c).ToList().Count == 0)
                            {
                                turma1.CadastrarTurma(c);
                                Console.WriteLine($"TURMA {c} CADASTRADA");
                                lstTurmas.Add(turma1);

                            }

                            else if (lstTurmas.Count >= 5)
                            {
                                Console.WriteLine("TODAS TURMAS JA FORAM REGISTRADAS,CONSULTE A DIRETORIA PARA ABERTURA DE NVOAS TURMAS !");
                                Console.WriteLine("DIGITE ENTER PARA VOLTAR AO INICIO");
                                Console.ReadLine();
                                Console.Clear();
                                goto inicio;

                            }

                            else
                            {
                                Console.WriteLine("TURMA JA CADASTRADA, FAVOR ADICIONAR OUTRA");
                                Console.WriteLine("");
                                i--;

                            }
                        }
                    }

                    else if (decisao == 4)
                    {
                        Console.WriteLine("ATÉ MAIS!");
                        Environment.Exit(0);
                    }

                    StreamWriter sw2 = new StreamWriter(@"C:\Users\Treinamento 5\Desktop\txtarquivo\txt");
                    string g2 = JsonConvert.SerializeObject(lstTurmas);
                    sw2.WriteLine($"LISTA DE TURMAS: { g2}  \n");

                    sw2.Close();

                }



            }
            #endregion
        }



    }
}