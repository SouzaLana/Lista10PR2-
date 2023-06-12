using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exc1()
        {
            int[] vet;
            float menorV, maiorV, it = 0, ma;

            menorV = float.MaxValue;
            maiorV = float.MinValue;

            Console.WriteLine("Entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet = new int[t];

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Entre com a posição[{0}]", i);
                vet[i] = int.Parse(Console.ReadLine());
                it += vet[i];

                if (vet[i] < menorV)
                {
                    menorV = vet[i];
                }
                if (vet[i] > maiorV)
                {
                    maiorV = vet[i];
                }
            }
            ma = it / t;
            Console.WriteLine("O menor número é " + menorV);
            Console.WriteLine("O maior número é " + maiorV);
            Console.WriteLine("A média aritmética dos números é " + ma);
        }
        public static void Exc2()
        {
            int[] vet;
            float it = 0, ma;

            Console.WriteLine("Entre com o tamanho. Deve ser maior que 0!");
            int t = int.Parse(Console.ReadLine());

            if (t == 0)
            {
                Console.ReadKey();
            }

            vet = new int[t];

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Entre com a posição[{0}]", i);
                vet[i] = int.Parse(Console.ReadLine());
                it += vet[i];
            }

            ma = it / t;

            Console.WriteLine("Os números maiores que a média " + ma + " são:");

            for (int i = 0; i < t; i++)
            {
                if (vet[i] >= ma)
                {
                    Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
                }
            }
        }
        public static void Exc3()
        {
            int[] vet;
            float it = 0, ma;

            Console.WriteLine("Entre com o tamanho. Deve ser maior que 0!");
            int t = int.Parse(Console.ReadLine());

            if (t == 0)
            {
                Console.ReadKey();
            }

            vet = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(10, 50);
                it += vet[i];
            }

            ma = it / t;

            Console.WriteLine("Os números maiores que a média " + ma + " são:");

            for (int i = 0; i < t; i++)
            {
                if (vet[i] >= ma)
                {
                    Console.WriteLine("posição[{0}] = {1}", i, vet[i]);
                }
            }
        }
        public static void Exc4()
        {
            string[] vet;

            Console.WriteLine("Entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet = new string[t];

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Entre com a posição[{0}]", i);
                vet[i] = Console.ReadLine();
            }

            Array.Reverse(vet);
            Console.WriteLine("");

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
        public static void Exc5()
        {
            int[] vet;
            int p = 0, imp = 0;

            Console.WriteLine("Entre com o tamanho. Deve ser maior que 0!");
            int t = int.Parse(Console.ReadLine());

            if (t == 0)
            {
                Console.ReadKey();
            }

            vet = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(10, 50);

                if (vet[i] % 2 == 0)
                {
                    p += 1;
                }
                else
                {
                    imp += 1;
                }
            }

            Console.WriteLine("Existem " + p + " números pares no vetor gerado");
            Console.WriteLine("Existem " + imp + " números ímpares no vetor gerado");
        }
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("===MENU===");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Escolha um exercício: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Exc1();
                    break;
                case 2:
                    Exc2();
                    break;
                case 3:
                    Exc3();
                    break;
                case 4:
                    Exc4();
                    break;
                case 5:
                    Exc5();
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
            Console.ReadKey();
        }
    }
}