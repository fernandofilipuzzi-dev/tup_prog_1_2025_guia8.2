using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_sin_clase
{
    internal class Program
    {
        #region variables globales
        static int variables = 0;
        static int acumulador;
        static int contador;
        static int maximo, minimo;
        #endregion

        #region metodos 
        static int SolicitarOpcionMenu()
        {
            Console.WriteLine("Ingrese las siguiente opciones:");
            Console.WriteLine("1- Solicitar un solo número");
            Console.WriteLine("2- Solicitar varios números.");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio");
            Console.WriteLine("Otro- Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void SolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número ");
            int valor = Convert.ToInt32(Console.ReadLine());
            acumulador += valor;
            contador++;

            if (contador==1 || valor > maximo)
            { 
                maximo = valor;
            }

            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }
        }
        static void SolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese  cuantos números va a ingresar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidad; n++)
            {
                SolicitarNumero();
            }
        }
        static void MostrarMaximo()
        {
            Console.Clear();
            Console.WriteLine("Mostrar máximo: "+ maximo);

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();            
        }
        static void MostrarMinimo()
        {
            Console.Clear();
            Console.WriteLine("Mostrar mímimo: " + minimo);

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void CalcularYMostrarPromedio()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de promedio\n\n");

            if (contador > 0)
            {
                double promedio = acumulador / contador;
                Console.WriteLine("Promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("Promedio: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            contador = 0;
            maximo = 0;
            minimo = 0;
            acumulador = 0;

            int op = 0;

            op = SolicitarOpcionMenu();
            while (op != 1)
            {

                switch (op)
                {
                    case 1:
                        SolicitarNumero();
                        break;
                    case 2:
                        SolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarMaximo();
                        MostrarMinimo();
                        break;
                    case 4:
                        CalcularYMostrarPromedio();
                        break;
                    default:
                        op = -1;
                        break;
                }

                if(op<>-1)
                    op = SolicitarOpcionMenu();
            }
        }
    }
}
