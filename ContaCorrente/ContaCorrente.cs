using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class ContaCorrente
    {
        public double saldo { get; set; }
        public double numero{ get; set; }
        public double limite{ get; set; }
        public bool ehEspecial { get; set; }
        public string movimentacao { get; set; }
        public double Sacar(double sacar)
        {
            if (limite + saldo <= sacar)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            else if (saldo >= sacar)
            {
                saldo -= sacar;

                movimentacao += $"saque de R${sacar}\n";
            }

            return saldo;
        }
        public double Depositar(double depositar)
        {
            saldo += depositar;

            movimentacao += $"depósito de R${depositar}\n";

            return saldo;
        }
        public double TransferirPara(ContaCorrente nomeconta, double transferir)
        {
            if (saldo <= transferir)
            {
                Console.WriteLine("Saldo Insuficiente");
            }

            else if (saldo >= transferir)
            {
                saldo -= transferir;

                nomeconta.saldo += transferir;

                movimentacao += $"transferencia para Conta N°{nomeconta.numero} de R${transferir}\n";
            }

            return saldo;
        }
        public void VisualizarSaldo()
        {
            Console.WriteLine($"Seu saldo é de R${saldo}");
        }
        public void VisualizarExtrato()
        {
            Console.WriteLine(movimentacao);
        }
    }
}
