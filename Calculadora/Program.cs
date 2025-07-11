using System;
using System.Collections.Concurrent;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int condicao;
            float conta_save = 0;
            bool primeiraConta = true;
            do
            {
                float conta = 0;
                float valor1, valor2;
                Console.WriteLine("=== Calculadora ===");
                Console.Write(" 1 - Somar.\n 2 - Subtrair. \n 3 - Dividir. \n 4 - Multiplicar.\n");
                int opcao = int.Parse(Console.ReadLine());

                if (primeiraConta)
                {
                    Numeros(out valor1, out valor2);
                    primeiraConta = false;
                }
                else
                {
                    Console.WriteLine("Deseja continuar com o resultado anterior como o primeiro número?");
                    Console.WriteLine("1 - Sim\n2 - Não");
                    int usarAnterior = int.Parse(Console.ReadLine());

                    if (usarAnterior == 1)
                    {
                        valor1 = conta_save;
                        Console.Write("Digite o segundo número: ");
                        valor2 = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Numeros(out valor1, out valor2);
                    }
                }
                switch (opcao)
                {
                    case 1:
                        conta = valor1 + valor2;
                        break;
                    case 2:
                        conta = valor1 - valor2;
                        break;
                    case 3:
                        conta = valor1 / valor2;
                        break;
                    case 4:
                        conta = valor1 * valor2;
                        break;
                }
                Console.WriteLine($"Resultado: {conta}");
                conta_save = conta;
                Console.WriteLine("Deseja continuar a conta?\n 1 - Sim\n 2 - Nao");
                condicao = int.Parse(Console.ReadLine());

            } while (condicao == 1);
        }
         static void Numeros(out float valor1, out float valor2)
            {
                    Console.Write("Digite o primeiro numero: ");
                    valor1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo numero: ");
                    valor2 = float.Parse(Console.ReadLine());
            }
    }
}