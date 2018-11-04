﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Imobiliaria
{
    class Program
    {

        // Funções de Cadastro

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
            string end, leLinha, cat, tipo, status, obs;
            string[] codImovelAux;
            int codProp, quartos, vagas;
            double valor, cond;

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

            Console.WriteLine("Código do proprietário:");
            codProp = int.Parse(Console.ReadLine());
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Categoria:");
            cat = Console.ReadLine();
            Console.WriteLine("Tipo:");
            tipo = Console.ReadLine();
            Console.WriteLine("Quantidade de quartos:");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de vagas:");
            vagas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Condomínio:");
            cond = double.Parse(Console.ReadLine());
            Console.WriteLine("Status:");
            status = Console.ReadLine();
            Console.WriteLine("Observações:");
            obs = Console.ReadLine();
            codImovel++;
            escImovel.WriteLine($"{codImovel}+{codProp}+{end}+{cat}+{tipo}+{quartos}+{vagas}+{valor}+{cond}+{status}+{obs}");

            escImovel.Close();
            leImovel.Close();

        }

        public static void cadLoc()
        {

            /* cadLoc
             * Cadastra uma nova locação
             * Entrada:
             * Saída:
             */



        }

        public static void cadVenda()
        {

            /* cadVenda
             * Cadastra uma nova venda
             * Entrada:
             * Saída:
             */



        }

        // Funções de Pesquisa

        public static void pesquisa()
        {

            /* 
             * pesquisa
             * Pesquisa 
             * Entrada:
             * Saída:
             */

            char opc;
            string nome;

            do
            {
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
                        nome = Console.ReadLine();
                        pesCliente(nome);
                        break;

                    case 'b':

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine();
                        pesProp(nome);
                        break;

                    case 'c':

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine();
                        pesCorretor(nome);
                        break;

                    case 'd':

                        Console.WriteLine("Saindo");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite H para ver as opções");
                        opc = char.Parse(Console.ReadLine().ToLower());
                        if(opc == 'h')
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


        }

        // Relatório

        public static void relCorretor()
        {

            /* relCorretor
             * Mostra todas as vendas de imóveis de um corretor
             * Entrada:
             * Saída:
             */



        }

        public static void relVenda()
        {

            /* relVenda
             * Mostra todas as vendas de imóveis de uma determinada data
             * Entrada:
             * Saída:
             */



        }

        public static void relLoc()
        {

            /* cadVenda
             * Mostra todas as locações de imóveis de uma determinada data
             * Entrada:
             * Saída:
             */



        }

        static void Main(string[] args)
        {

            int codProp = 0, codCliente = 0, codCorretor = 0, codImovelAux = 0;

            cadCorretor(ref codCorretor);

            Console.ReadKey();

        }
    }
}
