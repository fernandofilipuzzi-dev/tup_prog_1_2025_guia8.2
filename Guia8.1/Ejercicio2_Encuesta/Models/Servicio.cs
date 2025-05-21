
namespace Ejercicio2_Encuesta.Models
{
    internal class Servicio
    {
        public int CantidadEncuestados;

        int contadorBici;
        int contadorMoto;
        int contadorAuto;
        int contadorPublico;

        double acumuladorDistanciaBici;
        double acumuladorDistanciaMoto;
        double acumuladorDistanciaAuto;
        double acumuladorDistanciaPublico;

        public void RegistrarEncuesta(int tipoTransporte, double distancia)
        {
            switch (tipoTransporte)
            {
                case 1:
                    {
                        acumuladorDistanciaBici += distancia;
                        contadorBici++;
                    }
                    break;
                case 2:
                    {
                        acumuladorDistanciaMoto += distancia;
                        contadorMoto++;
                    }
                    break;
                case 3:
                    {
                        acumuladorDistanciaAuto += distancia;
                        contadorAuto++;
                    }
                    break;
                case 4:
                    {
                        acumuladorDistanciaPublico += distancia;
                        contadorPublico++;
                    }
                    break;
            }
            CantidadEncuestados++;
        }

        public double CalcularPromedioPorTipo(int tipoTransporte)
        {
            double promedio = 0;
            
            switch (tipoTransporte)
            {
                case 1:
                    {
                        if(contadorBici>0)
                            promedio = 1.0 * acumuladorDistanciaBici / contadorBici;
                    }
                    break;
                case 2:
                    {
                        if(contadorMoto>0)
                            promedio = 1.0 *acumuladorDistanciaMoto / contadorMoto;
                    }
                    break;
                case 3:
                    {
                        if(contadorAuto>0)
                            promedio = 1.0 *acumuladorDistanciaAuto / contadorAuto;
                    }
                    break;
                case 4:
                    {
                        if(contadorPublico>0)
                            promedio = 1.0 *acumuladorDistanciaPublico / contadorPublico;
                    }
                    break;
            }

            return promedio;
        }
    }
}
