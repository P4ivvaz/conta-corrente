using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUNDA_CONTA_CORRENTE
{
    internal class ContaCorrente
    {
     



            public string Titular;
            public double Saldo;
            public int Numero;

            // Construtor : Inicializa os atributos da classe (Titular, Saldo, Numero) quando uma nova instância de ContaCorrente é criada.
            public ContaCorrente(string titular, double saldo, int numero)
            {
                Titular = titular;
                Saldo = saldo;
                Numero = numero;
            }

            // Método para depositar : adiciona uma quantia ao saldo. O valor precisa ser positivo, caso contrário, será mostrado um erro.
            public void Depositar(double valor)
            {
                if (valor > 0)
                {
                    Saldo += valor;
                    Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("O valor para depósito deve ser positivo.");
                }
            }

            // Método para sacar : Verifica se o valor é positivo e se há saldo suficiente para o saque
            public void Sacar(double valor)
            {
                if (valor > 0 && valor <= Saldo)
                {
                    Saldo -= valor;
                    Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
                }
                else if (valor > Saldo)
                {
                    Console.WriteLine("Saldo insuficiente para saque.");
                }
                else
                {
                    Console.WriteLine("O valor para saque deve ser positivo.");
                }
            }

            // Método para exibir saldo atual da conta 
            public void ExibirSaldo()
            {
                Console.WriteLine($"Saldo atual: R${Saldo}");
            }
        }
    }



