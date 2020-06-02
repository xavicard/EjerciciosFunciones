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
        public static int factorial(int n)
        {
            int i,factorial=1;
            for(i=1;i<=n;i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        // factorial: 1*2*3*4*5*.....*N
        // factorial: N*N-1*N-2*....3*2*1
        //5*factorial(4)
        //5*4*factorial(3)
        //5*4*3*factorial(2)
        //5*4*3*2*factorial(1)
        //5*4*3*2*1
        public static int factorial_recursiva(int n)
        {
            if(n>1)
            {
                return n*factorial_recursiva(n-1);
            }
            else
            {
                return 1;
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

            //Ejercicio 4: 1/2! + 2/3! + 3/4! .... n/n+1!
            /*int n,i;
            double resultado = 0.0;
            Console.WriteLine("Ingrese el valor de N");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                resultado += ((double) i / factorial(i + 1));
            }
            Console.WriteLine("El resultado es " + resultado);*/
            //Fin Ejercicio 4
            //Ejercicio 5
            int n;
            double resultado = 0.0;
            Console.WriteLine("Ingrese el valor de N");
            n = int.Parse(Console.ReadLine());
            if(n>=4)
            {
                resultado = (double)factorial_recursiva(n) / factorial_recursiva(n - 4);
                Console.WriteLine("El resultado es " + resultado);
            }
            else
            {
                Console.WriteLine("ERROR: N debe ser mayor o igual a 4");
            }
            //Fin Ejercicio 5
        }
    }
}
