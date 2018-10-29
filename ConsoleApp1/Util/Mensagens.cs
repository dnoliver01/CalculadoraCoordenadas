using System;

namespace ConsoleApp1.Util
{
    public static class Mensagens
    {
        public static void MensagemInicial()
        {
            Console.WriteLine(Resource.Titulo);
            Console.WriteLine(String.Empty);
            Console.WriteLine(Resource.partidaInicial);

            Console.WriteLine(string.Empty);
        }

        public static bool MensagemFechamentoPrograma(string saidaPrograma)
        {
            if (saidaPrograma.ToUpper() == "SAIR" || saidaPrograma.ToUpper() == "SAI" || saidaPrograma.ToUpper() == "SA" || saidaPrograma.ToUpper() == "AIR" || saidaPrograma.ToUpper() == "IR")
                return true;

            return false;
        }

        public static void MensagemPosicaoAtual(string planoCartesiano)
        {
            Console.WriteLine(String.Empty);
            Console.WriteLine(planoCartesiano);

            Console.WriteLine(Resource.addDisDir);
        }

        public static void MensagemValorX(bool erro)
        {

            if (erro == true)
                Console.WriteLine(Resource.erroXeY);

            Console.WriteLine(Resource.digiteX);

        }

        public static void MensagemValorY(bool erro)
        {
            if (erro == true)
                Console.WriteLine(Resource.erroXeY);

            Console.WriteLine(Resource.digiteY);
        }

        public static void MensagemVazia()
        {
            Console.WriteLine(String.Empty);
        }

        public static void MensagemDirecao(bool erro)
        {
            MensagemVazia();

            if (erro == true)
                Console.WriteLine(Resource.direcaoInv);

            Console.WriteLine(Resource.digiteDir);
        }

        public static void MensagemIntensidade(bool erro)
        {
            MensagemVazia();

            if (erro == true)

                Console.WriteLine(Resource.intensInv);

            Console.WriteLine(Resource.digiteDis);
        }
    }
}
