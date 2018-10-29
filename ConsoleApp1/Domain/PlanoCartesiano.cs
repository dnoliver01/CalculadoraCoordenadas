using ConsoleApp1;
using System;

namespace Coordenadas
{
    public class PlanoCartesiano
    {
        public Coordenada Origem { get; private set; }
        public Coordenada PosicaoAtual { get; private set; }

        public PlanoCartesiano (Coordenada origem)
        {
            Origem = origem;
            PosicaoAtual = Origem;
        }

        public PlanoCartesiano(Coordenada origem, Coordenada posicaoAtual) : this(origem)
        {
            PosicaoAtual = posicaoAtual;
        }

        public Coordenada AdicionarVetor(Vetor vetor)
        {
            switch (vetor.Direcao)
            {
                case Direcoes.N:
                    //Norte => Adicionar intensidade do vetor ao eixo Y (Para cima)
                    PosicaoAtual.IncrementarY(vetor.Intensidade);
                    break;
                case Direcoes.S:
                    //Sul => Remover intensidade do vetor do eixo Y - (Para baixo)
                    PosicaoAtual.DecrementarY(vetor.Intensidade);
                    break;
                case Direcoes.L:
                    //Leste => Adicionar intensidade do vetor ao eixo X - (Para a direita)
                    PosicaoAtual.IncrementarX(vetor.Intensidade);
                    break;
                case Direcoes.O:
                    //Norte => Remover intensidade do vetor do eixo X - (Para a esquerda)
                    PosicaoAtual.DecrementarX(vetor.Intensidade);
                    break;
            }

            return PosicaoAtual;
        }
        public override string ToString()
        {
            return string.Format(Resource.coordAtual + "[{0},{1}]", PosicaoAtual.X, PosicaoAtual.Y);
        }

    }



}
