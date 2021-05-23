using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.controller
{
    class EstadoConvert
    {
        public static String getEstadoUf(int idEstado)
        {
            return Converter(idEstado);
        }
        /// <summary>
        /// CONVERTE UMA String idEstado PARA UMA String UF
        /// </summary>
        /// <param name="idEstado"></param>
        /// <returns></returns>
        public static String getEstadoUf(String idEstado)
        {
            int idEstadoNum = Convert.ToInt32(idEstado);
            return Converter(idEstadoNum);
        }

        /// <summary>
        /// CONVERTE UM int idEstado PARA UMA String UF
        /// </summary>
        /// <param name="idEstadoNum"></param>
        /// <returns></returns>
        private static string Converter(int idEstadoNum)
        {
            switch (idEstadoNum)
            {
                case 1:
                    return "AC";
                case 2:
                    return "AL";
                case 3:
                    return "AP";
                case 4:
                    return "AM";
                case 5:
                    return "BA";
                case 6:
                    return "CE";
                case 7:
                    return "DF";
                case 8:
                    return "ES";
                case 9:
                    return "GO";
                case 10:
                    return "MA";
                case 11:
                    return "MT";
                case 12:
                    return "MS";
                case 13:
                    return "MG";
                case 14:
                    return "PA";
                case 15:
                    return "PB";
                case 16:
                    return "PR";
                case 17:
                    return "PE";
                case 18:
                    return "PI";
                case 19:
                    return "RJ";
                case 20:
                    return "RN";
                case 21:
                    return "RS";
                case 22:
                    return "RO";
                case 23:
                    return "RR";
                case 24:
                    return "SC";
                case 25:
                    return "SP";
                case 26:
                    return "SE";
                case 27:
                    return "TO";
                default:
                    return "";
            }
        }
    }
}
