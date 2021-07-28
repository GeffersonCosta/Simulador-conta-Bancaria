using System;
using ContaBancaria.Entities;
using System.Collections.Generic;
using System.Globalization;
using ContaBancaria.Entities.Exception;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            ContaCorrente accB = new ContaCorrente("Gefferson", 1001, 0.0, 0.0);
            ContaPoupança accp = new ContaPoupança("Gefferson", 1001, 0.0, 0.0);
            while (n != 9)
            {

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("                        CONTA BANCÁRIA                           ");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("[1]DEPOSITO CONTA CORRENTE       [2] DEPOSITO CONTA POUPANÇA");
                Console.WriteLine("[3]SALDO CONTA CORRENTE          [4] SALDO CONTA POUPANÇA");
                Console.WriteLine("[5]TRANFERÊNCIA DA (CC) P/ (CP)  [6] TRANFERÊNCIA DA (CP) P/ (CC)");
                Console.WriteLine("[9]ENCERRAR OPERAÇÃO");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.Write(":");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (n)
                    {
                        case 1:
                            Console.Write("Entre com o valor a ser depositado na Conta Corrente: ");
                            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            accB.Deposito(valor);
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine(accB);
                            Console.WriteLine("-------------------------------------------------------------------");
                            break;
                        case 2:
                            Console.Write("Entre com o valor a ser depositado na Conta Poupança: ");
                            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            accp.DepositoPoupança(valor);
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine(accp);
                            Console.WriteLine("-------------------------------------------------------------------");
                            break;
                        case 5:
                            Console.Write("Entre com o valor a ser transferido para conta poupança:");
                            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Clear();
                            accB.Transfericia(valor);
                            accp.DepositoPoupança(valor);
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine(accp);
                            Console.WriteLine("-------------------------------------------------------------------");
                            break;
                        case 6:
                            Console.Write("Entre com o valor a ser transferido para Conta Corrente:");
                            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Clear();
                            accp.Saque(valor);
                            accB.Deposito(valor);
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine(accB);
                            Console.WriteLine("-------------------------------------------------------------------");
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("Operação encerrada!");
                            break;
                    }

                }
                catch (AccountException e)
                {
                    Console.Clear();
                    Console.WriteLine("Erro: " + e.Message);
                }

                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Erro Formato inválido");
                }
                

            }

        }

    }
}

