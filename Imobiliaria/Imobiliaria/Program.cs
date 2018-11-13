using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Imobiliaria
{
    class Program
    {

        static void Main(string[] args)
        {

            // TO DO (a fazer)
            // Melhorar a implementação de datas, no momentos quando solicitadas e escritas elas ficam na forma ddmmyyyy
            // Comentar o código do programa
            // Escrever o cabeçalho das funções
            // Passar para Windows Forms

            menu();

        }

        public static void menu()
        {

            /* 
             * menu
             * Abre o menu
             * Entrada:
             * Saída:
             */

            char opc;

            do
            {

                Console.Clear();

                Console.WriteLine("Menu\n\n" +
                    "\nA. cadastro" +
                    "\nB. pesquisa" +
                    "\nC. relatório" +
                    "\nD. encerrar");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {

                    case 'a':

                        cadastro();
                        break;

                    case 'b':

                        pesquisa();
                        break;

                    case 'c':

                        relatorio();
                        break;

                    case 'd':

                        Console.WriteLine("\nAperte uma tecla para sair");
                        break;

                    default:

                        Console.WriteLine("\nOpção inválida, digite H para ver as opções");
                        opc = char.Parse(Console.ReadLine().ToLower());
                        if (opc == 'h')
                        {
                            Console.WriteLine("Opções:" +
                                           "\nA. cadastro" +
                                           "\nB. pesquisa" +
                                           "\nC. relatório" +
                                           "\nD. encerrar");
                        }
                        break;
                }
            } while (opc != 'd');

            Console.ReadKey();

        }


        // Funções de Cadastro

        public static void cadastro()
        {
            /* 
             * cadastro
             * Abre o menu de cadastros
             * Entrada:
             * Saída:
             */

            int codProp = 0, codCliente = 0, codCorretor = 0, codImovel = 0, codLoc = 0, codVenda = 0;
            char opc;

            do
            {

                Console.Clear();
                Console.WriteLine("Cadastro\n\n");
                Console.WriteLine("Digite uma opção para cadastrar:" +
                                "\n\nA. proprietário" +
                                "\nB. cliente" +
                                "\nC. corretor" +
                                "\nD. imóvel" +
                                "\nE. locação" +
                                "\nF. venda" +
                                "\nG. sair");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {
                    case 'a':

                        cadProp(ref codProp);
                        break;

                    case 'b':

                        cadCliente(ref codCliente);
                        break;

                    case 'c':

                        cadCorretor(ref codCorretor);
                        break;

                    case 'd':

                        cadImovel(ref codImovel);
                        break;

                    case 'e':

                        cadLoc(ref codLoc);
                        break;

                    case 'f':

                        cadVenda(ref codVenda);
                        break;

                    case 'g':

                        Console.WriteLine("\nAperte uma tecla para sair");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite H para ver as opções");
                        opc = char.Parse(Console.ReadLine().ToLower());
                        if (opc == 'h')
                        {
                            Console.WriteLine("Opções para cadastro:" +
                                            "\n\nA. proprietário" +
                                            "\nB. cliente" +
                                            "\nC. corretor" +
                                            "\nD. imóvel" +
                                            "\nE. locação" +
                                            "\nF. venda" +
                                            "\nG. sair");
                        }
                        break;

                }

            } while (opc != 'g');

            Console.ReadKey();

        }


        public static void cadProp(ref int codProp)
        {

            /* 
             * cadProp
             * Cadastra um novo propietário 
             * Entrada:
             * Saída:
             * Código+Nome+Endereço+Telefone
             */

            FileStream arqProp = new FileStream("informacoes/proprietario.txt", FileMode.Open);
            StreamReader leProp = new StreamReader(arqProp);
            StreamWriter escProp = new StreamWriter(arqProp);
            string nome, end, leLinha;
            string[] codPropAux;
            int tel;

            Console.Clear();

            Console.WriteLine("Cadastrar proprietário\n\n");

            do
            {

                leLinha = leProp.ReadLine();

                if (leLinha != null)
                {

                    codPropAux = leLinha.Split('+');
                    codProp = int.Parse(codPropAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escProp.WriteLine(leLinha);
            }

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Telefone:");
            tel = int.Parse(Console.ReadLine());
            codProp++;
            escProp.WriteLine($"{codProp}+{nome}+{end}+{tel}");

            escProp.Close();
            leProp.Close();

        }

        public static void cadCliente(ref int codCliente)
        {

            /* cadCliente
             * Cadastra um novo cliente 
             * Entrada:
             * Saída:
             * Código+Nome+Endereço+Telefone+Data de nascimento
             */

            FileStream arqCliente = new FileStream("informacoes/cliente.txt", FileMode.Open);
            StreamReader leCliente = new StreamReader(arqCliente);
            StreamWriter escCliente = new StreamWriter(arqCliente);
            string nome, end, leLinha;
            string[] codClienteAux;
            int tel, data;

            Console.Clear();

            Console.WriteLine("Cadastrar cliente\n\n");

            do
            {

                leLinha = leCliente.ReadLine();

                if (leLinha != null)
                {

                    codClienteAux = leLinha.Split('+');
                    codCliente = int.Parse(codClienteAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escCliente.WriteLine(leLinha);
            }

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Telefone:");
            tel = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de nascimento:");
            data = int.Parse(Console.ReadLine());
            codCliente++;
            escCliente.WriteLine($"{codCliente}+{nome}+{end}+{tel}+{data}");

            escCliente.Close();
            leCliente.Close();

        }

        public static void cadCorretor(ref int codCorretor)
        {

            /* cadCorretor
             * Cadastra um novo propietário 
             * Entrada:
             * Saída:
             * Código+Nome+Endereço+Telefone+Salário
             */

            FileStream arqCorretor = new FileStream("informacoes/corretor.txt", FileMode.Open);
            StreamReader leCorretor = new StreamReader(arqCorretor);
            StreamWriter escCorretor = new StreamWriter(arqCorretor);
            string nome, end, leLinha;
            string[] codCorretorAux;
            int tel;
            double salario;

            Console.Clear();

            Console.WriteLine("Cadastrar corretor\n\n");

            do
            {

                leLinha = leCorretor.ReadLine();

                if (leLinha != null)
                {

                    codCorretorAux = leLinha.Split('+');
                    codCorretor = int.Parse(codCorretorAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escCorretor.WriteLine(leLinha);
            }

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Telefone:");
            tel = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário:");
            salario = double.Parse(Console.ReadLine());
            codCorretor++;
            escCorretor.WriteLine($"{codCorretor}+{nome}+{end}+{tel}+{salario}");

            escCorretor.Close();
            leCorretor.Close();

        }

        public static void cadImovel(ref int codImovel)
        {

            /* cadImovel
             * Cadastra um novo imóvel 
             * Entrada:
             * Saída:
             * Código+Código proprietário+Endereço+Categoria+Tipo+Quantidade de quartos+Quantidade de vagas+Valor+Condomínio+Status+Observações
             */

            FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Open);
            StreamReader leImovel = new StreamReader(arqImovel);
            StreamWriter escImovel = new StreamWriter(arqImovel);
            string end, leLinha, cat, status = "", obs, tipo2 = "";
            string[] codImovelAux;
            int codProp, quartos, vagas, tipo1 = 1;
            double valor, cond;

            Console.Clear();

            Console.WriteLine("Cadastrar imóvel\n\n");

            do
            {

                leLinha = leImovel.ReadLine();

                if (leLinha != null)
                {

                    codImovelAux = leLinha.Split('+');
                    codImovel = int.Parse(codImovelAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escImovel.WriteLine(leLinha);
            }

            do
            {
                Console.WriteLine("Tipo de imóvel:" +
                    "\n[1] VENDA" +
                    "\n[2] ALUGUEL");
                tipo1 = int.Parse(Console.ReadLine());
                if (tipo1 == 1)
                {
                    status = "a vender";
                    tipo2 = "venda";
                    tipo1 = 1;
                }
                else if (tipo1 == 2)
                {
                    status = "a alugar";
                    tipo2 = "locação";
                    tipo1 = 1;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                    tipo1 = 0;
                }
            } while (tipo1 != 1 && tipo1 != 0);

            Console.WriteLine("Código do proprietário:");
            codProp = int.Parse(Console.ReadLine());
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Categoria:");
            cat = Console.ReadLine();
            Console.WriteLine("Quantidade de quartos:");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de vagas:");
            vagas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Condomínio:");
            cond = double.Parse(Console.ReadLine());
            Console.WriteLine("Observações:");
            obs = Console.ReadLine();
            codImovel++;
            escImovel.WriteLine($"{codImovel}+{codProp}+{end}+{cat}+{tipo2}+{quartos}+{vagas}+{valor}+{cond}+{status}+{obs}");

            escImovel.Close();
            leImovel.Close();

        }

        public static void cadLoc(ref int codLoc)
        {

            /* cadLoc
             * Cadastra uma nova locação
             * Entrada:
             * Saída:
             * Código locação+Código imóvel+Código cliente+Aluguel+Taxa administrativa+Valor do proprietário+Data de início da locação+Duração da locação
             */

            FileStream arqLoc = new FileStream("informacoes/corretor.txt", FileMode.Open);
            StreamReader leLoc = new StreamReader(arqLoc);
            StreamWriter escLoc = new StreamWriter(arqLoc);
            FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Open);
            StreamReader leImovel = new StreamReader(arqImovel);
            StreamWriter escImovel = new StreamWriter(arqImovel);
            string leLinha;
            string[] codLocAux, linhaImovel;
            int codImovel, codImovelAux = 0, codCliente, inicio, duracao;
            double aluguel = 0, taxa, valorProp;

            Console.Clear();

            // TO DO (a fazer)
            // Um imóvel só pode ser alugado, caso o status dele seja “a alugar” e o seu tipo deve ser “aluguel”
            // Para cadastrar uma locação ou venda, primeiro é necessário que o cliente, proprietário e imóvel estejam cadastrados
            // Fazer modificar a linha do imóvel e não criar outra

            Console.WriteLine("Cadastrar locação\n\n");

            do
            {

                leLinha = leLoc.ReadLine();

                if (leLinha != null)
                {

                    codLocAux = leLinha.Split('+');
                    codLoc = int.Parse(codLocAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escLoc.WriteLine(leLinha);
            }

            Console.WriteLine("Código do imóvel:");
            codImovel = int.Parse(Console.ReadLine());
            Console.WriteLine("Código do cliente:");
            codCliente = int.Parse(Console.ReadLine());
            // Alterar pra pegar o nome do cliente e transformar pro código dele

            do
            {

                leLinha = leImovel.ReadLine();

                if (leLinha != null)
                {
                    linhaImovel = leLinha.Split('+');
                    codImovelAux = int.Parse(linhaImovel[0]);
                    aluguel = double.Parse(linhaImovel[7]);

                    if (codImovelAux == codImovel)
                    {

                        escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+alugado+{linhaImovel[10]}");

                    }
                }

            } while (leLinha != null);

            Console.WriteLine("Data de ínicio da locação:");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Duração da locação, em meses:");
            duracao = int.Parse(Console.ReadLine());

            if (duracao <= 6)
            {
                taxa = 0.15 * aluguel;
            }
            else if (duracao <= 12)
            {
                taxa = 0.10 * aluguel;
            }
            else
            {
                taxa = 0.05 * aluguel;
            }
            valorProp = aluguel - taxa;

            codLoc++;
            escLoc.WriteLine($"{codLoc}+{codImovelAux}+{codCliente}+{aluguel}+{taxa}+{valorProp}+{inicio}+{duracao}");

            escImovel.Close();
            leImovel.Close();
            escLoc.Close();
            leLoc.Close();

        }

        public static void cadVenda(ref int codVenda)
        {

            /* cadVenda
             * Cadastra uma nova venda
             * Entrada:
             * Saída:
             */

            FileStream arqVenda = new FileStream("informacoes/vendas.txt", FileMode.Open);
            StreamReader leVenda = new StreamReader(arqVenda);
            StreamWriter escVenda = new StreamWriter(arqVenda);
            FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Open);
            StreamReader leImovel = new StreamReader(arqImovel);
            StreamWriter escImovel = new StreamWriter(arqImovel);
            string leLinha;
            string[] codVendaAux, linhaImovel;
            int codImovel, codImovel2, codImovelAux = 0, codCliente, codCorretor, dataVenda;
            double venda = 0, taxa, valorProp;

            // TO DO (a fazer)
            // Um imóvel só pode ser vendido, caso o status dele seja “a vender” e o seu tipo deve ser “venda”
            // Fazer um menu para cadastrar propostas e outro de vendas efetivadas
            // Para cadastrar uma locação ou venda, primeiro é necessário que o cliente, proprietário e imóvel estejam cadastrados
            // Fazer modificar a linha do imóvel e não criar outra
            // Não está escrevendo a linha com vendido, depois do com proposta

            Console.Clear();

            Console.WriteLine("Cadastrar venda\n\n");

            do
            {
                // Conta os códigos das vendas até o último, para incrementar o código depois
                leLinha = leVenda.ReadLine();

                if (leLinha != null)
                {

                    codVendaAux = leLinha.Split('+');
                    codVenda = int.Parse(codVendaAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                // Quando chegar na última linha escreve a última linha lida
                escVenda.WriteLine(leLinha);
            }

            Console.WriteLine("Código do imóvel:");
            codImovel = int.Parse(Console.ReadLine());
            codImovel2 = codImovel - 1;
            Console.WriteLine("Código do cliente:");
            codCliente = int.Parse(Console.ReadLine());
            // Alterar pra pegar o nome do cliente e transformar pro código dele
            Console.WriteLine("Código do corretor:");
            codCorretor = int.Parse(Console.ReadLine());

            do
            {

                leLinha = leImovel.ReadLine();

                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    codImovelAux = int.Parse(linhaImovel[0]);
                    venda = double.Parse(linhaImovel[7]);

                    if (codImovelAux == codImovel)
                    {

                        escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+com proposta+{linhaImovel[10]}");

                    }

                }

            } while (leLinha != null);

            taxa = 0.15 * venda;
            valorProp = venda - taxa;

            Console.WriteLine("Data da venda:");
            dataVenda = int.Parse(Console.ReadLine());

            codVenda++;
            escVenda.WriteLine($"{codVenda}+{codImovelAux}+{codCliente}+{codCorretor}+{venda}+{taxa}+{valorProp}+{dataVenda}");

            do
            {

                leLinha = leImovel.ReadLine();

                if (leLinha != null)
                {
                    linhaImovel = leLinha.Split('+');
                    codImovelAux = int.Parse(linhaImovel[0]);
                    venda = double.Parse(linhaImovel[7]);

                    if (codImovelAux == codImovel)
                    {

                        escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+vendido+{linhaImovel[10]}");

                    }
                }

            } while (leLinha != null);

            escImovel.Close();
            leImovel.Close();
            escVenda.Close();
            leVenda.Close();

        }

        // Funções de Pesquisa

        public static void pesquisa()
        {

            /* 
             * pesquisa
             * Abre o menu de pesquisas
             * Entrada:
             * Saída:
             */

            char opc;
            string nome;

            do
            {

                Console.Clear();
                Console.WriteLine("Pesquisa\n\n");
                Console.WriteLine("Digite uma opção para pesquisa:" +
                                "\n\nA. informações de clientes" +
                                "\nB. informações de proprietários" +
                                "\nC. informações de corretores" +
                                "\nD. sair");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {
                    case 'a':

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine().ToUpper();
                        pesCliente(nome);
                        break;

                    case 'b':

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine().ToUpper();
                        pesProp(nome);
                        break;

                    case 'c':

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine().ToUpper();
                        pesCorretor(nome);
                        break;

                    case 'd':

                        Console.WriteLine("\nAperte uma tecla para sair");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite H para ver as opções");
                        opc = char.Parse(Console.ReadLine().ToLower());
                        if (opc == 'h')
                        {
                            Console.WriteLine("Opções para pesquisa:" +
                                            "\n\nA. informações de clientes" +
                                            "\nB. informações de proprietários" +
                                            "\nC. informações de corretores" +
                                            "\nD. sair");
                        }
                        break;

                }

            } while (opc != 'd');

            Console.ReadKey();

        }

        public static void pesProp(string nome)
        {

            /* 
             * pesProp
             * Pesquisa propietário 
             * Entrada:
             * Saída:
             */

            FileStream arqProp = new FileStream("informacoes/proprietario.txt", FileMode.Open);
            StreamReader leProp = new StreamReader(arqProp);
            string linha;
            string[] inf;
            int quant = 0;

            Console.Clear();

            Console.WriteLine("Pesquisa proprietário\n\n");

            do
            {

                linha = leProp.ReadLine();
                if (linha != null)
                {
                    inf = linha.Split('+');

                    if (inf[1].ToUpper() == nome)
                    {
                        Console.WriteLine($"Código: {inf[0]}" +
                            $"\nNome: {inf[1]}" +
                            $"\nEndereço: {inf[2]}" +
                            $"\nTelefone: {inf[3]}");
                        quant++;
                    }
                }

            } while (linha != null);

            if (quant == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado");
            }

            leProp.Close();

            Console.ReadKey();

        }

        public static void pesCliente(string nome)
        {

            /* 
             * pesCliente
             * Pesquisa cliente 
             * Entrada:
             * Saída:
             */

            FileStream arqCliente = new FileStream("informacoes/cliente.txt", FileMode.Open);
            StreamReader leCliente = new StreamReader(arqCliente);
            string linha;
            string[] inf;
            int quant = 0;

            Console.Clear();

            Console.WriteLine("Pesquisa cliente\n\n");

            do
            {

                linha = leCliente.ReadLine();

                if (linha != null)
                {
                    inf = linha.Split('+');

                    if (inf[1].ToUpper() == nome)
                    {
                        Console.WriteLine($"Código: {inf[0]}" +
                            $"\nNome: {inf[1]}" +
                            $"\nEndereço: {inf[2]}" +
                            $"\nTelefone: {inf[3]}" +
                            $"\nData de nascimento: {inf[4]}");
                        quant++;
                    }

                }

            } while (linha != null);

            if (quant == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado");
            }

            leCliente.Close();

            Console.ReadKey();

        }

        public static void pesCorretor(string nome)
        {

            /* 
             * pesCorretor
             * Pesquisa corretor 
             * Entrada:
             * Saída:
             */

            FileStream arqCorretor = new FileStream("informacoes/corretor.txt", FileMode.Open);
            StreamReader leCorretor = new StreamReader(arqCorretor);

            string linha;
            string[] inf;
            int quant = 0;

            Console.Clear();

            Console.WriteLine("Pesquisa corretor\n\n");

            do
            {

                linha = leCorretor.ReadLine();
                if (linha != null)
                {
                    inf = linha.Split('+');

                    if (inf[1].ToUpper() == nome)
                    {
                        Console.WriteLine($"Código: {inf[0]}" +
                            $"\nNome: {inf[1]}" +
                            $"\nEndereço: {inf[2]}" +
                            $"\nTelefone: {inf[3]}" +
                            $"\nSalário: {inf[4]}");
                        quant++;
                    }
                }

            } while (linha != null);

            if (quant == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado");
            }

            leCorretor.Close();

            Console.ReadKey();

        }

        // Relatório

        public static void relatorio()
        {
            /* 
             * relatorio
             * Abre o menu de relatórios
             * Entrada:
             * Saída:
             */

            char opc;
            int data, codCorretor;

            do
            {

                Console.Clear();
                Console.WriteLine("Relatório\n\n");
                Console.WriteLine("Digite uma opção de relatório:" +
                                "\n\nA. vendas de um corretor" +
                                "\nB. vendas em uma data" +
                                "\nC. locações em um data" +
                                "\nD. sair\n");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {
                    case 'a':

                        Console.WriteLine("Código do corretor:");
                        codCorretor = int.Parse(Console.ReadLine());
                        relCorretor(codCorretor);
                        break;

                    case 'b':

                        Console.WriteLine("Data:");
                        data = int.Parse(Console.ReadLine());
                        relVenda(data);
                        break;

                    case 'c':

                        Console.WriteLine("Data:");
                        data = int.Parse(Console.ReadLine());
                        relLoc(data);
                        break;

                    case 'd':

                        Console.WriteLine("\nAperte uma tecla para sair");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite H para ver as opções");
                        opc = char.Parse(Console.ReadLine().ToLower());
                        if (opc == 'h')
                        {
                            Console.WriteLine("Opções de relatórios:" +
                                            "\n\nA. informações de clientes" +
                                            "\nB. informações de proprietários" +
                                            "\nC. informações de corretores" +
                                            "\nD. sair\n");
                        }
                        break;

                }

            } while (opc != 'd');

            Console.ReadKey();

        }

        public static void relCorretor(int codCorretor)
        {

            /* relCorretor
             * Mostra todas as vendas de imóveis de um corretor
             * Entrada:
             * Saída:
             */

            FileStream arqVenda = new FileStream("informacoes/vendas.txt", FileMode.Open);
            StreamReader leVenda = new StreamReader(arqVenda);
            string leLinha;
            string[] linhaImovel;
            int codCorretorAux, quant = 0;

            Console.Clear();

            Console.WriteLine("Relatório das vendas\n\n");

            do
            {

                leLinha = leVenda.ReadLine();

                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    codCorretorAux = int.Parse(linhaImovel[3]);

                    if (codCorretorAux == codCorretor)
                    {

                        Console.WriteLine($"Número da venda:{linhaImovel[0]}\nCódigo do Imóvel: {linhaImovel[1]}\nCódigo do cliente: {linhaImovel[2]}\nCódigo do corretor: {linhaImovel[3]}" +
                            $"\nValor da venda: R${linhaImovel[4]}\nTaxa administrativa: R${linhaImovel[5]}\nValor do proprietário: R${linhaImovel[6]}\nData da venda: {linhaImovel[7]}");
                        quant++;
                    }
                }

            } while (leLinha != null);
            
            if (quant == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado");
            }


            leVenda.Close();

            Console.ReadKey();

        }

        public static void relVenda(int data)
        {

            /* relVenda
             * Mostra todas as vendas de imóveis de uma determinada data
             * Entrada:
             * Saída:
             */

            FileStream arqVenda = new FileStream("informacoes/vendas.txt", FileMode.Open);
            StreamReader leVenda = new StreamReader(arqVenda);
            string leLinha;
            string[] linhaImovel;
            int dataAux, quant = 0;

            Console.Clear();

            Console.WriteLine("Relatório das vendas\n\n");

            do
            {

                leLinha = leVenda.ReadLine();

                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    dataAux = int.Parse(linhaImovel[7]);

                    if (dataAux == data)
                    {

                        Console.WriteLine($"Número da venda:{linhaImovel[0]}\nCódigo do Imóvel: {linhaImovel[1]}\nCódigo do cliente: {linhaImovel[2]}\nCódigo do corretor: {linhaImovel[3]}" +
                            $"\nValor da venda: R${linhaImovel[4]}\nTaxa administrativa: R${linhaImovel[5]}\nValor do proprietário: R${linhaImovel[6]}\nData da venda: {linhaImovel[7]}");
                        quant++;
                    }
                }

            } while (leLinha != null);

            if (quant == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado");
            }

            leVenda.Close();

            Console.ReadKey();

        }

        public static void relLoc(int data)
        {

            /* cadVenda
             * Mostra todas as locações de imóveis de uma determinada data
             * Entrada:
             * Saída:
             */

            FileStream arqLoc = new FileStream("informacoes/locacoes.txt", FileMode.Open);
            StreamReader leLoc = new StreamReader(arqLoc);
            string leLinha;
            string[] linhaImovel;
            int dataAux, quant = 0;

            Console.Clear();

            Console.WriteLine("Relatório das locações\n\n");

            do
            {

                leLinha = leLoc.ReadLine();
                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    dataAux = int.Parse(linhaImovel[6]);

                    if (dataAux == data)
                    {

                        Console.WriteLine($"Número da locação:{linhaImovel[0]}\nCódigo do imóvel: {linhaImovel[1]}\nCódigo do inquilino: {linhaImovel[2]}\nValor do aluguel: R${linhaImovel[3]}" +
                            $"\nTaxa administrativa: R${linhaImovel[4]}\nValor do prietário: R${linhaImovel[5]}\nData de início da locação: {linhaImovel[6]}\nDuração da locação: {linhaImovel[7]} meses");
                        quant++;
                    }
                }

            } while (leLinha != null);

            if (quant == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado");
            }

            leLoc.Close();

            Console.ReadKey();

        }

    }
}
