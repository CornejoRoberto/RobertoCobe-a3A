using System;

namespace RobertoCobeña3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0; int num1 = 0; int con = 0;
            Console.WriteLine("Escriba la cantidad de números a comparar 123444444");
               int numeros = int.Parse(Console.ReadLine());
               for (int i = 1; i <= numeros; i++)
               {
               con = con + 1;
               Console.WriteLine("Escriba su número #" + con);
               num1 = int.Parse(Console.ReadLine());
                  if (i == 1)
                  {
                   mayor = num1;
                  }
                if (num1 > mayor) { mayor = num1; }              
                }
            Console.WriteLine("El número mayor es:" + mayor);
                }
	    }
	 }
