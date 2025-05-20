using Ejercicio3_Control_acceso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Control_acceso
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region metodos
        public static int MostrarPantallaSolicitarOpcion()
        {
            Console.WriteLine("Control de acceso \n\n");
            Console.WriteLine("1- Verificar Acceso");
            Console.WriteLine("2- Imprimir Recaudacion");
            Console.WriteLine("");
            int op=Convert.ToInt32(Console.ReadLine());
            return op;
        }

        public static void MostrarPantallaRegistrarAcceso()
        {
            Console.WriteLine("Control de acceso \n\n");
            int esValido = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarAcceso(esValido==1,3,3,3);
        }
        #endregion

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcion();

            while(op!=-1) 
            {
                switch(op)
                {
                    case 1:
                        MostrarPantallaRegistrarAcceso();
                        break;
                }

                op = MostrarPantallaSolicitarOpcion();
            }
            
        }
    }
}
