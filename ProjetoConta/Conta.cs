using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjetoConta
{
    class Conta
    {
       public int Numero { get; private set; }
       public string Titular { get; private set; }
       public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            
        }

        public Conta (int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public override string ToString()
        {
            return "Conta "  
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void Deposito(double dep)
        {
            Saldo += dep;
        }
        public void Saque(double saq)
        {
            Saldo -= saq + 5.0;
        }
    }
}
