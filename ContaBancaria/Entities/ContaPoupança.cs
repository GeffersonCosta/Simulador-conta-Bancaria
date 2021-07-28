using System;
using System.Collections.Generic;
using System.Text;
using ContaBancaria.Entities.Exception;

namespace ContaBancaria.Entities
{
    class ContaPoupança : ContaBancaria2
    {
        public double SaldoPoupança { get; set; }

        public ContaPoupança(string nome, int numeroConta, double depositoInicial, double saldoPoupança)
            : base(nome, numeroConta, depositoInicial)
        {
            SaldoPoupança = saldoPoupança;       
        }
        public void DepositoPoupança(double valor)
        {
            if (valor < 0)
            {
                throw new AccountException("O valor do deposito não pode ser negativo ");
            }
            DepositoInicial -= valor;
            SaldoPoupança += valor;
        }
        public override double Saque(double valor)
        {
            if (SaldoPoupança < valor)
            {
                throw new AccountException("Saldo insufuciente! ");
            }
            return SaldoPoupança -= valor;
        }
        public override string ToString()
        {
            return "Saldo da Conta Poupança: $ " + SaldoPoupança.ToString("F2");       
        }


    }
}
