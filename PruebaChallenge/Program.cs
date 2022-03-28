using System;

namespace PruebaChallenge
{
    class Program
    {
        static void Main(string[] args)
        {                      
            Console.WriteLine("Simplificar 2/3 = " + Ejercicio1.Simplificar("2/3"));
            Console.WriteLine("Simplificar 10/11 = " + Ejercicio1.Simplificar("10/11"));
            Console.WriteLine("Simplificar 100/400 = " + Ejercicio1.Simplificar("100/400"));            

            Console.WriteLine("E. Poe = " + Ejercicio2.ValidarNombre("E. Poe"));
            Console.WriteLine("E. A. Poe = " + Ejercicio2.ValidarNombre("E. A. Poe"));
            Console.WriteLine("Edgard A. Poe = " + Ejercicio2.ValidarNombre("Edgard A. Poe"));
            Console.WriteLine("Edgard = " + Ejercicio2.ValidarNombre("Edgard"));
            Console.WriteLine("e. Poe = " + Ejercicio2.ValidarNombre("e. Poe"));
            Console.WriteLine("E Poe = " + Ejercicio2.ValidarNombre("E Poe"));
            Console.WriteLine("E. Allan Poe = " + Ejercicio2.ValidarNombre("E. Allan Poe"));
            Console.WriteLine("E. Allan P. = " + Ejercicio2.ValidarNombre("E. Allan P."));
            Console.WriteLine("Edg. Allan Poe = " + Ejercicio2.ValidarNombre("Edg. Allan Poe"));
        }            
    }

    public class Ejercicio1
    {
        public static String Simplificar(String division)
        {
            try
            {
                int numerador = Convert.ToInt32(division.Split("/")[0]);
                int denominador = Convert.ToInt32(division.Split("/")[1]);
                int mcd = MCD(numerador, denominador);
                return numerador / mcd + "/" + denominador / mcd;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        static int MCD(int n1, int n2)
        {
            while (n1 != n2)
            {
                if (n1 > n2) { n1 = n1 - n2; continue; }
                n2 = n2 - n1;
            }
            return n1;
        }
    }

    public class Ejercicio2
    {
        public static bool ValidarNombre(String nombre)
        {
            String[] n = nombre.Split(" ");
            if (n.Length != 2 && n.Length != 3) return false; // c           
            if (n[n.Length - 1].Length < 2) return false;   // e            
            for (int i = 0; i < n.Length; i++) // a, b
            {
                if (!Char.IsUpper(n[i][0])) return false;
                if (n[i].Length == 1) return false;
                if (n[i].Length == 2 && !n[i].Contains(".")) return false;
                if (n[i].Length > 2 && n[i].Contains(".")) return false;
            }
            if (n.Length == 3 && (n[0].Length == 2 && n[1].Length > 2)) return false;  // d
            return true;
        }
    }
}
