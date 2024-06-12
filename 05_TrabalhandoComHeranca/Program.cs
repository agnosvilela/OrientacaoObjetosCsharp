using Personagens;
namespace TrabalhandoComHeranca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cavaleiro = new Cavaleiro("Aragon", "100");
            var arqueiro = new Arqueiro("Legolas", "100");

            cavaleiro.Atacar();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.Defender();

        }
    }
}