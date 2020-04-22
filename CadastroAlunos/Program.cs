using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Nota> listaNotas = new List<Nota>();

            int opcaoMenu = montaMenu();
            while (opcaoMenu != 0) 
            {
                switch (opcaoMenu)
                {
                    case 1:
                        cadastrarAluno();
                        break;
                    case 2:
                        alerarAluno();
                        break;
                    case 3:
                        excluirAluno();
                        break;
                    case 4:
                        mostrarDadosAluno();
                        break;
                    case 5:
                        mostrarAlunos();
                        break;
                    case 6:
                        cadastrarNota();
                        break;
                    default:
                        montaMenu();
                        break;

                }
                opcaoMenu = montaMenu();
            }


            void cadastrarAluno()
            {
                Aluno aluno = new Aluno();

                Console.Clear();
                Console.WriteLine("Nome do Aluno:");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Data Nascimento:");
                aluno.DataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                aluno.Id = aluno.geraID(listaAlunos);
                listaAlunos.Add(aluno);
            }


            void alerarAluno()
            {
                Console.Clear();
                mostrarListaAlunosID();
                Console.WriteLine("Informe o Id do Aluno para Alterar (0 para abortar): ");
                int idAluno = Convert.ToInt32(Console.ReadLine());

                if (idAluno != 0)
                {
                    if (listaAlunos.Count() > 0)
                    {
                        bool alterouRegistro = false;
                        for (int i = 0; i <= listaAlunos.Count() - 1; i++)
                        {
                            if (idAluno == listaAlunos[i].Id)
                            {
                                Console.WriteLine("Nome do Aluno: ");
                                listaAlunos[i].Nome = Console.ReadLine();

                                Console.WriteLine("Data Nascimento: ");
                                listaAlunos[i].DataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                                Console.WriteLine("");
                                Console.WriteLine("Registro alterado com sucesso!");
                                alterouRegistro = true;
                            }
                        }

                        if (!alterouRegistro)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Alunos não econtrado para alteração!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Não há registros a alterar!");
                    }

                    voltarMenu();
                }
            }


            void excluirAluno()
            {
                Console.Clear();
                mostrarListaAlunosID();
                Console.WriteLine("Informe o Id do Aluno para Excluir (0 para abortar): ");
                int idAluno = Convert.ToInt32(Console.ReadLine());

                if (idAluno != 0)
                {
                    if (listaAlunos.Count() > 0)
                    {
                        bool excluiuRegistro = false;
                        for (int i  = 0; i <= listaAlunos.Count() - 1; i++)
                        {
                            if (idAluno == listaAlunos[i].Id)
                            {
                                listaAlunos.RemoveAt(i);
                                Console.WriteLine("");
                                excluiuRegistro = true;
                            }
                        }

                        for (int i = 0; i < listaNotas.Count(); i++)
                        {
                            if (idAluno == listaNotas[i].IdAluno)
                            {
                                listaNotas.RemoveAt(i);
                                excluiuRegistro = true;
                            }
                        }


                        if (!excluiuRegistro)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Aluno não econtrado para exclusão!");
                        }
                        else
                        {
                            Console.WriteLine("Registro excluido com sucesso!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Não há registros a excluir!");
                    }

                    voltarMenu();
                }
            }


            void mostrarAlunos()
            {
                Console.Clear();

                if (listaAlunos.Count() != 0)
                {
                    foreach (var item in listaAlunos)
                    {
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Id do Aluno: " + item.Id);
                        Console.WriteLine("Nome do Aluno: " + item.Nome);
                        Console.WriteLine("Idade do Aluno: " + aluno.calculaIdade(item.DataNascimento));
                        calculaMediaAluno(item.Id);
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Não possui alunos cadastrados!");
                }

                voltarMenu();
            }


            void mostrarDadosAluno()
            {
                Console.Clear();
                mostrarListaAlunosID();
                Console.WriteLine("Informe o Id do Aluno para Mostar (0 para abortar): ");
                int idAluno = Convert.ToInt32(Console.ReadLine());

                if (idAluno != 0)
                {
                    if (listaAlunos.Count() != 0)
                    {
                        bool encontrou = false;
                        foreach (var item in listaAlunos)
                        {
                            if (item.Id == idAluno)
                            {
                                encontrou = true;
                                Aluno aluno = new Aluno();
                                Console.WriteLine("");
                                Console.WriteLine("Id do Aluno: " + item.Id);
                                Console.WriteLine("Nome do Aluno: " + item.Nome);
                                Console.WriteLine("Idade do Aluno: " + aluno.calculaIdade(item.DataNascimento));
                                calculaMediaAluno(item.Id);
                                Console.WriteLine("");
                            }
                        }

                        if (!encontrou)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Não foi encontrado o aluno informado!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Não possui alunos cadastrados!");
                    }
                }
                voltarMenu();
            }



            void mostrarListaAlunosID()
            {
                if (listaAlunos.Count() != 0)
                {
                    Console.WriteLine("* LISTA DE ALUNOS");
                    foreach (var item in listaAlunos)
                    {
                        Aluno aluno = new Aluno();
                        Console.WriteLine("* Id: {0}    Aluno: {1}", item.Id, item.Nome);              
                    }
                    Console.WriteLine("");
                }

            }

            void cadastrarNota()
            {
                Console.Clear();
                mostrarListaAlunosID();
                Console.WriteLine("Informe o Id do Aluno para informar as notas (0 para abortar): ");
                int idAluno = Convert.ToInt32(Console.ReadLine());

                if (idAluno != 0)
                {
                    if (listaAlunos.Count() > 0)
                    {
                        bool alterouRegistro = false;
                        for (int i = 0; i <= listaAlunos.Count() - 1; i++)
                        {
                            if (idAluno == listaAlunos[i].Id)
                            {
                                alterouRegistro = true;
                            }                       
                        }

                        if (!alterouRegistro)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Alunos não econtrado para cadastrar notas!");
                        }
                        else
                        {
                            double nota = 0;
                            while (nota != 99)
                            {

                                Console.WriteLine("Informe nota para o aluno (99 para terminar): ");
                                nota = Convert.ToInt32(Console.ReadLine());

                                if ((nota < 0) | ((nota > 10) & (nota != 99)))
                                {
                                    Console.WriteLine("Nota informada é inválida! Informe nota para o aluno (99 para terminar):");
                                    nota = Convert.ToInt32(Console.ReadLine());
                                }

                                if (nota != 99) 
                                { 
                                    Nota notas = new Nota();
                                    notas.IdAluno = idAluno;
                                    notas.NotaAluno = nota;
                                    listaNotas.Add(notas);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Não há alunos para cadastrar notas!");
                    }

                    voltarMenu();
                }
            }

            void calculaMediaAluno(int idAluno)
            {
                double notas = 0;
                int numeroNotas = 0;

                bool encontrouNota = false;
                foreach (var item2 in listaNotas)
                {
                    if (item2.IdAluno == idAluno)
                    {
                        encontrouNota = true;
                        notas += item2.NotaAluno;
                        numeroNotas++;
                    }
                }

                if (encontrouNota)
                {
                    Nota nota = new Nota();
                    double mediaAluno = (notas / numeroNotas);
                    Console.WriteLine("Média: " + mediaAluno.ToString("####0.00"));
                    Console.WriteLine("Situação: " + nota.situacaoAluno(mediaAluno));
                }
            }
        }


        static int montaMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Editar Aluno (Por ID)");
            Console.WriteLine("3 - Excluir Aluno (Por ID)");
            Console.WriteLine("4 - Buscar Dados do Aluno (Por ID)");
            Console.WriteLine("5 - Listar Todos os Alunos");
            Console.WriteLine("6 - Cadastrar Notas (Por ID)");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Informe a opção para acessar: ");
            return Convert.ToInt32(Console.ReadLine());

        }

        static void voltarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            Console.ReadLine();
        }

    }
}
