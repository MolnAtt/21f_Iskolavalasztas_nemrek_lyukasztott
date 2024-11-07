using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21f_Iskolavalasztas_nemrek
{
	internal class Program
	{
		private static (bool van, int j) Oszlopban_keres(int i, int[] result /* ITT */) // ez a függőleges mászkálás
		{
			int j = result[i] + 1; // -1-es inicializálásból itt lesz 0-ás index!
			while (j <  /* ITT */ && Rossz(i, j  /* ITT */)) // a rossz-ban lesz szó egyedül a sakkról!
			{
				j++;
			}
			return (j <  /* ITT */, j);
		}
		private static bool Rossz(int i, int j /* ITT */) 
		{
			/* ITT */
		}
		static int[] Feldolgozas(int N, int M /* ITT */)
		{
			int[] result = new int[N];
			for (int ix = 0; ix < N; ix++)
			{
				result[ix] = -1;
			}
			int i = 0;

			while (-1 < i && i < N) // vízszintes mászkálás
			{
				(bool van, int j) = Oszlopban_keres(i, result  /* ITT */);
				if (van)
				{
					result[i] = j;

					/* ITT */

				}
				else
				{
					result[i] = -1;

					/* ITT */

				}
			}
			return result;
		}

		static (int, int, List<int>[], int[]) Beolvas()
		{
			string sor = Console.ReadLine();
			string[] sortomb = sor.Split(' ');
			int N = int.Parse(sortomb[0]);
			int M = int.Parse(sortomb[1]);

			List<int>[] tanulok = new List<int>[N];
			for (int i = 0; i < N; i++)
			{
				string[] s = Console.ReadLine().Split(' ');
				tanulok[i] = new List<int>();
				tanulok[i].Add(int.Parse(s[0]));
				if (s[1]!="0")
				{
					tanulok[i].Add(int.Parse(s[1]));
				}
			}

			int[] kapacitasok = new int[M];

			for (int i = 0; i < M; i++)
			{
				kapacitasok[i] = int.Parse(Console.ReadLine());
			}
			return (N, M, tanulok, kapacitasok);
		}
		static void Diagnosztika(int[] result, List<int>[] tanulok, int[] kapacitas)
		{
			Console.Error.Write(string.Join(" ", kapacitas));
            Console.Error.Write("    |    ");
			for (int i = 0; i < tanulok.Length; i++)
			{
				if (0 <= result[i])
				{
					Console.Error.Write(tanulok[i][result[i]]+" "); 
				}
			}
            Console.Error.WriteLine();
		}

		static void Kiir(int[] result /* ITT */)
		{
			if (0 <= result[0])
			{
				/* ITT */
			}
			else
			{
                Console.WriteLine(-1);
            }
		}
		static void Main(string[] args)
		{
			(int N, int M, List<int>[] tanulok, int[] kapacitas)  = Beolvas();
			int[] result = Feldolgozas(N, M /* ITT */);
			//Diagnosztika(result, tanulok, kapacitas);
            Console.Error.WriteLine(string.Join(", ", result));
			Kiir(result /* ITT */);
			//Console.ReadKey();

		}
	}
}


/*

9 4 
1 2 
1 2 
1 0 
2 3 
2 4 
1 4 
1 2 
3 4 
3 0 
2 
3 
0 
0 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */ 