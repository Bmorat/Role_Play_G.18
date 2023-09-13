using System.Runtime.CompilerServices;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos Daga = new Elementos("Daga", 20, 0);
            Elementos Escudo = new Elementos("Escudo", 0, 20);
            Enanos Enano_1 = new Enanos(Daga, Escudo);
            Console.WriteLine(Enano_1.Item_1.AtaqueItem); //aqui imprimo en consola el valor de ataque del item 1 que tiene el enano 1.
        }

        public int ObtenerAtaqueTotalEnano(Enanos enano_en_cuestion)
        {
            return 0; //codigo en desarrollo
        }

        public int ObtenerArmaduraTotalEnano(Enanos enano_en_cuestion)
        {
            return 0; //codigo en desarrollo
        }
    }
}
