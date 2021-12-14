using System;

namespace RevMatrizMNVizinhos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o tamanho de sua matriz (M,N), sendo M linhas e N colunas : ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------");

            int[,] mat1 = new int[m, n];
            Console.WriteLine("Digite os valores de sua matriz da esquerda para direita de cima para" +
                " baixo separados por espaço e ao final de cada linha press 'enter' para proxima");

            for (int i = 0; i < m; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat1[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Digite um número para verificar se está na matriz e conhecer seus vizinhos");

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat1[i, j] == x) {
                        Console.WriteLine("Posição : " + i + "," + j);
                        if (j > 0) {
                            Console.WriteLine("Vizinho esquerda : " + mat1[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Vizinho cima : " + mat1[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Vizinho direita : " + mat1[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Vizinho baixo : " + mat1[i + 1, j]);
                        }
                    }
                }


            }
        }
    }
}
