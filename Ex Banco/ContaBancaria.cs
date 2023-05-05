using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Banco
{
    class ContaBancaria
    {
        public int NumeroConta { get; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public static double Taxa = 5.00;


        //Construtores

        //Construtor permite instanciar conta com numero e titular (sem deposito inicial)
        public ContaBancaria(int numero, string titular)
        {
            NumeroConta = numero;
            Nome = titular;
        }

        //Construtor permite instanciar a conta com numero, titular e salso (deposito inicial)
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        //Método permite depositar dinheiro na conta
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        //Método permite levantar dinheiro da conta
        public void Levantamento(double quantia)
        {
            Saldo -= quantia + Taxa;
        }


        public override string ToString()
        {
            return "Conta Bancária Nº "
                +NumeroConta
                +", Titular da Conta: "
                +Nome
                +", Saldo: "
                +Saldo
                +"EUR";
        }
    }
        
    
}
