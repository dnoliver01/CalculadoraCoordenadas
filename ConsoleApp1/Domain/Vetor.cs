using System;
using System.Text.RegularExpressions;

namespace Coordenadas
{
    public class Vetor
    {
        public Direcoes Direcao { get; private set; }
        public int Intensidade { get; private set; }

        public Vetor(Direcoes pDirecao, int pIntensidade)
        {
                Direcao = pDirecao;

                Intensidade = pIntensidade;
        }

        public override string ToString()
        {
            char letra;
            switch (Direcao)
            {
                case Direcoes.S:
                    letra = 'S';
                    break;
                case Direcoes.L:
                    letra = 'L';
                    break;
                case Direcoes.O:
                    letra = 'O';
                    break;
                case Direcoes.N:
                default:
                    letra = 'N';
                    break;
            }

            return string.Format("({0},{1})", letra, Intensidade);
        }

        public static bool ValidarDirecao(string pDirecao)
        {
            if (Regex.IsMatch(pDirecao.ToUpper(), @"^[NSLO]$"))
                return false;

            return true;
        }

        public static bool ValidarIntensidade(string pIntensidade)
        {

            //if (Regex.IsMatch(pIntensidade, @"^-?[0-9][0-9,\.]+$"))
            if (Regex.IsMatch(pIntensidade, @"^-?[0-9,\.]+$"))
                return false;

            return true;
        }

    }
}