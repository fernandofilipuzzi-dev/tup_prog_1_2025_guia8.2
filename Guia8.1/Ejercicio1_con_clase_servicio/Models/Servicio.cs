
namespace Ejercicio1_con_clase_servicio.Models
{
    internal class Servicio
    {
        int acumulador;
        public int Contador;
        public int Maximo, Minimo;

        public Servicio()
        {
            Contador = 0;
            Maximo = 0;
            Minimo = 0;
        }

        public double CalcularPromedio()
        { 
            if(Contador>0)
                return 1.0*acumulador/Contador;
            return 0;
        }

        public void RegistrarValor(int valor)
        {
            acumulador += valor;
            Contador++;

            if (Contador == 1 || valor > Maximo)
            {
                Maximo = valor;
            }

            if (Contador == 1 || valor < Minimo)
            {
               Minimo = valor;
            }
        }
    }
}
