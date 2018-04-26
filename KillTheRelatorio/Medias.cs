using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillTheRelatorio
{
    public static class Medias
    {

        public static string MediaQuadratica(List<double> listMedias)
        {
            double limiteLogico = listMedias.Count; // quantidade de notas
            string MQ;   // media raiz quadratica
            double soma = 0;  // soma de todas as notas

            for (int i = 0; i <= (limiteLogico - 1); i++)
            // de 0 ate o a ultima casa com valores no vetor
            {
                soma = soma + (listMedias[i] * listMedias[i]);
                // vai somando cada valor de nota ao quadrado : X² + Y² + ... + N²
            }

            MQ = Convert.ToString(Math.Pow((soma / limiteLogico), 0.5));
            // converte a raiz quadrada( ou elevacao a 0,5) 
            // da soma/quantidade de notas para string

            return (MQ); // retorna a string referente a media
        }

        public static string MediaHarmonica(List<double> listMedias)
        {

            string MH; // media Harmonica
            double limiteLogico = listMedias.Count; // quantidade de notas
            double soma = 0; // soma das notas

            for (int i = 0; i <= (limiteLogico - 1); i++) // de 0 até o numero de valores para media
            {
                soma = soma + (1 / listMedias[i]); // soma recebe soma + 1/nota 
            }

            MH = Convert.ToString(limiteLogico / soma);
            // a media harmonica é o numero de notas dividido pela soma
            return MH; // retorna a media harmonica
        }

        public static string MediaAritmetica(List<double> listMedias)
        {

            string MA; // media aritmetica
            double limiteLogico = listMedias.Count; // quantidade de notas
            double soma = 0; // soma das notas

            for (int i = 0; i <= (limiteLogico - 1); i++)  // de 0 até o numero de valores para media
            {
                soma += listMedias[i];   // a soma recebe a soma anterior + o valor da nota
            }

            MA = Convert.ToString(soma / limiteLogico);
            // a media aritmetica é a soma dividida pelo nº de valores que haviam no vetor

            return MA; // retorna a media aritmetica
        }

        public static string MediaPonderada(List<double> listMedias, List<double> listPesos)
        {
            string MP; // media ponderada
            double limiteLogico = listMedias.Count; // quantidade de notas e seus pesos
            double soma = 0; // soma das notas
            double somaPesos = 0;// soma dos pesos para divisao

            for (int i = 0; i <= (limiteLogico - 1); i++)  // de 0 até o numero de valores para media
            {
                soma += (listMedias[i] * listPesos[i]);
                // soma recebe soma + a media multiplicada pelo seu peso
                somaPesos += listPesos[i];
                // soma os pesos
            }

            MP = Convert.ToString(soma / somaPesos);
            // divide a soma dos valores pela soma dos pesos

            return MP; // retorna a media
        }

        public static string MediaGeometrica(List<double> listMedias)
        {
            string MG; // media geometrica
            double limiteLogico = listMedias.Count; // quantidade de notas
            double produto = 1; // produto das notas

            for (int i = 0; i <= (limiteLogico - 1); i++)
            // de 0 até o numero de valores para media
            {
                produto *= listMedias[i];   // produto recebe ele * o valor indexado
            }
            double potencia = 1 / limiteLogico;
            // a potencia é a fracao 1 / numeros de notas
            MG = Convert.ToString(Math.Pow(produto, potencia));
            // converte para string a media: produto elevado a fracao
            return MG;
        }

    }
}
