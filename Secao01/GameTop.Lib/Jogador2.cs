using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando! \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo! \n";
        }

        public string Passe()
        {
            return "Maradona estas passiendo! \n ";
        }
    }
}