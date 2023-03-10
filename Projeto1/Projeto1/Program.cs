using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário não escolher sair exiba o menu
            {
                // Exiba o menu

                Console.WriteLine("Seja bem vindo ao CALC, Selecione uma das opcoes:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                //string opcaoTXT = Console.ReadLine();
                //int opcaoInt = int.Parse(opcaoTXT);
                //Menu opcao = (Menu)opcaoInt;

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {  
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                  
                }

                Console.Clear();
            }

            static void Soma()
            {
                Console.WriteLine("Soma de dois numeros: ");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a + b;
                Console.WriteLine($"O resultado é: {resultado}");
                Console.WriteLine("Aperte o ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Subtracao()
            {
                Console.WriteLine("Subtracao de dois numeros: ");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a - b;
                Console.WriteLine($"O resultado é: {resultado}");
                Console.WriteLine("Aprte o ENTER para voltar ao menu");
                Console.ReadLine();
            }
            
            static void Divisao()
            {
                Console.WriteLine("Divisao de dois numeros: ");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                double resultado = (double)a / (double)b;
                Console.WriteLine($"O resultado é: {resultado}");
                Console.WriteLine("Aprte o ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Multiplicacao()
            {
                Console.WriteLine("Multiplicacao de dois numeros: ");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a * b;
                Console.WriteLine($"O resultado é: {resultado}");
                Console.WriteLine("Aprte o ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Potencia()
            {
                Console.WriteLine("Potencia de um numero: ");
                Console.WriteLine("Digite a base: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = (int)Math.Pow(a,b);
                Console.WriteLine($"O resultado é: {resultado}");
                Console.WriteLine("Aprte o ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Raiz()
            {
                Console.WriteLine("Raiz de um numero: ");
                Console.WriteLine("Digite um numero: ");
                int a = int.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a);
                Console.WriteLine($"O resultado é: {resultado}");
                Console.WriteLine("Aprte o ENTER para voltar ao menu");
                Console.ReadLine();
            }
        }
    }
}