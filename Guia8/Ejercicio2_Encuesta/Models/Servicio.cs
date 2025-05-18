
namespace Ejercicio2_Encuesta.Models
{
    internal class Servicio
    {
        public int CantidadEncuestados;

        int ContadorBici;
        int ContadorMoto;
        int ContadorAuto;
        int ContadorPublico;

        double AcumuladorDistanciaBici;
        double AcumuladorDistanciaMoto;
        double AcumuladorDistanciaAuto;
        double AcumuladorDistanciaPublico;

        public void RegistrarEncuesta(int tipoTransporte, double distancia)
        {
            switch (tipoTransporte)
            {
                case 1:
                    {
                        AcumuladorDistanciaBici += distancia;
                        ContadorBici++;
                    }
                    break;
                case 2:
                    {
                        AcumuladorDistanciaMoto += distancia;
                        ContadorMoto++;
                    }
                    break;
                case 3:
                    {
                        AcumuladorDistanciaAuto += distancia;
                        ContadorAuto++;
                    }
                    break;
                case 4:
                    {
                        AcumuladorDistanciaPublico += distancia;
                        ContadorPublico++;
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
                        if(ContadorBici>0)
                            promedio = 1.0 * AcumuladorDistanciaBici / ContadorBici;
                    }
                    break;
                case 2:
                    {
                        if(ContadorMoto>0)
                            promedio = 1.0 *AcumuladorDistanciaMoto / ContadorMoto;
                    }
                    break;
                case 3:
                    {
                        if(ContadorAuto>0)
                            promedio = 1.0 *AcumuladorDistanciaAuto / ContadorAuto;
                    }
                    break;
                case 4:
                    {
                        if(ContadorPublico>0)
                            promedio = 1.0 *AcumuladorDistanciaPublico / ContadorPublico;
                    }
                    break;
            }

            return promedio;
        }
    }
}
