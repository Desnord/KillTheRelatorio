using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillTheRelatorio
{
    public static class Incertezas
    {


        public static string IncertezaPadraoCombinada(List<double> listIncertezas)
        {
            string u = "";
            int qtde = listIncertezas.Count;
            double soma = 0;

            for(int i=0; i<= qtde-1; i++)
            {
                soma += listIncertezas[i] * listIncertezas[i]; 
            }

            u = Convert.ToString(Math.Pow(soma, 0.5));

            return u;

        }

        public static string IncPadLeituraDig(double a)
        {
            return Convert.ToString(a / (2 * Math.Pow(3,0.5)));
        }

        public static string IncPadLeituraAnalog(double a)
        {
            return Convert.ToString(a / (2 * Math.Pow(6, 0.5)));
        }

        public static string DesvioPadraoExp(double media, List<double> listValores)
        {
            double dp = 0;
            double soma = 0;

            for (int i=0; i< listValores.Count;i++)
            {
                soma += Math.Pow((listValores[i]-media),2);
            }
            dp = Math.Pow((soma/(listValores.Count-1)),0.5);

            return Convert.ToString(dp);
        }

        public static string IncMedicoesRep(double media, List<double> listValores)
        {
            return Convert.ToString(Convert.ToDouble(DesvioPadraoExp(media, listValores)) / Math.Pow(listValores.Count, 0.5));
        }
    }
}
