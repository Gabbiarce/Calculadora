using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     class Calculadora
    {

        static void Main(String[] args)
        {

            double numero1;
            double numero2;
            string operacion;
            double resultado;
            bool esValido;

            Console.WriteLine("Ingresar el primer numero: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("Ingresar la operacion a realizar: ");
                operacion = Console.ReadLine();

                esValido = operacion.Equals("+") || operacion.Equals("-") || operacion.Equals("*") || operacion.Equals("/");

                if (!esValido)
                {
                    Console.WriteLine("La operacion ingresada es incorrecta.");
                }

            } while (!esValido);

            resultado = calcular(numero1, numero2, operacion);

            Console.WriteLine("El resultado de la operacion es: "+resultado+".");

            Console.ReadKey();

        }

        public static double calcular(double numero1, double numero2, string operacion) {

            double resultado = 0;

            switch (operacion) {
                case "+": 
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }else {
                        Console.WriteLine("No se puede dividir por 0!!!!!");
                    }
                    break;
            }


            return resultado;
        }

    }
}
