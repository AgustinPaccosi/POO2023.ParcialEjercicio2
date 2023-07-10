using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Parcial.Entidades
{
    public static class Validador
    {
        public static bool Validar(int dia, int mes, int anio)
        {
            if(anio<1 || mes>12 || dia < 1)
            {
                return false;
            }
            int maximodiasporMes = DiasPorMes(mes, anio);
            return dia <= maximodiasporMes;
        }

        private static int DiasPorMes(int mes, int anio)
        {
            if(mes==1||mes==3||mes==5|| mes == 7 || mes == 8 || mes == 10|| mes == 12)
            {
                return 31;
            }
            else if(mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                return 30;
            }
            else
            {
                if (EsBisiesto(anio))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
        }

        private static bool EsBisiesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return true; }
            }
            else { return false; }
        }

    }
}
