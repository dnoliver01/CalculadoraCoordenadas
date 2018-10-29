using System.Text.RegularExpressions;

namespace Coordenadas
{
    public class Coordenada
    {

        public int X {get; private set;}
        public int Y {get; private set;}

        public Coordenada(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public void IncrementarX (int elementoX)
        {
            X += elementoX;
        }

        public void IncrementarY (int ElementoY)
        {
            Y += ElementoY;
        }

        public void DecrementarX(int elementoX)
        {
            X -= elementoX;
        }

        public void DecrementarY(int ElementoY)
        {
            Y -= ElementoY;
        }

        public string CoordenadaFormatada()
        {
            return string.Format("[{0},{1}]",X,Y);
        }

        public static bool ValidarCoordenada(string coordenada)
        {
            if (Regex.IsMatch(coordenada, @"^-?[0-9,\.]+$"))
                return false;

            return true;
        }
    }
}