using System;

namespace EjercicioFunciones
{
    class Program
    {
        private static double area_rectangulo(double base1, double altura)
        {
            double area;
            area = base1 * altura;
            return area;
        }
        private static void mensaje_area(double area)
        {
            Console.WriteLine("El area del rectangulo es " + area);
        }
        private static int relacion(int a, int b)
        {
            if(a>b)
            {
                return 1;
            }
            else
            {
                if (a == b)
                    return 0;
                else
                    return -1;
            }
        }
        private static int recortar(int numero, int minimo, int maximo)
        {
            if (numero < minimo)
            {
                return minimo;
            }
            else
                if (numero == minimo)
                return numero;
            else
                if (numero > maximo)
                    return maximo;
            else
            {
                return numero;
            }
        }
        static void Main(string[] args)
        {

            //Ejercicio 1: Realiza una función llamada area_rectangulo(base, altura) que devuelva el área del rectangulo a partir de una base y una altura. 
            /*
            double b, a, area,area2,c,d;
            Console.WriteLine("Ingrese la base");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            a = double.Parse(Console.ReadLine());
            area = area_rectangulo(b, a);
            Console.WriteLine("Ingrese la base");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            d = double.Parse(Console.ReadLine());
            area2 = area_rectangulo(c, d);
            mensaje_area(area);
            mensaje_area(area2);
            //Console.WriteLine("El area del rectangulo es " + area);*/
            //Fin Ejercicio 1

            //Ejercicio 2:Realiza una función llamada relacion(a, b) que a partir de dos números cumpla lo siguiente:Si el primer número es mayor que el segundo, debe devolver 1.Si el primer número es menor que el segundo, debe devolver -1.Si ambos números son iguales, debe devolver un 0.
            /*int a, b, resultado;
            Console.WriteLine("Ingrese el numero A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero B");
            b = int.Parse(Console.ReadLine());
            resultado=relacion(a, b);
            Console.WriteLine("El resultado del cálculo es " + resultado);*/
            //Fin Ejercicio 2

            //Ejercicio 3:Realiza una función llamada recortar(numero, minimo, maximo) que reciba tres parámetros. El primero es el número a recortar, el segundo es el límite inferior y el tercero el límite superior. La función tendrá que cumplir lo siguiente:Devolver el límite inferior si el número es menor que éste, Devolver el límite superior si el número es mayor que éste, Devolver el número sin cambios si no se supera ningún límite.
            /*int n, min, max,resultado;
            Console.WriteLine("Ingrese el número");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mínimo");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el máximo");
            max = int.Parse(Console.ReadLine());
            resultado=recortar(n, min, max);
            Console.WriteLine("El resultado del recorte es " + resultado);*/
            //Fin Ejercicio 3
        }
    }
}
