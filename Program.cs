using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesafioCollatz
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 1;
            List<int> Lista = new List<int>();
            List<int> L = new List<int>();

            for (int i = 1; i < 13; i++)
            {
                L = Collatz(i);

                if (L.Count() > tamanho)
                {
                    tamanho = tamanho = L.Count;
                    Lista = L;
                }
            }
            for (int i = 0; i < Lista.Count(); i++)
            {
                Console.WriteLine("Valores da lista: " + Lista[i]);
            }
            
            Console.WriteLine("Tamanho da Lista: "+tamanho);
        }
        public static List<int> Collatz(int n)
            
        {
            List<int> Sequencia = new List<int>(n);
            ArrayList arrayList = new ArrayList(n);

            while ( n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                Sequencia.Add(n);
            }
            return Sequencia;
        }   
    }
    }
