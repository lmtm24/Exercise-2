using System;

namespace Exercise_2
{
    class MainClass
    {

        public string name = "";
        public static string text = "civic";


        public MainClass()
        {
            name = "Inizializing";
        }

        public MainClass(String name)
        {
            this.name = name;
        }


        public double calculate(double a, double b)
        {
            return a + b;

        }

        public int calculate(int x, int y)
        {
            return x * y;

        }

        public bool IsPalindrome(string text)
        {
            string rev;
            char[] ch = text.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = text.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void diagonal()
        {

            int a = 5, b = 5;

            int[,] bidimencion;
            bidimencion = new int[a, b];


            //llenado
            int aux = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    bidimencion[i, j] = aux;
                    aux++;
                }
            }

            Console.WriteLine("Diagonal");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    if (i == j) { Console.Write(bidimencion[i, j]); }
                    else { Console.Write("  "); }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Impresion de la matriz");

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    Console.Write(bidimencion[i, j]);

                    if (j + 1 == b) { Console.WriteLine(); } else { Console.Write(","); }

                }

            }

        }




        public static void Main(string[] args)
        {
            MainClass m = new MainClass();
            MainClass m2 = new MainClass("Overloading");
            MainClass m3 = new MainClass("Overloading");
            MainClass m4 = new MainClass();
            Console.WriteLine("---------------------");
            Console.WriteLine(m.name);
            Console.WriteLine("---------------------");
            Console.WriteLine(m2.name);
            Console.WriteLine("---------------------");
            Console.WriteLine(m.calculate(10.10, 20.02));
            Console.WriteLine("---------------------");
            Console.WriteLine(m2.calculate(10, 20));
            Console.WriteLine("---------------------");
            Console.WriteLine(m3.IsPalindrome(text));
            Console.WriteLine("---------------------");
            m4.diagonal();
        }
    }

}
