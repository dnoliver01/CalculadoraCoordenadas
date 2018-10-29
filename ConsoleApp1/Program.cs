using ConsoleApp1;
using ConsoleApp1.Util;
using Coordenadas;
using System;

namespace CalculadoraCoordenadas
{
    class Program
    {
        private static bool saida;
        private static string Direcao;

        public static string Intensidade;
        private static string valorX;
        private static string valorY;
        public static bool Erro;

        static void Main(string[] args)
        {
            #region mensagensIniciais

            Mensagens.MensagemInicial();

            #endregion

            #region preenchimentosIniciais
            do
            {
                Mensagens.MensagemValorX(Erro);

                valorX = Console.ReadLine();

                Erro = Coordenada.ValidarCoordenada(valorX);

            } while (Erro == true);

            do
            {
                Mensagens.MensagemValorY(Erro);

                valorY = Console.ReadLine();

                Erro = Coordenada.ValidarCoordenada(valorY);

            } while (Erro == true);

            #endregion

            #region instanciaçãoClasses

            var coordenada = new Coordenada(int.Parse(valorX), int.Parse(valorY));

            var planocartesiano = new PlanoCartesiano(coordenada);

            Console.WriteLine(String.Empty);
            Console.WriteLine(string.Concat(Resource.coordIni + coordenada.CoordenadaFormatada()));

            #endregion

            #region calculoPlanoCartesiano
            do
            {
                #region ValidacaoDaDirecao
                do
                {                    
                    Mensagens.MensagemDirecao(Erro);

                    Direcao = Console.ReadLine();
                    Erro = Vetor.ValidarDirecao(Direcao);

                } while (Erro == true);
                #endregion

                #region ValidacaoIntensidade
                do
                    {

                    Mensagens.MensagemIntensidade(Erro);

                    Intensidade = Console.ReadLine();

                    Erro = Vetor.ValidarIntensidade(Intensidade);

                } while (Erro == true);
                #endregion

                #region AdicionarVetor
                Enum.TryParse(Direcao.ToUpper(), out Direcoes direcoes);

                var vetor = new Vetor(direcoes, int.Parse(Intensidade));

                planocartesiano.AdicionarVetor(vetor);
                #endregion

                #region ExibirPosicaoAtual

                Mensagens.MensagemPosicaoAtual(planocartesiano.ToString());

                var saidaComando = Console.ReadLine();
                #endregion

                #region FechamendoPrograma

                saida = Mensagens.MensagemFechamentoPrograma(saidaComando);

                #endregion

            } while (saida == false);
            #endregion
        }
    }
}
