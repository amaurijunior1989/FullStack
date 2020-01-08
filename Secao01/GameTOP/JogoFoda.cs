using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda
    {
        private readonly IJogador _jogador1;

        private readonly IJogador _jogador2;

        public JogoFoda(IJogador jogador1,IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.Corre());
            System.Console.Write(_jogador1.Passe());
            System.Console.Write(_jogador1.Corre());

    System.Console.Write("\n Proximo Jogador \n");

            System.Console.Write(_jogador2.Corre());
            System.Console.Write(_jogador2.Passe());
            System.Console.Write(_jogador2.Corre());
        }
    }
}