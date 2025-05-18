using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Control_acceso.Models
{
    internal class Servicio
    {
        int CantidadEncuestados;

        int ContadorBici;
        int ContadorMoto;
        int ContadorAuto;
        int ContadorPublico;

        double AcumuladorDistanciaBici;
        double AcumuladorDistanciaMoto;
        double AcumuladorDistanciaAuto;
        double AcumuladorDistanciaPublico;

        public void RegistrarEncuesta(double distancia, int tipoTransporte)
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
        }
    }
}
