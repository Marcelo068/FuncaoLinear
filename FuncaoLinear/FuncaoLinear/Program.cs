using System;

namespace FuncaoLinear
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float[] Xi, Yi, X2, XiYi;
            float XiTotal, YiTotal, X2Total, XiYiTotal, delta, deltaA, deltaB, a, b, x, y;

            Console.WriteLine("### Programa de Calculo de Função Linear ###");
            Console.WriteLine("Digite a quantidade de amostras: ");
            n = Convert.ToInt32(Console.ReadLine());


            Xi = RetornaLista(n, "Xi");
            Yi = RetornaLista(n, "Yi");
            X2 = RetornaListaAoQuadrado(n, Xi);
            XiYi = RetornaListaXiYi(n, Xi, Yi);

            XiTotal = RetornaSoma(n, Xi);
            YiTotal = RetornaSoma(n, Yi);
            X2Total = RetornaSoma(n, X2);
            XiYiTotal = RetornaSoma(n, XiYi);

            delta = (X2Total * n) - (XiTotal * XiTotal);
            deltaA = (XiYiTotal * n) - (XiTotal * YiTotal);
            deltaB = (X2Total * YiTotal) - (XiTotal * XiYiTotal);


            a = deltaA / delta;
            b = deltaB / delta;

            Console.WriteLine($"Y = {a} * X + {b} ");

            Console.WriteLine("Digite o valor de x:");
            x = float.Parse(Console.ReadLine());

            y = a * x + b;
            Console.WriteLine($"O valor de Y é: {y}");

        }

        private static float RetornaSoma(int n, float[] lista)
        {
            float soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += lista[i];
            }

            return soma;
        }

        private static float[] RetornaListaXiYi(int n, float[] Xi, float[] Yi)
        {
            float[] lista = new float[n];

            for (int i = 0; i < n; i++)
            {
                lista[i] = Xi[i] * Yi[i];
            }

            return lista;
        }
        private static float[] RetornaListaAoQuadrado(int n, float[] Xi)
        {
            float[] lista = new float[n];

            for (int i = 0; i < n; i++)
            {
                lista[i] = (float)Math.Pow(Xi[i], 2);
            }

            return lista;
        }
        private static float[] RetornaLista(int n, string nome)
        {
            float[] lista = new float[n];

            for(int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite o " + (i+1) + "º " + nome);
                lista[i] = float.Parse(Console.ReadLine());
            }

            return lista;
        }

    }
}
