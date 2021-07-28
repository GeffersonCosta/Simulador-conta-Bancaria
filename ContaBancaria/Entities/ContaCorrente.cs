using System;
using System.Collections.Generic;
using System.Text;
using ContaBancaria.Entities.Exception;
namespace ContaBancaria.Entities
{
    class ContaCorrente : ContaBancaria2
    {
        public double SaldoContaCorrente { get; set; }

      

        public ContaCorrente(string nome, int numeroConta, double depositoInicial, double saldoContaCorrente)
            : base(nome, numeroConta, depositoInicial)
        {
           
            SaldoContaCorrente = saldoContaCorrente;
        }
        public override void Depositoinicial()
        {
            if (SaldoContaCorrente < 0)
            {
                throw new AccountException("O valor do deposito não pode ser negativo");
            }

            SaldoContaCorrente += DepositoInicial;
        }
        public override double Deposito(double valor)
        {
            if (valor < 0)
            {
                throw new AccountException("O valor do deposito não pode ser negativo");
            }
            SaldoContaCorrente += valor;
            return DepositoInicial += valor; 
        }
        public override double Saque(double valor)
        {
            double Taxas = 5.00;
            SaldoContaCorrente -= valor + Taxas;
            return DepositoInicial -= valor + Taxas;
        }
        public override double Transfericia(double valor)
        {
            if (valor > SaldoContaCorrente)
            {
                throw new AccountException("Saldo insufuciente! ");
            }
            DepositoInicial -= valor;
            SaldoContaCorrente -= valor;
            return base.Transfericia(valor);
        }
        public override string ToString()
        {
            return "Saldo da Conta Corrente: $" + SaldoContaCorrente.ToString("F2");
        }

    }
}
