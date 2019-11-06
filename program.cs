using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void situacaoIMC(double imc)
        {
            if (imc < 20)
                Console.WriteLine("Abaixo do Peso");
            else if (imc < 25)
                Console.WriteLine("Peso Normal");
            else if (imc < 30)
                Console.WriteLine("Sobrepeso");
            else if (imc < 40)
                Console.WriteLine("Obesidade");
            else
                Console.WriteLine("Obesidade Mórbida");
        }

        static double calculoImc (double peso, double altura)
        {
            return (peso / (altura * altura));
        }
        static int[] preencherVetor(int x)
        {
            int[] v = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Informe o valor da {0}ª posição: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());
            }

            return (v);
        }
        static void sequencia(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        static int fatorial(int n)
        {
            int i, fat = 1;

            for (i = 1; i <= n; i++)
                fat = fat * i;

            return (fat);
        }

        static bool palindrome(string p)
        {
            int i, j;

            i = 0;
            j = p.Length - 1;

            while ((i <= j) && (p[i] == p[j]))
            {
                i++;
                j--;
            }

            if (i < j)
                return (false);
            else
                return (true);
        }

        /*
        (a) abaixo de 20: abaixo do peso
        (b) de 20 (inclusive) a 25: peso normal
        (c) de 25 (inclusive) a 30: sobrepeso
        (d) de 30 (inclusive) a 40: obesidade
        (e) igual ou superior a 40: obesidade mórbida
        */

        static double delta(double a, double b, double c)
        {
            return (b * b - 4 * a * c);
        }

        static void situacaoDelta(double d)
        {
            if (d < 0)
                Console.WriteLine("Não existem raízes reais.");
            else if (d == 0)
                Console.WriteLine("Existem duas raízes reais e iguais.");
            else
                Console.WriteLine("Existem duas raízes reais e distintas.");
        }

        static string diaDaSemanaF(int n)
        {
            switch (n)
            {
                case 1:
                    return ("domingo");

                case 2:
                    return ("segunda");

                case 3:
                    return ("terça");

                case 4:
                    return ("quarta");

                case 5:
                    return ("quinta");

                case 6:
                    return ("sexta");

                case 7:
                    return ("sábado");

                default:
                    return ("dia inválido");
            }
        }

        static void diaDaSemanaP(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("domingo");
                    break;

                case 2:
                    Console.WriteLine("segunda");
                    break;

                case 3:
                    Console.WriteLine("terça");
                    break;

                case 4:
                    Console.WriteLine("quarta");
                    break;

                case 5:
                    Console.WriteLine("quinta");
                    break;

                case 6:
                    Console.WriteLine("sexta");
                    break;

                case 7:
                    Console.WriteLine("sábado");
                    break;

                default:
                    Console.WriteLine("dia inválido");
                    break;
            }
        }

        static bool diaValido(int dia)
        {
            if ((dia > 7) || (dia < 1))
                return (false);
            else
                return (true);
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Fatorial");
            Console.WriteLine("2 - Potência");
            Console.WriteLine("3 - Produto");
            Console.WriteLine("4 - Palíndrome");
            Console.WriteLine("5 - Sequência");
            Console.WriteLine("6 - Delta");
            Console.WriteLine("7 - Dia da Semana (Função)");
            Console.WriteLine("8 - Dia da Semana (Procedimento)");
            Console.WriteLine("9 - Preenche Vetor");
            Console.WriteLine("10 - Exibe Vetor");
            Console.WriteLine("11 - Maior Elemento");
            Console.WriteLine("12 - Busca Elemento");
            Console.WriteLine("13 - Conta Elemento");
            Console.WriteLine("14 - Conta Maiores");
            Console.WriteLine("15 - IMC");
            Console.WriteLine("16 - Situação IMC");
            Console.WriteLine("17 - Sair");
            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            int op, x;
            double a, b, c, d, imc = 0;
            string p;
            int[] v = new int [4];

            do
            {
                op = menu();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o número: ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 0)
                            Console.WriteLine("Valor inválido.");
                        else
                            Console.WriteLine("O fatorial de {0} é {1}", x, fatorial(x));
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Informe a palavra: ");
                        p = Console.ReadLine();
                        if (palindrome(p))
                            Console.WriteLine("{0} é palíndrome.", p);
                        else
                            Console.WriteLine("{0} não é palíndrome.", p);
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.Write("Informe Um Valor Inteiro: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Os números entre 1 e {0} são: ", x);
                        sequencia(x);
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.Write("Coeficiente a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Coeficiente b: ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Coeficiente c: ");
                        c = double.Parse(Console.ReadLine());

                        d = delta(a, b, c);

                        Console.WriteLine("delta = {0}", d);

                        situacaoDelta(d);

                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.Write("Informe o número do dia da semana: ");
                        x = int.Parse(Console.ReadLine());

                        while (!diaValido(x))
                        {
                            Console.WriteLine("Dia inválido.");
                            Console.Write("Informe o número do dia da semana: ");
                            x = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine(diaDaSemanaF(x));

                        Console.ReadKey();
                        break;

                    case 8:
                        Console.Clear();
                        Console.Write("Informe o número do dia da semana: ");
                        x = int.Parse(Console.ReadLine());

                        while (!diaValido(x))
                        {
                            Console.WriteLine("Dia inválido.");
                            Console.Write("Informe o número do dia da semana: ");
                            x = int.Parse(Console.ReadLine());
                        }

                        diaDaSemanaP(x);
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.Clear();
                        Console.Write("Informe o tamanho do vetor: ");
                        x = int.Parse(Console.ReadLine());
                        v = preencherVetor(x);
                        Console.ReadKey();
                        break;

                    case 10:
                        Console.Clear();
                        Console.WriteLine("O Vetor construído foi: ");

                        for (int i = 0; i < v.Length; i++)
                        {
                            Console.Write("{0}  ", v[i]);
                        }
                        Console.ReadKey();
                        break;

                    case 11:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 12:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 13:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 14:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    case 15:
                        Console.Clear();
                        double peso, altura;
                        Console.Write("Informe o peso: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.Write("Informe a Alttura: ");
                        altura = double.Parse(Console.ReadLine());

                        imc = calculoImc(peso, altura);
                        Console.WriteLine("IMC: {0}", imc);                  
                        Console.ReadKey();
                        break;

                    case 16:
                        Console.Clear();
                        situacaoIMC(imc);
                        Console.ReadKey();
                        break;
                }

            } while (op != 17);
        }
    }
}
