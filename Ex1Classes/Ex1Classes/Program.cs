using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
public class ContaBancaria
{
    private string Idconta;
    private string idcliente;
    private int saldo;
    public string GetContaBancaria() { return Idconta; }
    public void SetContaBancaria(string id) { Idconta = id; }

    public string GetCliente() { return idcliente; }
    public void SetCliente(string id) { idcliente = id; }
    public int GetSaldo() { return saldo; }
    public void SetSaldo(int valor) { saldo = valor; }
    public double GetSaldoEuros()
    {
        return saldo / 100.0;
    }
    public bool Deposito(int valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            return true;
        }
        else return false;
    }

    public bool levantamento(int valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }
}
            
        
    
    


namespace Ex1Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            int opcao;

            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Levantar");
                Console.WriteLine("3 - Consultar Saldo");
                Console.WriteLine("4 - Listar Movimentos");
                Console.WriteLine("5 - Listar Movimentos por Intervalo");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                opcao = int.Parse(Console.ReadLine());
                switch(opcao) 
                {
                    case 1: 
            }
    }
}
