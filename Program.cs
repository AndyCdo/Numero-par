using System;

namespace Numero_par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int Numeros= Int32.Parse(Console.ReadLine());
            bool resultado=Par(Numeros);
            Console.WriteLine("El numero es " + resultado);
            
        }
        static bool Par(int numero){
            if (numero % 2 == 0){
                return true;
            }
            else{
                return false;
            }
    
        }
    }
}
