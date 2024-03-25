using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioLiquido1 = 0;
            double salarioLiquido2 = 0;
            double ir = 0;
            Console.WriteLine("Insira o Tipo de Contratação: (A)SSALARIADO (C)OMISSIONADO (H)ORISTA");
            string tipo = Console.ReadLine();

            switch (tipo)
            {
                case "A":
                    Console.WriteLine("Insira o salário: ");
                    double sal = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o desconto: ");
                    double desc = double.Parse(Console.ReadLine());
                    salarioLiquido1 = sal - desc;
                    break;
                case "C":
                    Console.WriteLine("Insira a quantidade de Peças: ");
                    int qtdPcs = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o valor pago por cada Peça: ");
                    double valor = double.Parse(Console.ReadLine());
                    salarioLiquido1 = qtdPcs * valor;
                    break;
                case "H":
                    Console.WriteLine("Insira a quantidade de horas trabalhadas: ");
                    double hrs = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o valor da hora: ");
                    double valorHr = double.Parse(Console.ReadLine());
                    salarioLiquido1 = valorHr * hrs;
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            if (salarioLiquido1 < 2000.01)
            {
                salarioLiquido2 = salarioLiquido1 - (salarioLiquido1 * 0.075);
            }
            else if (salarioLiquido1 < 4000.01)
            {
                salarioLiquido2 = salarioLiquido1 - (salarioLiquido1 * 0.12);
            }
            else
            {
                salarioLiquido2 = salarioLiquido1 - (salarioLiquido1 * 0.15);
            }

            Console.WriteLine("O seu salário liquído é: " + salarioLiquido2);
            Console.ReadKey();


        }
    }
}