using System;
using System.Collections.Generic;
using System.Text;
using ContaBancaria.Entities.Exception;

namespace ContaBancaria.Entities
{
    class ContaBancaria2
    {
        public string Nome { get; set; }
        public int NumeroConta { get; set; }
        public double DepositoInicial { get; protected set; }


        public ContaBancaria2(string nome, int numeroConta, double depositoInicial)
        {          
            Nome = nome;
            NumeroConta = numeroConta;
            DepositoInicial = depositoInicial;
        }
        public virtual void Depositoinicial()
        {          
        }
        public virtual double Deposito(double valor)
        {
            return DepositoInicial;
        }
        public virtual double Transfericia(double valor)
        {                      
           return DepositoInicial;
        }
        public virtual double Saque(double valor)
        {
            return 0;
        }
       
      
    }
}

