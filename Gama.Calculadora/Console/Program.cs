using System;

namespace Gama.Calculadora.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(Soma(3, 3));
            //System.Console.WriteLine(Sub(3, 3));
            //System.Console.WriteLine(Mult(3, 3));
            //System.Console.WriteLine(Div(3, 2));

            System.Console.WriteLine("Escolha a operação: ");
            System.Console.WriteLine("1 - Divisão");
            System.Console.WriteLine("2 - Multiplicação");
            System.Console.WriteLine("3 - Soma");
            System.Console.WriteLine("4 - Subtração");
            System.Console.WriteLine("Digite o numero: ");


            var op = System.Console.ReadLine();
            var a = 2;
            var b = 2;

            double resultado = 0;

            //if (op == "1")
            //{
            //    System.Console.WriteLine(Div(a, b));
            //}
            //else if (op == "2")
            //{
            //    System.Console.WriteLine(Mult(a, b));
            //}

            //else if (op == "3")
            //{
            //    System.Console.WriteLine(Soma(a, b));
            //}

            //else if (op == "4")
            //{
            //    System.Console.WriteLine(Sub(a, b));
            //}
            //else
            //{
            //    System.Console.WriteLine("Opção invalida");
            //}
            //while ou do while
            //do
            //{
            //    System.Console.WriteLine("repetindo ainda");
            //    System.Console.ReadKey();

            //} while (true);
            //for(int i = 0; i < 10; i++)
            //{
            //    System.Console.WriteLine(i);
            //}



            switch (op)
            {
                case "1":
                    resultado = (Div(a, b));
                    break;
                case "2":
                    resultado = (Mult(a, b));
                    break;
                case "3":
                    resultado = (Soma(a, b));
                    break;
                case "4":
                    resultado = (Sub(a, b));
                    break;
                default:
                    System.Console.WriteLine("Opção invalida!");
                    break;
            }
            System.Console.WriteLine(resultado != 0 ? resultado.ToString() : "Sem resultado");
            var meuarray = new[] { "pri", "charlie" };
            System.Console.WriteLine(meuarray[0]);

            //var lista = new List<string>()
            //{
            //    "teste",
            //    "teste2"
            //}

            //var lista2 = lista.ToArray().AsEnumerable();
            //var lista2 = lista.ToArray().AsQueryble();
            //lista2.add
        }
        #region Metodos
        static int Soma(int a, int b)
        {
            return a + b;

        }
        static int Sub(int a, int b)
        {
            return a - b;

        }
        static int Mult(int a, int b)
        {
            return a * b;

        }
        static double Div(double a, double b)
        {
            return a / b;

        }

        #endregion    
    }
    }