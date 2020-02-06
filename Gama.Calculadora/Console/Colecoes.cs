using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //

namespace Gama.Calculadora.Console
{
    public class Colecoes
    {
        /// <summary>
        /// Arrays são coleções não dinamicas, ou seja, não se adiciona em tempo de execução!
        /// </summary>
        public static void TrabalhandoComArray()
        {
            var nomes = new string[5]; 
            //forma de declarar array
            nomes[0] = "yoda";
            nomes[1] = "pri";
            nomes[2] = "pimpa";
            nomes[3] = "pipoca";
            nomes[4] = "iris";

            
            for (int i = 0; i < nomes.Length ; i++)
            {
                System.Console.WriteLine(nomes[i]);
            }
        }

        /// <summary>
        /// Lista é dinamica
        /// </summary>
        public static void TrabalhandoComLista()
        {
            var nomes = new List<string>() 
            {
                "Priscila",
                "Pimpa"
            };

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine("Informe o nome: ");
                
                var novo = System.Console.ReadLine();
                
                nomes.Add(novo);
                
                System.Console.Clear();
            }
        }
        /// <summary>
        /// FIFO - Nao da pra remover alguem do meio da lista
        /// </summary>
        public static void TrabalhandoComFila()
        {
            var nomes = new Queue<string>();
            nomes.Enqueue("Joana");
            nomes.Enqueue("Maria");
            nomes.Enqueue("Joaquina");

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine("Pressione qualquer tecla para retirar da fila: ");

                System.Console.ReadKey();

                nomes.Dequeue();

                System.Console.Clear();
            }
        }

        public static void TrabalhandoComPilha()
        {
            var nomes = new Stack<string>();
            nomes.Push("Joana");
            nomes.Push("Maria");
            nomes.Push("Joaquina");

            while (true)
            {
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }

                System.Console.WriteLine("Pressione qualquer tecla para retirar da fila: ");

                System.Console.ReadKey();

                nomes.Pop();

                System.Console.Clear();
            }
        }

        public static void TrabalhandoComDicionario()
        {
            var nomes = new Dictionary<string, int>();
                nomes.Add("Joana", 22);
                nomes.Add("Amanda", 32);
                nomes.Add("Bruna", 13);

            var resultado = nomes.First(item => item.Key == "Amanda");
            var resultado2 = nomes.First(item => item.Value == 22);

            //foreach(var n in nomes)

            System.Console.WriteLine(resultado);
            System.Console.WriteLine(resultado2);

        }

        public static void FiltrandoLista()
        {
            var nomes = new List<string>()
            {
                "Priscila",
                "Pimpa"
            };
            var resultado = nomes.SingleOrDefault(item => item == "Priscila");
            //var resultado = nomes.Single(item => item == "Priscila");
            //var resultado = nomes.Where(item => item == "Priscila")
            //.Skip(10)
            //.Take(10);

            System.Console.WriteLine(resultado);

        }

    }
}
